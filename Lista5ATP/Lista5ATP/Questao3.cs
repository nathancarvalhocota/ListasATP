public class Questao3
{
    public static void Resposta3()
    {
        void Preenche(int[] vetor)
        {
            Console.WriteLine("Digite os 10 valores do vetor: "); 
            for (int i = 0; i < 10; i++)             
                vetor[i] = int.Parse(Console.ReadLine()); // Recebe os valores para cada int do vetor
        }

        int[] Recebe()
        {
            int[] vetor = new int[10];

            Preenche(vetor);

            int negativos = 0;

            for (int i = 0; i < 10; i++)
                if (vetor[i] < 0)
                    negativos++; // Usa a variável para definir a quantidade de índices terá o novo vetor, apenas com os números negativos

            int[] negativo = new int[negativos]; // Define o novo vetor com o índice de números negativos
            int j = 0;

            for (int i = 0; i < 10; i++) // Passa por cada índice do vetor principal 
            {            
                if (vetor[i] < 0) // Verifica se o número é menor que 0
                {
                    negativo[j] = vetor[i]; // Recebe o valor no primeiro índice do vetor negativo (0)
                    j++; // Acrescenta mais um ao representante do índice para que na próxima repetição passe a representar a casa seguinte
                }
            }
            return negativo;
        }

        void Exibe()
        {
            int[] vetor_negativo = Recebe(); // Recebe o valor da função na variável
            Console.WriteLine("Os números negativos são: ");
            for (int i = 0;i < vetor_negativo.Length;i++)
                Console.WriteLine(vetor_negativo[i]);
        } 

        Exibe(); 
    }



}
