using static System.Console;

WriteLine("Digite o CEP que deseja consultar: ");
var  cep = ReadLine();

var enderecoUrl = $"https://viacep.com.br/ws/{cep}/json/";

WriteLine($"Realizando  requisição para o endpoint: {enderecoUrl}");

var client = new HttpClient();

try
{
    HttpResponseMessage response = await client.GetAsync(enderecoUrl);
    response.EnsureSuccessStatusCode();

    string respostaAPI = await response.Content.ReadAsStringAsync();
    WriteLine($"Resposta da API: {respostaAPI}");

}
catch (Exception ex)
{
    WriteLine($"Ocorreu um erro ao realizar a requisição: {ex.Message}");
}
try
{
    HttpResponseMessage? response = await client.GetAsync(enderecoUrl);
    response.EnsureSuccessStatusCode();


    //Verificar se a requisão aconteceu com sucesso
    WriteLine("API funcionou: "+ response.IsSuccessStatusCode);
    WriteLine("Status Code: "+ response.StatusCode);

}

catch (System.Exception ex)
{
    WriteLine($"Aconteceu um erro ao consultar a api: {ex.Message}");
}