# Teste Técnico Desenvolvimento FullStack .Net

O objetivo principal é criar uma aplicação contendo o CRUD completo da
tabela Airplane:
Campos:
· Código do Avião
· Modelo
· Quantidade de passageiros
· Data de criação do registro
Tecnologias e patterns obrigatórios:
· FRONT-END – Angular 6
· BACK-END - .Net Core / Entity Framework Core / RESTful Api
· PATTERNS – DDD e Injeção de Dependência
*Você pode utilizar frameworks de mercado para os patterns.
O código fonte deverá ser armazenado em um repositório público do
github, e enviar o link para análise.

## Inicialização (.Net Core 2.2)

 1. Dentro do repositório ``AirplaneCrud/ClientApp``, rode o seguinte comando:
```
npm install
```
 2. Em seguida, na pasta ``AirplaneCrud``, inicie o projeto na porta 5200, através do comando:
 ```
 dotnet run --project AirplaneCrud
 ```
 3. Por último, inicie a API na porta 5100 utilizando o comando abaixo:
 ```
 dotnet run --project AirplaneCrud.API
 ```

## Observações

* Banco de dados ``sqlite`` é gerado e atualizado ao iniciar a API;
* Para a documentação da API, [clique aqui](https://localhost:5100/swagger) ao ter feito o processo de inicialização mencionado anteriormente.
