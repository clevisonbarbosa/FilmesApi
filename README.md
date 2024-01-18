# FilmesAPI

Projeto ASP.NET Core para gerenciamento de filmes.

## Configuração do Banco de Dados
    Abra o arquivo appsettings.json.
    No bloco ConnectionStrings, configure a string de conexão para o seu banco de dados MySQL.

"ConnectionStrings": {
    "FilmeConnection": "server=127.0.0.1;database=suaBanco;user=seuUsuario;password=suaSenha;"
}

## Instalação e Execução
    Certifique-se de ter o SDK do .NET Core instalado. Em seguida, siga as etapas abaixo:
    Abra o terminal na pasta do projeto.
    Execute os seguintes comandos:
        dotnet restore
        dotnet run
        
## O aplicativo estará disponível em http://localhost:7068 (ou http://localhost:5239).

## Endpoints da API
    POST /Filme
        Adiciona um novo filme ao banco de dados.
    GET /Filme
        Recupera a lista de filmes.
    GET /Filme/{id}
        Recupera um filme específico por ID.
    PUT /Filme/{id}
        Atualiza as informações de um filme existente.
    PATCH /Filme/{id}
        Atualiza parcialmente as informações de um filme existente.
    DELETE /Filme/{id}
        Deleta um filme do banco de dados.
