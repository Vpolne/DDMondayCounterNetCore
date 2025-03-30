using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text.Json;

namespace DDMondaysWinnerCount
{
    public class WebClientEx : WebClient
    {
        private CookieContainer _cookieContainer = new CookieContainer();
        private const string CookieFile = "cookiejar.json";

        public WebClientEx(string email, string password, string authTarget = null)
        {
            authTarget ??= "https://members-ng.iracing.com/auth";
            var data = new NameValueCollection
            {
                { "email", email },
                { "password", password },
            };
            _ = UploadValues(authTarget, data);
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            LoadCookies();
            if (request is HttpWebRequest httpRequest)
            {
                httpRequest.CookieContainer = _cookieContainer;
            }
            return request;
        }

        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            SaveCookies(response);
            return response;
        }

        private void LoadCookies()
        {
            if (File.Exists(CookieFile))
            {
                try
                {
                    string json = File.ReadAllText(CookieFile);
                    var cookies = JsonSerializer.Deserialize<List<Cookie>>(json);
                    foreach (var cookie in cookies)
                    {
                        _cookieContainer.Add(new Uri("https://members-ng.iracing.com"), cookie);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading cookies: " + ex.Message);
                }
            }
        }

        private void SaveCookies(WebResponse response)
        {
            if (response is HttpWebResponse httpResponse)
            {
                var cookies = httpResponse.Cookies;
                var cookieList = new List<Cookie>();
                foreach (Cookie cookie in cookies)
                {
                    cookieList.Add(cookie);
                }
                try
                {
                    string json = JsonSerializer.Serialize(cookieList, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(CookieFile, json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error saving cookies: " + ex.Message);
                }
            }
        }
    }
}
