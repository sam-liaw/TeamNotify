using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TeamNotify
{
    public class Team
    {
        private static Dictionary<int, string> _dicUrl = new Dictionary<int, string>();
        private static string _Url              = "";

        public Team(Dictionary<int, string> dicUrl)
        {
            _dicUrl = dicUrl;
        }

        /// <summary>
        /// 送出 Team 的通知訊息
        /// </summary>
        /// <param name="message">訊息的內容字串</param>
        public void TeamNotify(string message, int channel, string fromTo)
        {
            try
            {
                if(_dicUrl.ContainsKey(channel))
                {
                    _Url = _dicUrl[channel];

                    PostMessage(message, fromTo);
                }
                else
                {
                    Console.WriteLine($"channel={channel} not find");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public class Payload
        {
            public string Title;
            public string Text;
        };

        /// <summary>
        /// Post a message using simple strings
        /// </summary>
        /// <param name="text"></param>
        /// <param name="title"></param>
        private void PostMessage(string text, string title)
        {
            Payload payload = new Payload()
            {
                Title = title,
                Text = text,
            };
            PostMessage(payload);
        }

        /// <summary>
        /// Post a message using a Payload object
        /// </summary>
        /// <param name="payload"></param>
        private async void PostMessage(Payload payload)
        {
            string payloadJson = JsonConvert.SerializeObject(payload);
            var content = new StringContent(payloadJson);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var client = new HttpClient();
            Uri uri = new Uri(_Url);
            await client.PostAsync(uri, content);
        }
    }

}
