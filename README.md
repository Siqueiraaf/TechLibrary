# TechLibrary 📚

## Descrição

O **TechLibrary** é um projeto desenvolvido em **C#** e **.NET**, com foco na gestão de usuários e segurança da aplicação. Ele implementa funcionalidades essenciais como autenticação 🔐, criptografia de senhas 🔑, manipulação de banco de dados 🗄️ e tratamento de exceções personalizadas ⚠️.

### Tecnologias Utilizadas 🚀

- **C#** e **.NET**
- **Banco de Dados** (SQL Server, PostgreSQL, MySQL, etc.) 🗃️
- **BCrypt** para criptografia de senhas 🔒
- **JWT (JSON Web Token)** para autenticação 🔑
- **Entity Framework Core** para integração com o banco de dados ⚙️
- **Tratamento de Exceções Personalizadas** ⚠️

### Paginação e Filtros 🔍

#### Funcionalidades 🛠️

- **Criação de Usuários**: Cadastro seguro de novos usuários 👤.
- **Autenticação de Usuários**: Implementação de login seguro 🔑.
- **Criptografia de Senhas**: Proteção de senhas usando **BCrypt** 🔒.
- **Integração com Banco de Dados**: Uso de **Entity Framework Core** para gerenciar os dados 🗄️.
- **Geração e Validação de Tokens JWT**: Permite o acesso autenticado a recursos protegidos 🛡️.
- **Tratamento de Exceções**: Implementação de exceções personalizadas para um melhor controle de erros ⚠️.
- **Paginação e Filtros**: Para otimizar buscas e consultas no sistema 🔍.

### Endpoints Principais 🔗

📚 **Books**

    GET /Books/Filter - Filtragem de livros.

📦 **Checkouts**

    POST /Checkouts/{bookId} - Realização de checkout de um livro.

🔑 **Login**

    POST /Login - Autenticação de usuários.

👤 **Users**

    POST /Users - Cadastro de novos usuários.

