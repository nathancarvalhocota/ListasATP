// See https://aka.ms/new-console-template for more information
namespace Lista5ATP
{
    class Program
    {
        static void Main(string[] args)
        {
            Questao1 Questao1 = new Questao1();
            Questao2 Questao2 = new Questao2();
;           Questao3 Questao3 = new Questao3();
            Questao4 Questao4 = new Questao4();
            Questao5 Questao5 = new Questao5(); 

            Console.WriteLine("Digite a questão: ");
            int questao = int.Parse(Console.ReadLine());
            switch (questao)
            {
                case 1:
                    Questao1.Resposta1();
                    break;

                case 2:
                    Questao2.Resposta2();
                    break;

                case 3:
                    Questao3.Resposta3(); 
                    break;

                case 4: 
                    Questao4.Resposta4(); 
                    break;

                case 5:
                    Questao5.Resposta5();
                    break;
            }
        }
    }
}


