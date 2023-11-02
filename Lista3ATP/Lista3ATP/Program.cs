
Console.WriteLine("Digite a questão da lista 3");
int quest = int.Parse(Console.ReadLine());

switch (quest)
{
    case 1:
        double num; // Variável para o número que o usuário irá digitar
        int posi = 0, neg = 0, nulo = 0; // Variáveis para acumular a quantidade de positivos, negativos e nulos
        bool numerico; // Variável para verificar se o valor digitado é um número ou não
        string valor;
        Console.WriteLine("- - - - - Para encerrar o programa digite qualquer letra - - - - -");
        do
        {
            Console.WriteLine("Digite um número qualquer");
            valor = (Console.ReadLine());
            numerico = double.TryParse(valor, out num); // Tenta fazer a conversão do string para double
            if (numerico == true) // Caso seja possível realizar a conversão, executa as instruções
            {

                if (num > 0)
                    posi++;
                if (num < 0)
                    neg++;
                else if (num == 0)
                    nulo++;
            }
        }
        while (numerico == true); // Se a conversão não for possível significa que o valor digitado é uma letra, então encerra o programa

        Console.WriteLine("Foram digitados {0} números positivos, {1} números negativos e {2} números nulos", posi, neg, nulo);
        break;

    case 2:
        double numero, pst = 0.0, ngt = 0.0, zero = 0.0;
        int tot = 0;
        bool numero_bool;
        string val;
        do {
            Console.WriteLine("Digite um número qualquer (Para encerrar o programa digite qualquer letra)");
            val = (Console.ReadLine());
            numero_bool = double.TryParse(val, out numero); // Tenta fazer a conversão do string para double
            if (numero_bool == true) { // Caso seja possível realizar a conversão, executa as instruções
                if (numero > 0) {
                    pst++;
                    tot++;
                }
                if (numero < 0) {
                    ngt++;
                    tot++;
                }
                else if (numero == 0)  {
                    zero++;
                    tot++;
                }
            }
        } while (numero_bool == true);  // Se a conversão não for possível significa que o valor digitado é uma letra, então encerra o programa

        pst = (pst / tot) * 100;
        ngt = (ngt / tot) * 100; // Realiza os cálculos para encontrar as porcentagens de cada valor
        zero = (zero / tot) * 100;
        Console.WriteLine("Foram digitados {0} números: Do qual {1}% são números positivos e {2}% números negativos e {3}% são números nulos", tot, pst, ngt, zero);
        break;

    case 3:
        int n, div_3e9 = 0, div_2 = 0, div_5 = 0, qtd = 0;
        do
        {
            Console.WriteLine("Digite um número");
            n = int.Parse(Console.ReadLine());
            if ((n % 3 == 0) && (n % 9 == 0) && n != 0) // Verifica se o número é divisível por 3 E 9
            {
                if (n % 5 == 0) // Verifica se dentre desses números ele também é divisível por 5
                    div_5++;
                div_3e9++;
            }
            else if (n % 2 == 0 && n != 0) // Verifica se o número é divisível por 2
            {
                if (n % 5 == 0) // Verifica se dentre desses números ele também é divisível por 5
                    div_5++;
                div_2++;
            }
            else if (n % 5 == 0 && n != 0) // Verifica se o número é divisível por 5
                div_5++;
            else
                Console.WriteLine("Número não é divisível por nenhuma das opções!");
            qtd++; // Aumenta de 1 em 1 a quantidade até chegar a 10
        } while (qtd <= 10); // Caso a quantidade atinja dez o programa encerra a contagem e exibe os dados
        Console.WriteLine("{0} números são divisíves por 3 e 9", div_3e9);
        Console.WriteLine("{0} números são divisíves por 2", div_2);
        Console.WriteLine("{0} números são divisíves por 5", div_5);
        break;


    case 4:
        double var, e;
        Console.WriteLine("Digite um número inteiro positivo: ");
        var = double.Parse(Console.ReadLine());
        e = 2.0; // Inicializa é a 2 pois na formula há 1 + 1/1 . . . 

        for (double i = 2; i <= var; i++) // for para realizar a contagem N vezes, atingindo o total de números
        {
            double resultado = 1; double fat = i; // fat recebe i, para realizar o cálculo com i números
            while (fat != 1) // while que realiza o cálculo do fatorial
            {
                resultado = resultado * fat;
                fat = fat - 1; 
            }

            e = e + (1 / resultado); // Realiza a soma cada vez e transfere o resultado para 'e'
        }
        Console.WriteLine("O valor de E é: " + e);
        break;

    case 5:
        double sal = 0, maior_sal = 0, tot_sal = 0, media_sal = 0, media_filhos = 0, sal_100porcentagem;
        int hab = 0, filhos = 0, tot_filhos = 0, sal_100 = 0;
        Console.WriteLine(" - - - - - PARA ENCERRAR DIGITE UM SALÁRIO MENOR QUE 0 - - - - -");
        do
        {
            Console.WriteLine("Olá! Digite o seu salário:");
            sal = double.Parse(Console.ReadLine());

            if (sal > 0) // Se o valor do salário for maior que 0 realiza a função
            {
                if (sal > maior_sal)
                    maior_sal = sal;

                if (sal > 100)
                    sal_100++;
                Console.WriteLine("Digite a quantidade de filhos");
                filhos = int.Parse(Console.ReadLine());
                hab++;
                tot_filhos += filhos;
                tot_sal += sal;
            }
        } while (sal > 0); // Encerra o programa caso o valor digitado seja menor que 0

        media_sal = tot_sal / hab;
        media_filhos = (double)tot_filhos / hab;
        sal_100porcentagem = ((double)sal_100 / hab) * 100;
        Console.WriteLine("A média do salário da população é: R$ " + media_sal);
        Console.WriteLine("A média de filhos da população é: " + media_filhos);
        Console.WriteLine("O maior salário é: R$ " + maior_sal);
        Console.Write("A porcentagem de pessoas com salário maior que R$ 100 é: {0}%", sal_100porcentagem);
        break;

    case 6:
        int x;
        double soma = 0;
        Console.WriteLine("Digite um valor X inteiro e positivo:");
        x = int.Parse(Console.ReadLine());
        for (double i = 1; i <= x; i++) // Realiza o for para passar por cada número, na quantidade informada
        {
            soma += 1 / i; // Divide pelo índice atual i
            Console.WriteLine(soma);
        }
        Console.WriteLine("O valor final de soma é: " + soma);
        break;

    case 7:
        Console.Write("Digite a quantidade de números da sequência de Fibonacci que você deseja imprimir: ");
        int elem = int.Parse(Console.ReadLine());

        if (elem <= 0)
        {
            Console.WriteLine("Digite um número positivo.");
        }
        else
        {
            // Inicializa os primeiros dois números da sequência
            int f1 = 1; // Inicia os dois números como 1 pois os dois primeiros são iguais a 1
            int f2 = 1;

            Console.WriteLine("Os primeiros " + elem + " números da sequência de Fibonacci são:");  // Imprime os números da sequência


            for (int i = 1; i <= elem; i++) // Realiza o for para buscar cada numero da sequência
            {
                Console.WriteLine(f1);

                int temp = f1;
                f1 = f2; // Transfere os valores para um número temporário, para entrao trocar as variáveis do primeiro e segundo número
                f2 = temp + f2;
            }

            Console.WriteLine(); // Quebra de linha após imprimir a sequência
        }
        break;

    case 8:
        Console.Write("Digite um número positivo: ");
        int elemen = int.Parse(Console.ReadLine());

        if (elemen <= 0)
        {
            Console.WriteLine("Digite um número positivo.");
        }
        else
        {
            // Inicializa os primeiros dois números da sequência
            int f1 = 1;
            int f2 = 1;

            Console.WriteLine("Os números da sequência de Fibonacci menores que {0} são: ", elemen);

            // Imprime os números da sequência
            for (int i = 1; i <= elemen; i++)
            {
                if (f2 < elemen) // Realiza uma comparação com o último número, e só escreve caso seja menor do que o valor digitado
                {
                    int temp = f1;
                    f1 = f2;
                    f2 = temp + f2;
                    Console.WriteLine(f1);
                }
            }
            Console.WriteLine(); // Quebra de linha após imprimir a sequência
        }
        break;

    case 9:
        Console.WriteLine("- - - - - - Para sair digite um valor de compra igual a zero - - - - - - \n");
        double compra = 0, venda = 0, lucro, totalcompra = 0, totalvenda = 0, lucrototal = 0;
        int menor10 = 0, entre10e20 = 0, maior20 = 0;
        do
        {
            Console.WriteLine("Digite o valor de compra da mercadoria:");
            compra = double.Parse(Console.ReadLine());

            if (compra != 0)
            {
                Console.WriteLine("Digite o valor de venda da mercadoria:");
                venda = double.Parse(Console.ReadLine());

                totalcompra += compra;
                totalvenda += venda;

                lucro = ((venda - compra) / compra) * 100;
                if (lucro < 10)
                    menor10++;
                else if (lucro >= 10 && lucro <= 20)
                    entre10e20++;
                else if (lucro > 20)
                    maior20++;
            }
        } while (compra > 0);
        lucrototal = totalvenda - totalcompra;
        Console.WriteLine(menor10 + " mercadorias proporcionaram um lucro menor que 10%");
        Console.WriteLine(entre10e20 + " mercadorias proporcionaram um lucro entre 10% e 20%");
        Console.WriteLine(maior20 + " mercadorias proporcionaram um lucro maior que 20%");

        Console.WriteLine("O valor total em compras foi R${0}, o valor total em vendas foi R${1} e o lucro total foi de R${2}", totalcompra, totalvenda, lucrototal);
        break;

    case 10:
        
        int voto, voto_a = 0, voto_b = 0, voto_c = 0, voto_d = 0, voto_nulo = 0, voto_branco = 0;
        do
        {
            Console.WriteLine("- - - - - PARA ENCERRAR DIGITE O NÚMERO 0 - - - - - \n");
            Console.WriteLine("Digite o voto desejado: ");
            Console.WriteLine("1 para candidato A");
            Console.WriteLine("2 para candidato B");
            Console.WriteLine("3 para candidato C");
            Console.WriteLine("4 para candidato D");
            Console.WriteLine("5 para voto NULO");
            Console.WriteLine("6 para voto em BRANCO");

            voto = int.Parse(Console.ReadLine());
            switch (voto)
            {
                case 1:
                    voto_a++;
                    break;
                case 2:
                    voto_b++;
                    break;
                case 3:
                    voto_c++;
                    break;
                case 4:
                    voto_d++;
                    break;
                case 5:
                    voto_nulo++;
                    break;
                case 6:
                    voto_branco++;
                    break;
                default:
                    Console.WriteLine("Código inválido!");
                    break;
            }
            Console.Clear();


        } while (voto != 0);
        Console.Clear();
        Console.WriteLine("\nO candidato A teve {0} votos", voto_a);
        Console.WriteLine("O candidato B teve {0} votos", voto_b);
        Console.WriteLine("O candidato C teve {0} votos", voto_c);
        Console.WriteLine("O candidato D teve {0} votos", voto_d);
        Console.WriteLine("{0} votos nulos", voto_nulo);
        Console.WriteLine("{0} votos em branco", voto_branco);
        break;


}


