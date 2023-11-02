public class Questao2
{
    public static void Resposta2()
    {
        
        void Preenche(ref double[] vetor) // Procedimento com REF para alterar o valor do vetor no procedimento RECEBE
        {
            Random r = new Random();
            Console.Write("As notas de cada aluno foram: ");
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = r.Next(0, 11); // Define as notas aleatoriamente de 0 a 10
                Console.Write(vetor[i] + " "); // Escreve cada nota gerada
            }
        }

        void Recebe()
        {
            double[] vetor = new double[10];

            Preenche(ref vetor); // Chama o procedimento para preencher o vetor e passa o valor para a variável vetor local

            double soma = 0;
            for (int i = 0;i < 10;i++)
                soma += vetor[i]; // Soma o valor de cada índice 

            double media = soma / 10;
            int acima = 0;

            for ( int i = 0; i < 10;i++) 
                if (vetor[i] > media) // Compara cada valor do vetor que é maior que a média
                    acima++;

            Console.WriteLine("\nA média da turma é {0} e {1} alunos estiveram acima da média.",media, acima);
        }
        Recebe(); // Chama o procedimento que recebe e exibe os resultados
    }
}
