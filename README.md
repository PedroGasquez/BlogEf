# API de Gerenciamento de Blog

Este projeto consiste em uma API para gerenciar um blog, incluindo categorias, contas de usuário e outras funcionalidades.

## Funcionalidades

- Gerenciamento de categorias
- Registro e autenticação de usuários
- Implementação de controle de acesso com chave de API
- Geração de tokens de autenticação

## Endpoints

## Abra a api nessa http http://localhost:5118/swagger/
- Para ter a documentacao completa pelo swagger

Os endpoints são detalhados nos respectivos controladores.

## Classes

### `CategoryController`

Este controlador é responsável por lidar com as operações relacionadas às categorias do blog.

### `AccountController`

Este controlador é responsável por lidar com as operações relacionadas às contas de usuário, como registro e autenticação.

### `ApiKeyAttribute`

Este atributo é aplicado a classes e métodos de controladores para implementar o controle de acesso com chave de API.

### `BlogDataContext`

Este contexto de dados utiliza o Entity Framework Core para se conectar ao banco de dados e fornece acesso às entidades `Category`, `Post` e `User`.

### `TokenService`

Este serviço é responsável por gerar tokens de autenticação JWT (JSON Web Tokens) para os usuários.

## Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- JWT (JSON Web Tokens)

## Como Executar

1. Clone este repositório.
2. Abra o projeto em sua IDE preferida.
3. Execute o projeto.
4. Use uma ferramenta como Postman ou cURL para interagir com a API.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir problemas ou enviar pull requests.

## Licença

