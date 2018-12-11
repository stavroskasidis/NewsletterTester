# NewsletterTester
A simple winforms project for testing html based newsletters.

# How it works
The app performs a GET request to a url, downloads its contents and send them as the body of an e-mail to the provided address(es).

# How to use
1. Download the latest version from [here](https://github.com/stavroskasidis/NewsletterTester/releases) and extract to a folder.
2. Open the NewsletterTester.exe.config and set your smtp settings in the `<appSettings>` section.
3. Run the app.
4. Provide the url to test.
5. Provide the e-mail address(es) to send the e-mail to.
6. Press the "Send" button.
