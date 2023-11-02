public class Questao5
{
    public static void Resposta5()
    {
        int[] Sorteio()
        {
            Random r = new Random();
            int[] sorteio = new int[3];
            for (int i = 0; i < 3; i++)
            {
                sorteio[i] = r.Next(10, 51); // Sorteia número de 10 a 50
            }

            return sorteio;
        }

        void Tentativa()
        {
            int[] sorteio = Sorteio(); // Recebe o valor retornado pela função sorteio
            Console.Write("NÚMEROS SORTEADOS: "); // Exibe os números sorteados para testar o programa
            foreach (int item in sorteio)
                Console.Write(item + " ");

            Console.WriteLine("\nForam sorteados 3 números de 10 a 50, digite suas tentativas para acertar um desses números");
            int tentativa = int.Parse(Console.ReadLine());

            while (tentativa != sorteio[0] && tentativa != sorteio[1] && tentativa != sorteio[2])
            {
                Console.WriteLine("Número incorreto! Tente novamente");   // Não sairá do loop enquanto o número correto nao for digitado
                tentativa = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número correto, parabéns!");
        }

        Tentativa(); // Chama o procedimento para a  tentativa


    }
}
