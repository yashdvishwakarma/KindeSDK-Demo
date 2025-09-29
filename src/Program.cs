using System;
using System.Net.Http;
using System.Threading.Tasks;
using KindeSDK;

class Program
{
    static async Task Main(string[] args)
    {
        var httpClient = new HttpClient();
        var authService = new KindeAuthentication(httpClient);

        try
        {
            var token = await authService.AuthenticateAsync("your-client-id", "your-client-secret");
            Console.WriteLine($"Authentication successful. Token: {token}");
        }
        catch (KindeAuthenticationException ex)
        {
            Console.WriteLine($"Authentication failed: {ex.Message}");
        }
    }
}
