using System;

class CalculadoraCusto
{
    static void Main(string[] args)
    {
        double valor;
        double custo;
        int resposta;
        int parcelas;
        double parcelamento;

        while (true)
        {
            Console.Write("Quanto você deseja pegar emprestado? ");
            valor = Convert.ToDouble(Console.ReadLine());

            custo = valor * 1.5;
            Console.WriteLine("Você terá que pagar " + custo);

            Console.WriteLine("Deseja parcelar a sua dívida?");
            Console.WriteLine("1. Sim");
            Console.WriteLine("2. Não");
            resposta = Convert.ToInt32(Console.ReadLine());

            // Verificar se a resposta é inválida
            if (resposta < 1 || resposta > 2)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
            else
            {
                if (resposta == 1)
                {
                    Console.Write("Deseja parcelar em quantas vezes? ");
                    parcelas = Convert.ToInt32(Console.ReadLine());

                    // Verificar se o número de parcelas é válido
                    if (parcelas <= 0)
                    {
                        Console.WriteLine("Número de parcelas inválido.");
                    }
                    else
                    {
                        parcelamento = custo / parcelas;
                        Console.WriteLine("O valor de cada parcela é: " + parcelamento);
                    }
                }
                else
                {
                    Console.WriteLine("Você terá que pagar " + custo + " em uma única parcela.");
                }
                // Saindo do loop após uma operação válida
                break;
            }
        }
    }
}