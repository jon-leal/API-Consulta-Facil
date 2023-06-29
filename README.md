
# API-Consulta-Facil

API de Agendamento de Consultas.

Essa é uma API simples de Agendamento de Consultas, desenvolvida em ASP.NET. A API permite criar, visualizar, atualizar e excluir consultas médicas.













## Tecnologias Utilizadas

Tecnologias Utilizadas
ASP.NET Core 6.0
Entity Framework Core
MySQL
Configuração do Ambiente de Desenvolvimento
Certifique-se de ter o .NET SDK instalado em sua máquina.
Instale um servidor MySQL, como o MySQL Community Server.
Clone este repositório em seu ambiente de desenvolvimento.
## Configuração do Banco de Dados
No arquivo appsettings.json, atualize a string de conexão "DefaultConnection" com as informações do seu banco de dados MySQL.
Certifique-se de que o banco de dados com o nome especificado na string de conexão esteja criado.
Executando a Aplicação
Abra o terminal e navegue até a pasta raiz do projeto.
Execute o comando dotnet run para iniciar a aplicação.
A API estará disponível no endereço http://localhost:5000 (ou https://localhost:5001 se estiver usando HTTPS).
## Endpoints
A API possui os seguintes endpoints:

GET /api/appointment: Retorna a lista de todas as consultas.
GET /api/appointment/{id}: Retorna os detalhes de uma consulta específica pelo ID.
POST /api/appointment: Cria uma nova consulta.
PUT /api/appointment/{id}: Atualiza uma consulta existente pelo ID.
DELETE /api/appointment/{id}: Exclui uma consulta pelo ID.
Consulte a documentação da API, disponível no Swagger, para obter mais detalhes sobre os endpoints, os modelos de dados esperados e os exemplos de solicitação e resposta.
## Contribuindo
Contribuições são bem-vindas! Se você encontrar algum problema, tiver uma ideia de melhoria ou desejar adicionar novos recursos à API, sinta-se à vontade para abrir uma issue ou enviar um pull request.
