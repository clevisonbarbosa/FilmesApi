# FilmesAPI

Projeto ASP.NET Core para gerenciamento de filmes.

## Configuração do Banco de Dados

1. Abra o arquivo `appsettings.json`.
2. No bloco `ConnectionStrings`, configure a string de conexão para o seu banco de dados MySQL.

```json
"ConnectionStrings": {
    "FilmeConnection": "server=127.0.0.1;database=suaBanco;user=seuUsuario;password=suaSenha;"
}
