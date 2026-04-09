# 💳 Conta Corrente

## Introdução

Sistema de gestão bancária desenvolvido para processar transações financeiras essenciais, como saques, depósitos e transferências, com controle rigoroso de saldo e limites de crédito.

## Sobre o Projeto 

Este projeto foi desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net),
O foco principal é a simulação de operações bancárias reais aplicando conceitos de **Lógica de Programação** e **Gestão de Estado** em C#.

### Funcionalidades ⚙️ 

O sistema garante que cada operação financeira seja registrada e validada conforme as seguintes regras:

* **💰 Gestão de Saldo e Limite:** Controle de saldo disponível integrado a um limite de débito adicional estabelecido.
* **🏧 Operações Financeiras:**
    * **Depósito:** Adição de fundos à conta com atualização imediata do saldo.
    * **Saque:** Retirada de valores permitida apenas se o valor solicitado for menor ou igual à soma do saldo disponível com o limite adicional.
    * **Transferência:** Permite a movimentação de valores entre contas correntes distintas.
* **📜 Histórico de Movimentações:** Cada transação é classificada como **Crédito** (entrada) ou **Débito** (saída).
* **📊 Emissão de Extrato:** Listagem detalhada de todas as movimentações realizadas em um período específico.

| Operação | Descrição Técnica |
| :---: | :--- |
| **Saque** | Valida se `Valor <= (Saldo + Limite)` antes de processar. |
| **Depósito** | Incrementa o saldo principal da conta. |
| **Transferência** | Realiza o débito na conta de origem e o crédito na conta de destino. |
| **Extrato** | Exibe o registro histórico de todas as transações financeiras. |



## Instruções de Uso 💻

1.  Obtenha o código via clone de repositório ou download do arquivo `.zip`.
2.  Acesse o diretório raiz através do terminal.

3.  **Utilize o comando abaixo para restaurar as dependências:**
    ```bash
    dotnet restore
    ```

4.  **Inicie a aplicação:**
    ```bash
    dotnet run --project ContaCorrente.ConsoleApp
    ```

## Requisitos de Sistema

.NET SDK 10.0 ou superior.