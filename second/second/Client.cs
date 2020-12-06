using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace second
{
    public class Client
    {
        public bool Ping(string link)
        {
            var client = new WebClient();
            try
            {
                client.DownloadString(link);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string GetInputData(string link)
        {
            var client = new WebClient();
            return client.DownloadString(link);
        }

        public void WriteAnswer(string link, string answer)
        {
            var client = new WebClient();
            var sendstring = Encoding.UTF8.GetBytes(answer);
            client.UploadData(link, sendstring);
        }
    }
}
