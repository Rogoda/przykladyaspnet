using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models {

    public class MyAsyncMethods {

        public async static Task<long?> GetPageLength() {

            HttpClient client = new HttpClient();

            var httpMessage = await client.GetAsync("http://apress.com");

            // w trakcie oczekiwania na zakończenie działania żądania HTTP  
            // można przeprowadzić inne operacje 
            return httpMessage.Content.Headers.ContentLength;
        }
    }
}
