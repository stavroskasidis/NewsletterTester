using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsletterTester
{
    public class RecentData
    {
        public List<RecentUrl> RecentUrls { get; set; } = new List<RecentUrl>();
        public List<RecentEmail> RecentEmails { get; set; } = new List<RecentEmail>();
    }

    public class RecentUrl
    {
        public string Url { get; set; }
        public DateTime LastUsed { get; set; }
    }

    public class RecentEmail
    {
        public string Email { get; set; }
        public DateTime LastUsed { get; set; }
    }
}
