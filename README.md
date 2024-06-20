# Sobre o projeto

O projeto é uma API que realiza um CRUD simples de usuários.

**Tecnologias utilizadas:**
* C#
* ASP.NET 8

## Clonando o Repositório

**Comece clonando o repositório do projeto no seu diretório local**

## Configurando o Ambiente

**Configure as credenciais do banco de dados no arquivo appsettings.json**
**OBS: Precisa ser SQLSERVER**
```bash
  "ConnectionStrings": {
    "Database": "Server=SeuServidor;Database=BancoDeDados;User Id=Usuario;Password=Senha;TrustServerCertificate=True"
  }
```

**Após a conexão do banco de dados, rodar as migrations no console:**
```bash
  Add-Migration InitialDB -Context SistemaDBContex
```
```bash
  Update-Database -Context SistemaDBContex
```

## E PRONTO! AGORA É SÓ RODAR O PROJETO!

---
## Considerações Finais

Essa é apenas uma estrutura básica, Obrigada pelo apoio!
