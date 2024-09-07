using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TesteJason.cep
{
    class BuscaCep
    {
        private class CepResposta 
        {
            public string Cep { get; set; } 
            public string Logradouro { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string UF { get; set; }
        }
        public async Task CEP(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            string respostascep;
            HttpClient cliente = new HttpClient();
            HttpResponseMessage resposta = await cliente.GetAsync(url);
            resposta.EnsureSuccessStatusCode();
            respostascep = await resposta.Content.ReadAsStringAsync();

            CepResposta cepInfo = JsonConvert.DeserializeObject<CepResposta>(respostascep);

            Console.WriteLine($"CEP: {cepInfo.Cep}");
            Console.WriteLine($"Logradouro: {cepInfo.Logradouro}");
            Console.WriteLine($"Bairro: {cepInfo.Bairro}");
            Console.WriteLine($"Cidade: {cepInfo.Localidade }");
            Console.WriteLine($"Estado: {cepInfo.UF}");

        }
    }
}
