using System;

namespace Lista21082017ex08
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int quantidade;
            decimal valorTotal;

            Console.WriteLine("Digite a quantidade de maçãs compradas: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            if(quantidade < 12){
                valorTotal = quantidade * (decimal)1.3;
            } else {
                valorTotal = quantidade;
            }

            Console.WriteLine("O valor total é: R$ {0:###,##0.00}", valorTotal);

        }
    }
}
