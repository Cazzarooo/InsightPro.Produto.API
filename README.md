# Integrantes
Rm 98660 - Leonardo Valentim de Souza

RM 97714 - João Victor Leite Firmino

Rm 99618 - Gustavo dos Santos Correa

RM 551201 - Lucas Cazzaro

RM 99219 - Ronaldo Riyudi Noda

# InsightPro

## Descrição Geral do Projeto

O projeto **InsightPro** foi desenvolvido como uma aplicação para o gerenciamento de produtos e avaliações, fornecendo uma API robusta para operações CRUD (Create, Read, Update e Delete) e consultas sobre produtos e suas respectivas avaliações. A aplicação é implementada com uma arquitetura limpa e baseada em camadas, promovendo separação de responsabilidades, reutilização de código, facilidade de manutenção e escalabilidade.

Além das funcionalidades de gerenciamento de produtos e avaliações, o projeto também inclui a implementação de testes automatizados utilizando **xUnit**, uma framework poderosa e flexível para criar testes unitários e de integração no ecossistema .NET. A camada de testes foi desenhada para assegurar a confiabilidade da aplicação e permitir a verificação contínua das operações de CRUD, validações de dados, e consistência das regras de negócio. Todos os testes estão centralizados na classe `ProdutoApplicationServiceTests`.

Outro destaque do InsightPro é a incorporação de **ML.NET**, que traz funcionalidades de aprendizado de máquina (Machine Learning) para o sistema, possibilitando a análise avançada de dados e a criação de previsões. Com essa integração, a aplicação pode oferecer insights adicionais sobre padrões e tendências das avaliações, fornecendo uma visão mais estratégica para a tomada de decisões.

### Módulos Principais

- **Produto**: Gerenciamento completo do ciclo de vida dos produtos.
- **Avaliação**: Gerenciamento das avaliações relacionadas aos produtos, incluindo suas notas e comentários.

---

## Arquitetura do Sistema

O sistema foi projetado utilizando a arquitetura de camadas, onde cada camada tem uma função bem definida, proporcionando maior clareza e flexibilidade no desenvolvimento e manutenção do código.

### Estrutura de Camadas

- **Presentation Layer (Camada de Apresentação)**: Lida com a comunicação entre o cliente e a aplicação, utilizando o framework ASP.NET Core para gerenciar os endpoints da API.
- **Application Layer (Camada de Aplicação)**: Contém a lógica de negócios de alto nível, coordenando operações entre a camada de domínio e a camada de apresentação.
- **Domain Layer (Camada de Domínio)**: Define as entidades de domínio e as regras de negócios centrais.
- **Infrastructure Layer (Camada de Infraestrutura)**: Lida com tecnologias externas como acesso ao banco de dados.
- **Test Layer (Camada de Testes)**: Inclui testes unitários e de integração utilizando **xUnit** para garantir o comportamento correto da aplicação.

---

## Motivos para Escolher Microsserviços em vez de Arquitetura Monolítica

Embora o projeto InsightPro seja modularizado em camadas, futuros desenvolvimentos podem adotar a arquitetura de microsserviços por várias razões:

- **Escalabilidade**
- **Flexibilidade Tecnológica**
- **Desenvolvimento e Desdobramento Independente**
- **Tolerância a Falhas**
- **Facilidade de Manutenção e Atualização**
- **Deploy Contínuo**

---

## Tecnologias Utilizadas

- **ASP.NET Core**
- **Entity Framework Core**
- **Oracle**
- **Dependency Injection**
- **xUnit** para testes automatizados
- **ML.NET** para análise de dados e previsões

### Design Patterns Utilizados

- **Repository Pattern**
- **Dependency Injection**

---

## Instalação e Execução da API

### Pré-requisitos

Certifique-se de ter as seguintes ferramentas instaladas:

- .NET 6 SDK
- Visual Studio 2022 ou VS Code
- Oracle

### Passo a Passo para Executar

1. Clone o repositório:
    ```bash
    git clone https://github.com/Cazzarooo/InsightPro.Produto.API.git
    ```

2. Acesse o diretório da API:
    ```bash
    cd InsightPro.Produto.API
    ```

3. Configure a string de conexão no arquivo `appsettings.json`:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=SEU_SERVIDOR;Database=InsightProDB;User Id=seu_usuario;Password=sua_senha;"
    }
    ```

4. Restaure as dependências:
    ```bash
    dotnet restore
    ```

5. Compile o projeto:
    ```bash
    dotnet build
    ```

6. Execute a API:
    ```bash
    dotnet run
    ```

7. Teste a API localmente em `http://localhost:5000`.

---

## Endpoints Disponíveis

### Produtos

- `GET /api/produtos`: Retorna todos os produtos cadastrados.
- `GET /api/produtos/{id}`: Retorna um produto específico pelo ID.
- `POST /api/produtos`: Cria um novo produto.
- `PUT /api/produtos/{id}`: Atualiza um produto existente.
- `DELETE /api/produtos/{id}`: Remove um produto.

## Estrutura do Projeto

```bash
InsightPro.API/
│
├── 0 - Presentation/
│   ├── Controllers/    # Controladores da API
│
├── 1 - Application/
│   ├── Services/       # Serviços de aplicação e lógica de negócios
│   ├── DTOs/           # Data Transfer Objects
│
├── 2 - Domain/
│   ├── Entities/       # Entidades de domínio
│   ├── Repositories/   # Interfaces de repositórios
│
├── 3 - Infrastructure/
│   ├── Data/           # Repositórios e contexto do banco de dados
│
└── tests/              # Testes unitários e de integração com xUnit
```

![Modelagem do Projeto](https://github.com/user-attachments/assets/e754ba3a-3c76-4f6b-83f7-df8509a7bfd8)

---
