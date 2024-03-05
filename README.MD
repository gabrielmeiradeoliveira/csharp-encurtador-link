# Encurtador de Links

Este é um simples encurtador de links desenvolvido em ASP.NET Core, que permite aos usuários encurtarem URLs longas e compartilhá-las de forma mais conveniente.

## Funcionalidades

- **Encurtamento de Links**: Os usuários podem enviar URLs longas para serem encurtadas.
- **Redirecionamento**: Os links encurtados redirecionam os usuários para as URLs originais.

## Estrutura do Projeto

A aplicação consiste nos seguintes componentes principais:

- **Controllers**: Contêm as lógicas para receber solicitações HTTP e retornar respostas adequadas.
- **Services**: Lida com a lógica de negócios, como encurtamento de links.
- **Models**: Define as entidades de dados usadas pela aplicação.
- **ViewModels**: Modelos de visualização para transferência de dados entre a camada de controle e a camada de serviço.
- **DbContext**: Contexto do banco de dados para interação com o banco de dados.

## Executando a Aplicação

Para executar a aplicação localmente, você precisará do Docker e Docker Compose instalados.

1. Clone este repositório:

    ```bash
    git clone https://github.com/seu-usuario/encurtador-de-links.git
    ```

2. Navegue até o diretório do projeto:

    ```bash
    cd encurtador-de-links
    ```

3. Inicie a aplicação usando Docker Compose:

    ```bash
    docker-compose up --build
    ```


## Tecnologias Utilizadas

- **ASP.NET Core**: Framework web utilizado para construir a aplicação.
- **Entity Framework Core**: ORM utilizado para interagir com o banco de dados.
- **PostgreSQL**: Banco de dados utilizado para armazenar os links encurtados.
- **Docker**: Utilizado para empacotar e executar a aplicação em contêineres.
- **Docker Compose**: Utilizado para definir e executar aplicativos Docker de vários contêineres.

## Contribuindo

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue para reportar problemas ou enviar um pull request com melhorias.
