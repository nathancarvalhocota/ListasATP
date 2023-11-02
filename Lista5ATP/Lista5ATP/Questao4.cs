public class Questao4
{
    public static void Resposta4()
    {

        void Preenche(int[] vetor1, int[] vetor2) 
        {
            Random r = new Random();
            Console.WriteLine("- - - - - NÚMEROS DE CADA VETOR - - - - -"); // Números sorteados de 10 a 50
            Console.WriteLine("\nVETOR 1: ");
            for (int i = 0; i < 10; i++)
            {
                vetor1[i] = r.Next(10, 51);
                Console.Write(vetor1[i] + " "); // Sorteia e escreve os números do vetor 1
            }

            Console.WriteLine("\n\nVETOR 2: ");
            for (int i = 0; i < 10; i++)
            {
                vetor2[i] = r.Next(10, 51);
                Console.Write(vetor2[i] + " "); // Sorteia e escreve os números do vetor 1
            }
        }

        void Recebe(int[] vetor1, int[] vetor2, int[] vetor3) // Inclui os valores para serem recebidos por parâmetro conforme pede a questão
        {                                                                 
           Preenche(vetor1, vetor2); // Passa o valor gerado no procedimento PREENCHE para as variáveis do procedimento local
           int j = 0, k = 0; // Variáveis para usar como índice ao incluir os números em cada casa
           for (int i = 0; i < 20; i++)
           {
                if (i % 2 != 0) 
                { 
                    vetor3[i] = vetor1[j];
                    j++;
                }

                else if (i % 2 == 0)
                {
                    vetor3[i] = vetor2[k];
                    k++;
                }          
           }                   
        }

        void Exibe()
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10]; // Passa as 3 variáveis como paramêtro para os outros procedimentos
            int[] vetor3 = new int[20];
            Recebe(vetor1, vetor2, vetor3);
            Console.WriteLine("\n\nVETOR 3: ");
            Console.WriteLine("00 01 02 03 04 05 06 07 08 09 10 11 12 13 14 15 16 17 18 19"); // Para demonstrar os índices do novo vetor
            foreach (int item in vetor3)
                Console.Write(item + " ");
        }

        Exibe();
    }



}
