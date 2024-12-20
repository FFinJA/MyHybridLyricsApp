namespace MyHybridLyricsApp.Services;

public class AppState
{
    public bool isEnvVarsConfigured { get; set; } = false;
    public string ClientId { get; set; } = "";
    public string ClientSecret { get; set; } = "";
    public string RedirectURI { get; set; } = "";

    public void setEnvVarsConfigured(bool configured)
    {
        isEnvVarsConfigured = configured;
    }

    public void setCredentials(string clientId, string clientSecret, string redirectURI)
    {
        ClientId = clientId;
        ClientSecret = clientSecret;
        RedirectURI = redirectURI;
    }
}