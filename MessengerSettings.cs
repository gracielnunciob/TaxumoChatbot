public class MessengerSettings
{
    public string ApplicationName { get; set; } = "Taxubot";
    // App Secret can be retrieved from the App Dashboard
    public string FBAppSecret { get; set; } = "eeaff01998b7b1ae076d13a68ea2487e";
    // Arbitrary value used to validate a webhook
    public string FBValidationToken { get; set; } = "1234";
    // Generate a page access token for your page from the App Dashboard
    public string FBPageAccessToken { get; set; } = "EAAesfiQ7Mu4BAKYv1Eqt977s1Fb9DcL1ZAOrBgZC9JNCA8ZAz7mtcfAsrPEQWBskXJOw4ZCh4OjmyJf8MDDCQw7odjmPsjmz3lvn2NlYMn9oJaQIZAwRamvtsRT3FYgSZBbH24I2ZBaZBOQ1cz0QsaZBVBrWvxZC9KIhIKFLQOg6xtCmgaPJsGsXWS";
    // URL where the app is running (include protocol). Used to point to scripts and 
    // assets located at this address. 
    public string ServerURL { get; set; } = "https://d6a69f38.ngrok.io";
}