namespace CoCDirectoryApp.Views;

public partial class AboutPage : ContentPage
{
    public string TermsHtml { get; set; } = string.Empty;
    public AboutPage()
    {
        InitializeComponent();
        BindingContext = this;
        var htmlSource = new HtmlWebViewSource
        {
            Html = @"
    <html>
    <head>
        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
        <style>
            body { font-family: Arial; padding: 15px; color: #333; line-height: 1.6; }
            h1, h2, h3 { color: #2c3e50; }

            hr { border: 0; border-top: 1px solid #ccc; margin: 20px 0; }
        </style>
    </head>
    <body>
    <h1>CocDirectory</h1>
    <h2>Terms and Conditions</h2>
    <p><em>August 2025</em></p>

    <h3>Introduction & Acceptance of Agreement</h3>
    <p>Welcome to the CocDirectory digital service application. These are our terms and conditions for use of the application, which you may access through the information section of the application. Please read these terms and conditions of use carefully before accessing, using, or obtaining any materials, information, products, or services through the CocDirectory platform. In these Terms, “we”, “us”, “our”, or “CocDirectory”, refers to the CocDirectory Corporation, and “you” or “your” refers to you as the user of our website or application.</p>
    
    <p><i>By accessing and using the CocDirectory mobile  application, you accept and agree to be bound by our terms and conditions of use. In addition, when using this service, you will be subject to the guidelines and rules enclosed in this agreement. If you do not agree to abide by our terms and conditions, then you may not use our website or application.
    </i></p>
    <h3>Privacy Policy</h3>
    <p>CocDirectory places the privacy of its users at the forefront of our priorities.  We hereby outline the CocDirectory privacy policy and describe the practices that we will follow concerning the privacy of the information of users of our service. Should you have any questions about this policy or our practices, please send an email to churchofchristnigeriadirectory@gmail.com </p>
    <p> We hereby outline the CocDirectory privacy policy and describe the practices that we will follow with respect to the privacy of the information of users of our service. Should you have any questions about this policy or our practices, please send an email to churchofchristnigeriadirectory@gmail.com 
    </p>
    <h3>What Personal Information We Collect</h3>
    <p>CocDirectory collects your personal information online when you voluntarily provide it to us. If you choose to use CocDirectory, the app accesses two major types of information about users, which includes users' contacts and accounts
    <ul>    
    <li>Users Phone Contacts</li>
    <li>Users Account</li>
    </ul>
    </p>
    <h3>How We Use Your Personal Information</h3>
    <p>Internal Uses

   We may use your personal information within CocDirectory: (1) to quickly open up a number from your phone book for a quick call you wish to make; (2) to also easily open up email apps to send emails to users for cases of any user of our app who wishes to send out emails to people.

   Herein lies the purpose of the information that we collect:
    
    <ul>
    <li>Your contacts are to help quickly open numbers available on the app for a quick call.
     </li>
    <li>We access the account to enable users to quickly open any mailing app and send out emails to others right within the app.</li>
 </p>
    <h3>Disclosure of Personal Information to Third Parties</h3>
    <p>We will not disclose any personal information to any third party unless (1) you have authorized us to do so; (2) we are legally required to do so, for example, in response to a subpoena, court order or other legal process and/or, (3) it is necessary to protect our property rights related to this website. We also may share aggregate, non-personal information about website usage with unaffiliated third parties. This aggregate information does not contain any personal information about our users.
    </p>
    <h3>How We Protect Information Online</h3>
    <p>We exercise great care to protect your personal information. This includes, among other things, using Google Firebase to safely store your information on the cloud and protect it from intruders. As a result, while we strive to protect your personal information, we cannot ensure or warrant the security of any information you transmit to us or receive from us. This is especially true for information you transmit to us via your CocDirectory since we have no way of protecting that information until it reaches us.

    In addition, we limit CocDirectory's employees and contractors' access to personal information. Only those employees and contractors with a business reason to know have access to this information. We educate our employees about the importance of maintaining confidentiality of customer information.

    We review our security arrangements from time to time as we deem appropriate.
    </p>
    <h3>Accuracy Warning</h3>
    <p>The components of the CocDirectory  application are for informational purposes only. This is to include distance/proximity measurements and user information. We shall not be responsible or held liable for the accuracy, usefulness or availability of any information transmitted or made available via our application, and we shall not be responsible or liable for any error or omissions in that information.</p>
    <h3>Payment Policy</h3>
    <p>CocDirectory doesn't have any payment policy but might come up in the future which will be updated adequately.</p>
    <h3>Usage</h3>
    <p>As a condition of use, you promise not to use our  application for any activity that is unlawful or prohibited in our Terms. By example, and not as a limitation, you agree not to use our Services:
    <ul>
    <li>To scam and deceive people</li>
    <li>To communicate with CocDirectory representatives or other users in an abusive or offensive manner;</li>
    <li>For any purpose that breaches the laws of the jurisdiction where you access or use CocDirectory;</li>
    <li>To create or transmit unsolicited ‘spam’ to any CocDirectory representative or user;</li>
    </ul>
    </p>
    <h3>Liability Clause</h3>
    <p>We shall not be held responsible or liable for the following:
    <ul>
    <li>We are not liable if a user uses emails found in our app for a legitimate purpose but uses them otherwise.<li>
    <li>We are not liable if a user uses phone numbers found in our app meant for a legitimate purpose but used otherwise.</li>
    </ul>
    </p>
    <h3>Termination</h3>
    <p>If you are found to be in breach of these Terms, we may ban or terminate your access to the application, without cause or notice. This may result in the forfeiture and destruction of all information associated with your account.</p>
    <h3>Notes</h3>
    <p>As we update and improve our services, our terms and conditions of use are subject to change. Accordingly, please check back periodically.</p>
    </body>
    </html>
    "
        };
        TermsWebView.Source = htmlSource;

    }
}