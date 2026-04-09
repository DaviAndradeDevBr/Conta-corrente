/*
    Abstração da Conta Corrente
    
    (Descrição/Atributos) [x]
    Uma conta corrente é composta por diversos atributos essenciais para sua operação. 
    Ela possui um número de identificação único, um saldo disponível e um limite de débito estabelecido. 

    (Ações/Métodos) [x]
    Saque: Permite a retirada de valores, respeitando o limite máximo permitido.
    Depósito: Possibilita a adição de fundos à conta.
    Consulta de saldo: Fornece informações atualizadas sobre o montante disponível.
    Transferência entre contas: Permite a movimentação de valores entre contas correntes distintas.
*/
using System.Security.Cryptography;

class ContaCorrente
{
    public int numeroIdentificacao;
    public string titular;
    public decimal saldo;
    public decimal limiteDebito;

    public void Sacar()
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja sacar (R$): ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        if (saldo <= -limiteDebito)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("O valor do limite de débito foi ultrapassado!");
            Console.ReadLine();
                    
        }
        else
        {
            saldo -= valorSaque;
                    
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("O valor foi sacado com sucesso!");
            Console.WriteLine("-------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        
                
    }
    
    public void Depositar()
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja depositar (R$): ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        saldo += valorDeposito;

        
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor foi sacado com sucesso!");
        Console.WriteLine("-------------------------------------");
        Console.Write("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
    
    public void TransferirPara(ContaCorrente contaDestino)
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja transferir (R$): ");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        saldo -= valorTransferencia;
        contaDestino.saldo += valorTransferencia;

        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"O valor de R${valorTransferencia} foi transferido com sucesso!");
        Console.WriteLine("-------------------------------------");
        Console.Write("Pressione ENTER para continuar...");
        Console.ReadLine();

    }
    
    public void ObterSaldo()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor do saldo da conta é de (R$): " + saldo);
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }
}

class Progam
{
    static void Main(string[] args)
    {
        // Conta Corrente 1
        ContaCorrente contaUm = new ContaCorrente();
        contaUm.numeroIdentificacao = 1;
        contaUm.titular = "Tiago";
        contaUm.saldo = 400;
        contaUm.limiteDebito = 1200;
        

        // Conta Corrente 2
        ContaCorrente contaDois = new ContaCorrente();
        contaDois.numeroIdentificacao = 2;
        contaDois.titular = "Rech";
        contaDois.saldo = 12000;
        contaDois.limiteDebito = 1200;
        

        while(true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Conta Corrente #{contaUm.numeroIdentificacao} de {contaUm.titular}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Depósito");
            Console.WriteLine("3 - Transferência");
            Console.WriteLine("4 - Consulta de Saldo");
            Console.WriteLine("S - Sair");
            Console.WriteLine("-------------------------------------");
            Console.Write("Digite uma opção válida: ");
            string? opcaoMenu = Console.ReadLine()?.ToUpper();

            if (opcaoMenu == "S")
                break;

            if (opcaoMenu == "1")
            {
                contaUm.Sacar();
            }
            else if (opcaoMenu == "2")
            {
                contaUm.Depositar();
            }
            else if (opcaoMenu == "3")
            {
                contaUm.TransferirPara(contaDois);
            }
            else if (opcaoMenu == "4")
            {
                contaUm.ObterSaldo();
            }
        }

    }
}

