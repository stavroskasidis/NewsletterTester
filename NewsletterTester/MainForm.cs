using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NewsletterTester
{
    public partial class MainForm : Form
    {
        private string _smtp;
        private int _smtpPort;
        private bool _enableSsl;
        private string _username;
        private string _password;
        private RecentData _recentData;

        public MainForm()
        {
            InitializeComponent();

            try
            {
                _smtp = ConfigurationManager.AppSettings["smtp"];
                _smtpPort = int.Parse(ConfigurationManager.AppSettings["smtp_port"]);
                _enableSsl = bool.Parse(ConfigurationManager.AppSettings["smtp_enable_ssl"]);
                _username = ConfigurationManager.AppSettings["smtp_username"];
                _password = ConfigurationManager.AppSettings["smtp_password"];

                _recentData = ReadRecentData();
                NewsletterUrlComboBox.DisplayMember = "Url";
                NewsletterUrlComboBox.ValueMember = "Url";

                NewsletterSendToComboBox.DisplayMember = "Email";
                NewsletterSendToComboBox.ValueMember = "Email";

                BindComboBoxes(_recentData);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading configuration: " + ex.ToString());
                Environment.Exit(1);
            }
        }

        private async void SendButton_ClickAsync(object sender, EventArgs e)
        {
            SendButton.Enabled = false;
            SpinnerPictureBox.Image = Resources.Spinner;
            try
            {
                var url = NewsletterUrlComboBox.Text;
                var emailTo = NewsletterSendToComboBox.Text;

                ValidateData(url, emailTo);
                
                MessageLabel.Text = "Downloading url ...";



                using (var httpClient = new HttpClient())
                using (var response = await httpClient.GetAsync(url))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception(response.ReasonPhrase);
                    }


                    var mimeMessage = new MimeMessage();
                    mimeMessage.From.Add(new MailboxAddress("Newsletter Tester", _username));
                    mimeMessage.To.Add(new MailboxAddress(emailTo));
                    mimeMessage.Subject = $"Newsletter Tester '{url}'";

                    var builder = new BodyBuilder();
                    var responseString = await response.Content.ReadAsStringAsync();
                    builder.HtmlBody = responseString;

                    mimeMessage.Body = builder.ToMessageBody();
                    using (var client = new SmtpClient())
                    {

                        MessageLabel.Text = "Connecting to smtp ...";
                        // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                        //client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                        await client.ConnectAsync(_smtp, _smtpPort, MailKit.Security.SecureSocketOptions.Auto);

                        if (!string.IsNullOrWhiteSpace(_username) && !string.IsNullOrWhiteSpace(_password))
                        {
                            MessageLabel.Text = "Authenticating with smtp ...";
                            await client.AuthenticateAsync(_username, _password);
                        }
                        MessageLabel.Text = "Sending e-mail ...";
                        await client.SendAsync(mimeMessage);
                        MessageLabel.Text = "E-mail sent successfully !";
                        SpinnerPictureBox.Image = Resources.Check;
                        await client.DisconnectAsync(true);
                    }

                    AddToRecentData(_recentData, url, emailTo);
                }

            }
            catch (Exception ex)
            {
                SpinnerPictureBox.Image = Resources.Cross;
                MessageBox.Show(ex.ToString());
                MessageLabel.Text = "Error sending e-mail !";
            }

            SendButton.Enabled = true;
        }

        private void ClearRecentEmailsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear recent e-mails ?", "Recent e-mails", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _recentData.RecentEmails.Clear();
                SaveRecentData(_recentData);
                BindComboBoxes(_recentData);
                NewsletterSendToComboBox.Text = null;
            }
        }

        private void ClearRecentUrlsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear recent urls ?", "Recent urls", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _recentData.RecentUrls.Clear();
                SaveRecentData(_recentData);
                BindComboBoxes(_recentData);
                NewsletterUrlComboBox.Text = null;
            }
        }


        private RecentData ReadRecentData()
        {
            if (!File.Exists("recent.xml"))
            {
                return new RecentData();
            }

            var serializer = new XmlSerializer(typeof(RecentData));
            using (var reader = new StreamReader("recent.xml"))
            {
                return serializer.Deserialize(reader) as RecentData;
            }
        }

        private void SaveRecentData(RecentData data)
        {
            var serializer = new XmlSerializer(typeof(RecentData));
            using (var writer = new StreamWriter("recent.xml", false))
            {
                serializer.Serialize(writer, data);
            }
        }

        private void BindComboBoxes(RecentData data)
        {
            NewsletterUrlComboBox.Items.Clear();
            NewsletterUrlComboBox.Items.AddRange(data.RecentUrls.OrderByDescending(x => x.LastUsed).ToArray());

            NewsletterSendToComboBox.Items.Clear();
            NewsletterSendToComboBox.Items.AddRange(data.RecentEmails.OrderByDescending(x => x.LastUsed).ToArray());
        }

        private void ValidateData(string url, string emailTo)
        {
            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult))
            {
                throw new Exception("Invalid URL");
            }

            try
            {
                var addr = new MailboxAddress(emailTo);
            }
            catch (Exception)
            {
                throw new Exception("Invalid e-mail");
            }
        }

        private void AddToRecentData(RecentData data, string url, string email)
        {
            var existingUrl = data.RecentUrls.FirstOrDefault(x => x.Url == url);
            if (existingUrl == null)
            {
                data.RecentUrls.Add(new RecentUrl
                {
                    Url = url,
                    LastUsed = DateTime.Now
                });

                if (data.RecentUrls.Count > 10)
                {
                    var last = data.RecentUrls.OrderBy(x => x.LastUsed).First();
                    data.RecentUrls.Remove(last);
                }
            }
            else
            {
                existingUrl.LastUsed = DateTime.Now;
            }

            var existingEmail = data.RecentEmails.FirstOrDefault(x => x.Email == email);
            if (existingEmail == null)
            {
                data.RecentEmails.Add(new RecentEmail
                {
                    Email = email,
                    LastUsed = DateTime.Now
                });

                if (data.RecentEmails.Count > 10)
                {
                    var last = data.RecentEmails.OrderBy(x => x.LastUsed).First();
                    data.RecentEmails.Remove(last);
                }
            }
            else
            {
                existingEmail.LastUsed = DateTime.Now;
            }

            SaveRecentData(data);
            BindComboBoxes(data);
        }
    }
}
