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

### Clean Code
Clean Code refere-se a práticas que tornam o código mais legível, organizado e compreensível, facilitando a manutenção e evolução do sistema. Alguns dos princípios básicos incluem:
- **Nomes significativos**: Usar nomes que indiquem claramente o propósito de variáveis, métodos e classes.
- **Funções pequenas e de única responsabilidade**: Manter funções curtas e focadas em uma única tarefa, facilitando a leitura e o reuso.
- **Eliminação de duplicação de código**: Evitar duplicação melhora a clareza e facilita correções, já que uma mudança é necessária apenas em um local.
- **Tratamento de erros claro**: Exceções e validações ajudam a evitar comportamentos inesperados e facilitam a identificação de problemas.
- **Comentários explicativos somente quando necessário**: Priorizar um código autoexplicativo e usar comentários apenas para contexto adicional.

No InsightPro, essas práticas ajudam a garantir que o código esteja claro e que qualquer membro da equipe possa entender e modificar o projeto rapidamente.

---

### Princípios SOLID
Os princípios SOLID são um conjunto de boas práticas que promovem a criação de sistemas mais robustos e flexíveis:

1. **S - Single Responsibility Principle (Princípio da Responsabilidade Única)**: Cada classe deve ter apenas uma razão para mudar, ou seja, uma única responsabilidade. No InsightPro, por exemplo, cada camada (Apresentação, Aplicação, Domínio e Infraestrutura) possui uma responsabilidade específica, facilitando modificações sem afetar o restante do sistema.

2. **O - Open/Closed Principle (Princípio Aberto/Fechado)**: O código deve ser aberto para extensão, mas fechado para modificação. Isso é especialmente útil em sistemas de previsão como o InsightPro, onde podemos adicionar novas funcionalidades de Machine Learning sem modificar as já existentes.

3. **L - Liskov Substitution Principle (Princípio da Substituição de Liskov)**: Objetos de uma classe derivada devem poder substituir objetos da classe base sem alterar a funcionalidade do sistema. Este princípio é importante para garantir que as abstrações usadas nos repositórios e serviços da aplicação sejam cumpridas corretamente.

4. **I - Interface Segregation Principle (Princípio da Segregação de Interfaces)**: Interfaces específicas são melhores que uma única interface geral. No projeto InsightPro, o uso de interfaces para repositórios específicos permite maior flexibilidade e independência entre as camadas de aplicação e de domínio.

5. **D - Dependency Inversion Principle (Princípio da Inversão de Dependência)**: Módulos de alto nível não devem depender de módulos de baixo nível, mas ambos devem depender de abstrações. O projeto aplica injeção de dependência para desacoplar a lógica de negócios da camada de infraestrutura.

Esses princípios tornam o InsightPro mais fácil de entender, manter e expandir, especialmente se houver uma mudança futura para uma arquitetura de microsserviços. A modularização em camadas e o uso de Design Patterns como Repository e Dependency Injection complementam o SOLID, ajudando a manter o código limpo e organizado.

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
