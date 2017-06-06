using System;
using System.Linq;
using OAuth2.Helpers;

namespace OAuth2
{
    class Program
    {
        static readonly string authUrl = "https://id.winks.io/ids";
        static readonly string clientId = "#CLIENT_ID#";
        static readonly string clientSecret = "#SECRET_CODE#";
        static readonly string companyName = "#COMPANY_NAME#";
        static readonly string callbackUrl = "http://localhost:55555/";
        static string accessToken = "";

        static void Main(string[] args)
        {
            accessToken = Connect.Token(authUrl, clientId, clientSecret, callbackUrl);
            Console.WriteLine("Yay! You got an access token ;-)");
            Console.ReadLine();
        }
    }
}
