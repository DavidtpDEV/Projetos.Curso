using System;
using RestSharp;

namespace PrevisaoTempoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chave de API da OpenWeatherMap 
            string apiKey = "dae4ee63475292b39a010ac228115d61\r\n";

            
            string cidade = "São Paulo";

            
            var client = new RestClient("http://api.openweathermap.org/data/2.5");
            var request = new RestRequest($"weather?q={cidade}&appid={apiKey}&units=metric", Method.GET);

            
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                
                Console.WriteLine("Previsão do Tempo para " + cidade);
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(response.Content);
            }
            else
            {
                Console.WriteLine("Erro ao obter a previsão do tempo: " + response.ErrorMessage);
            }

            Console.ReadLine();
        }
    }
}
