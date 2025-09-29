using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace KindeSDK
{
    public class KindeAuthentication
    {
        private readonly HttpClient _httpClient;

        public KindeAuthentication(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> AuthenticateAsync(string clientId, string clientSecret)
        {
            try
            {
                var response = await _httpClient.PostAsync("https://api.kinde.com/authenticate", new StringContent($"client_id={clientId}&client_secret={clientSecret}"));
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrEmpty(content))
                {
                    throw new KindeAuthenticationException("No token received from Kinde API.");
                }

                return content;
            }
            catch (HttpRequestException ex)
            {
                throw new KindeAuthenticationException("Error during authentication request.", ex);
            }
        }
    }
}
