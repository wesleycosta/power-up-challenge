# Power-Up-Challenge

[![CodeFactor](https://www.codefactor.io/repository/github/wesleycosta/power-up-challenge/badge)](https://www.codefactor.io/repository/github/wesleycosta/power-up-challenge)

O Power-Up-Challenge é um microsserviço destinado ao gerenciamento de metas para os usuários de um aplicativo. 
Ele permite que os usuários cadastrem suas metas, registrem seu progresso diário e obtenham insights sobre seu desempenho ao longo do tempo.

## Funcionalidades Principais

1. **Cadastro de Metas:**
   - Os usuários podem cadastrar suas metas, especificando a frequência semanal e a descrição da meta.

2. **Registro Diário de Progresso:**
   - Os usuários podem atualizar diariamente se atingiram ou não suas metas. Esses registros são armazenados para análise posterior.

3. **Consulta de Desempenho:**
   - Fornecer endpoints que permitam aos usuários consultar seu histórico de desempenho, incluindo a visualização de metas alcançadas e não alcançadas.

## Arquitetura

O Power-Up-Challenge é projetado como um microsserviço independente para garantir escalabilidade e manutenibilidade. Ele se comunica com o microsserviço Power-Up-Accounts para autenticação e autorização de usuários.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
