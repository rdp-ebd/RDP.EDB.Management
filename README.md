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

## Docker compose
O projeto usa docker compose para rodar o WebApi e um postgresql local.
Note que no appsettings estamos usando o server como "localhost", para que as migrations possam ser executadas via máquina de desenvolvimento.
No momento de execução do dockercompose, sobrescrevemos a connection string para usar o nome do serviço adequado:

```yaml
# docker-compose.yaml

environment:
    - ConnectionStrings__DefaultConnection=Server=rdp_ebd_man_database;Port=5432;Database=ebd;User Id=ebd_user;Password=asd@123
```
