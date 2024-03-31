[![Continuos Integration](https://github.com/rdp-ebd/RDP.EDB.Management/actions/workflows/continuous-integration.yml/badge.svg)](https://github.com/rdp-ebd/RDP.EDB.Management/actions/workflows/continuous-integration.yml)

SonarCloud: https://sonarcloud.io/project/overview?id=rdp-ebd_RDP.EDB.Management

# RDP.EDB.Management
Microserviço de gerenciamento

## Bases importantes
https://www.milanjovanovic.tech/blog/cqrs-validation-with-mediatr-pipeline-and-fluentvalidation
https://www.milanjovanovic.tech/blog/global-error-handling-in-aspnetcore-8

## Como criar Migrations?
O projeto que contêm a construção do DbContext é o WebApi, entretanto, o projeto responsável por manter dados de migração é o Infra.
Ao fazer uma modificação no modelo do EF, será necessário criar uma migration.
Abra um console na pasta base do RDP.EDB.Management.WebApi e rode o seguinte comando:

```
dotnet ef migrations add [nome_da_migration] --project ../RDP.EDB.Management.Infra
```

Atualizar banco:

```
dotnet ef database update
```

Remover migration a última migration:

```
dotnet ef migrations remove --project ../RDP.EDB.Management.Infra
```

## Docker compose
O projeto usa docker compose para rodar o WebApi e um postgresql local.
Note que no appsettings estamos usando o server como "localhost", para que as migrations possam ser executadas via máquina de desenvolvimento.
No momento de execução do dockercompose, sobrescrevemos a connection string para usar o nome do serviço adequado.

## Secrets e env files
Apesar de até agora só termos configuração de banco local, não estamos versionando dados de acesso. 
Para adicionar a connectionString correta no projeto "RDP.EDB.Management.WebApi", sobrescreva com os secrets do visual studio (botão direito no projeto, manage user secrets).
Defina a connection string com seus dados. Exemplo:

```
{
  # ...
  "ConnectionStrings:DefaultConnection": "Server=localhost;Port=5432;Database=ebd;User Id=ebd_user;Password=asd@123;"
  # ...
}
```

ENV FILES: O docker-compose.yaml carrega variáveis de ambiente via env_file:

```yaml
  # ...
  rdp_ebd_man_webapi:
    # ... 
    env_file:
      - env/.env-webapp
    # ...
  
  rdp_ebd_man_database:
    # ...
    env_file:
      - env/.env-postgresql
    # ...

```

Crie uma pasta env na raiz do projeto e adicione os dois arquivos (.env-webapp e .env-postgresql) para que o projeto possa ser executado via docker-compose.
Exemplo de arquivos:

```
# .env-webapp
# rdp_ebd_man_database é o nome do servico do nosso banco de dados
ConnectionStrings__DefaultConnection=Server=rdp_ebd_man_database;Port=5432;Database=ebd;User Id=ebd_user;Password=asd@123
```

```
# .env-postgresql
# coloque os segredos do postgresql aqui!
POSTGRES_PASSWORD=asd@123
POSTGRES_USER=ebd_user
POSTGRES_DB=ebd
```

**IMPORTANTE**: Senha e usuário devem ser os mesmos no arquivo de secrets, .env-webapp e .env-postgresql
