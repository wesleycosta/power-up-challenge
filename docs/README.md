# Power-Up-Challenge

[![CodeFactor](https://www.codefactor.io/repository/github/wesleycosta/power-up-challenge/badge)](https://www.codefactor.io/repository/github/wesleycosta/power-up-challenge)
[![.NET](https://github.com/wesleycosta/power-up-challenge/actions/workflows/dotnet.yml/badge.svg)](https://github.com/wesleycosta/power-up-challenge/actions/workflows/dotnet.yml)
[![codecov](https://codecov.io/gh/wesleycosta/power-up-challenge/graph/badge.svg?token=TETCQEJXDQ)](https://codecov.io/gh/wesleycosta/power-up-challenge)

O Power-Up-Challenge é um microsserviço que gerencia hábitos em um aplicativo, permitindo que os usuários cadastrem e acompanhem o progresso diário e obtenham insights sobre seu desempenho ao longo do tempo de maneira fácil e intuitiva.

## Funcionalidades Principais

1. **Cadastro de Hábitos:**
   - Os usuários podem cadastrar seus hábitos, especificando a frequência semanal e a descrição correspondente.

2. **Registro Diário de Progresso:**
   - Os usuários podem atualizar diariamente se cumpriram ou não seus hábitos. Esses registros são armazenados para análise posterior.

3. **Consulta de Desempenho:**
   - Fornecer endpoints que permitam aos usuários consultar seu histórico de desempenho, incluindo a visualização de hábitos alcançados e não alcançados.

## Arquitetura

O Power-Up-Challenge é projetado como um microsserviço independente para garantir escalabilidade e manutenibilidade. Ele se comunica com o microsserviço Power-Up-Accounts para autenticação e autorização de usuários.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
