using System;
using System.Net.Http;
using System.Threading.Tasks;

/*
    -- UnOfficial IPify API for C# --
    Last Update: 15-06-2019
    deniz.frosty@gmail.com
    Deniz @2019
*/

namespace Ipify
{
    public class IPifyAPI
    {
        private static readonly HttpClient client = new HttpClient();
        private static string requestURL_IPv4 = "https://api.ipify.org/?format=text";
        private static string requestURL_IPv6 = "https://api6.ipify.org/?format=text";
        private string ip_v4 = "0.0.0.0";
        private string ip_v6 = "ffff-ffff-ffff-ffff";

        public async Task update_IPv4()
        {
            ip_v4 = await client.GetStringAsync(requestURL_IPv4);
        }

        public async Task update_IPv6()
        {
            ip_v6 = await client.GetStringAsync(requestURL_IPv6);
        }

        public string IPv4
        {
            get
            {
               update_IPv4().Wait();
               return ip_v4;
            }
        }

        public string IPv6
        {
            get
            {
                update_IPv6().Wait();
                return ip_v6;
            }
        }

    }
}
