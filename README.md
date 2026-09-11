# Console-ViaCep

Projeto desenvolvido em C# para consulta de endereços utilizando a API pública ViaCEP.

## Sobre o projeto

O programa permite que o usuário informe um CEP pelo console e, através de uma requisição à API ViaCEP, obtenha os dados correspondentes ao endereço.

## Funcionalidades

* Consulta de CEP pelo console
* Consumo de API REST
* Exibição dos dados do endereço
* Tratamento de CEP inválido

## API utilizada

O projeto utiliza a API pública do [ViaCEP](https://viacep.com.br/) para realizar as consultas.

Endpoint utilizado:

```text
https://viacep.com.br/ws/{CEP}/json/
```

## Tecnologias

* C#
* .NET
* API REST
* ViaCEP

## Como executar

1. Clone o repositório.
2. Abra o projeto no Visual Studio ou VS Code.
3. Execute o projeto.
4. Digite o CEP solicitado no console.
5. Os dados do endereço serão exibidos.

## Exemplo

```text
Digite o CEP: 35400-000

CEP: 35400-000
Logradouro: ...
Bairro: ...
Cidade: ...
UF: ...
```

## Autor

Kaio Eduardo de Oliveira Barbosa
