using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckWordPressURL
{
    internal class CheckURL
    {
        internal bool CheckURLOnWordPress(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    string htmlPage = client.GetStringAsync(url).Result;

                    if (htmlPage.Contains("<meta name=generator content=WordPress"))
                    {
                        return true;
                    }
                    if (htmlPage.Contains("wp-content") || htmlPage.Contains("wp-includes") || htmlPage.Contains("wp-admin"))
                    {
                        return true;
                    }
                    return false;
                } 
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"Ошибка авторизации {e}");
                return false;
            }
        }
    }
}
