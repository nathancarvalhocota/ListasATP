public class Questao1
{
    public static void Resposta1()
    {
        int[] vetor = new int[20];
        Random r = new Random();
        for (int i = 0; i < 20; i++)
        {
            vetor[i] = r.Next(1,101); // Define 20 números aleatórios de 1 a 100
            Console.WriteLine("[{0}] = {1}", i, vetor[i]); // Escreve cada número gerado e seu respectivo índice
        }

        int menor = vetor[0];

        for (int i = 1; i < 20; i++)
        {
            if (vetor[i] < menor)
                menor = vetor[i];
        }

        Console.WriteLine("O menor número é: " + menor);
    }
}
