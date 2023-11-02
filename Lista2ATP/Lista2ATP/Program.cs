int questao;
Console.WriteLine("Digite o número da questão da lista 2:");
questao = int.Parse(Console.ReadLine());

switch (questao)
{
    case 1:
        double num1, num2; // Variáveis para o primeiro e segundo número digitado

        Console.WriteLine("Digite um número qualquer");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro número qualquer");
        num2 = double.Parse(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine("O maior número é :" + num1); 
        else if (num2 > num1)                                 // Faz a comparação entre os dois números e mostra o maior
            Console.WriteLine("O maior número é: " + num2);
        else
            Console.WriteLine("Os dois números são iguais");
        Console.ReadKey();
        break;

    case 2:
        int num_1, num_2, soma;

        Console.WriteLine("Digite um número inteiro");
        num_1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro número inteiro");
        num_2 = int.Parse(Console.ReadLine());

        soma = num_1 + num_2; // Realiza a soma dos números e atribui o valor a varíavel soma

        if (soma >= 10)
            soma += 5;
        else            // Realiza a comparação e altera o valor de soma conforme os resultados
            soma += 7;

        Console.WriteLine(soma);
        Console.ReadKey();
        break;

    case 3:
        double a, b, r; // Variáveis respectivas para o coeficiente a, b e a raiz x

        Console.WriteLine("Digite o coeficiente a da equação do primeiro grau: ");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o coeficiente b da equação do primeiro grau: ");
        b = double.Parse(Console.ReadLine());

        r = -b / a; // ax + b = 0 -> realizando a operação matemática para isolar x chega em r = -b/a

        Console.WriteLine("A raiz da equação é: " + r);
        Console.ReadKey();
        break;

    case 4:
        int ano, idade; // Variáveis para o ano de nascimento e a idade
        char aniver;  // Variável para receber a opção sim ou não

        Console.WriteLine("Digite seu ano de nascimento");
        ano = int.Parse(Console.ReadLine());

        idade = 2023 - ano; // Subtrai o ano atual pelo ano de nascimento para chegar na idade

        Console.WriteLine("Você ja fez aniversário esse ano? (S/N)");
        aniver = char.Parse(Console.ReadLine());
        while (aniver != 'S' &&  aniver != 's' && aniver != 'N' && aniver != 'n') // Faz um while para impedir que outro 
        {                                                                         // valor além de S ou N seja digitado
            Console.WriteLine("Digite apenas S ou N");
            aniver = char.Parse(Console.ReadLine());
        }
        if (aniver == 'N' || aniver == 'n')
            idade--; // Subtrai 1 a idade caso a pessoa não tenha feito aniversário

        Console.WriteLine("Sua idade é {0} anos", idade);
        Console.ReadKey();
        break;

    case 5:
        double nota;

        Console.WriteLine("Digite sua nota de 0 a 10");
        nota = double.Parse(Console.ReadLine());
        while (nota < 0 || nota > 10) // Faz um while para impedir que um valor menor que 0 ou maior que 10 seja digitada
        {                             
            Console.WriteLine("Digite uma nota entre 0 e 10");
            nota = double.Parse(Console.ReadLine());
        }
        if (nota >= 8 && nota <= 10)
            Console.WriteLine("Ótimo");

        else if (nota >= 7 && nota < 8) // Faz os IF's para comparar as notas e expressar os respectivos resultados
            Console.WriteLine("Bom");

        else if (nota >= 5 && nota < 7)
            Console.WriteLine("Regular");

        else
            Console.WriteLine("Insatisfatório");
        Console.ReadKey();
        break;

    case 6:
        double diaria, promo, total, totalpromo, dif; // Variáveis para o valor da diaria, diaria com desconto,  
                                                      // total sem desconto, total com desconto e a diferença
        Console.WriteLine("Digite o valor da diária");
        diaria = double.Parse(Console.ReadLine());

        promo = diaria * 0.75; // Multiplica a diária 0.75 para encontrar o valor da diária com desconto
        totalpromo = promo * 60; // Multiplica o valor da diaria com desconto pela ocupação de 80%, que é 60
        total = diaria * 37; // Multiplica o valor da diaria normal pela ocupação de 50%, que é 37,5 
        dif = Math.Abs(total - totalpromo); // Usa a função Abs para pegar o valor absoluto, para que não fique negativo

        Console.WriteLine("O valor da diária promocional é R$ " + promo);
        Console.WriteLine("o valor total arrecadado com 80% de ocupação e diária promocional é R$ " + totalpromo);
        Console.WriteLine("o valor total arrecadado com 50% de ocupação e diária normal é R$ " + total);
        Console.WriteLine("A diferença entre os dois é de R$ " + dif);
        Console.ReadKey();
        break;

    case 7:
        double y = 0, x;

        Console.WriteLine("Digite o valor de X");
        x = double.Parse(Console.ReadLine());

        if (x <= 1)
            y = 1;
        else if (x > 1 && x <= 2)
            y = 2;
        else if (x > 2 && x <= 3)  // Realiza as comparações e atribui os valores a y
            y = Math.Pow(x, 2); // Eleva x ao quadrado
        else if (x > 3)
            y = Math.Pow(x, 3); // Eleva x ao cubo

        Console.WriteLine(y);
        Console.ReadKey();
        break;

    case 8:
        char opc;
        double salario, novo = 0; 
        Console.WriteLine("Digite o valor do salário");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a opção de aumento de salário (A, B, ou C)");
        opc = char.Parse(Console.ReadLine());
        switch (opc)
        {
            case 'A': // Dois case para aceitar maiúsculo e minúsculo
            case 'a':
                novo = salario * 1.08; // Multiplica por 1.08 para já realizar 8%¨de aumento
                break;

            case 'B':
            case 'b':
                novo = salario * 1.11; // Multiplica por 1.11 para já realizar 11%¨de aumento
                break;

            case 'C':
            case 'c':
                if (salario <= 1000)
                    novo = salario + 350;
                else if (salario > 1000) // Faz o if para as comparações do salário
                    novo = salario + 200;
                break;

            default:
                Console.WriteLine("Digite apenas A/a, B/b ou C/c");
                Console.ReadKey();
                break;
        }
        Console.WriteLine("O novo salário é R$ {0:f2}", novo); // Fornatação com duas casas decimais
        Console.ReadKey();
        break;

    case 9:
        char sinal;

        Console.WriteLine("Digite uma tecla");
        sinal = char.Parse(Console.ReadLine());

        switch (sinal)
        {
            case '-':   // Case para o sinal -
                Console.WriteLine("Sinal de menor");
                break;

            case '+': // Case para o sinal +
                Console.WriteLine("Sinal de mais");  
                break;

            case '=':  // Case para o sinal =
                Console.WriteLine("Sinal de igual");
                break;

            default: // Default para todas as outras opções nao incluida nas três possíveis
                Console.WriteLine("Outro sinal");
                break;
        }
        Console.ReadKey();
        break;


    case 10:
        double max, vel, diff; // Variáveis para velocidade máxima, velocidade do motorista e a diferença

        Console.WriteLine("Digite a velocidade máxima permitida da via:");
        max = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a velocidade do motorista");
        vel = double.Parse(Console.ReadLine());

        diff = vel - max; // Cálcula a diferença da velocidade do motorista e da velocidade máxima

        if (vel <= max)
            Console.WriteLine("Motorista respeitou a lei");
        else
        {
            if (diff <= 10)
                Console.WriteLine("O valor da multa será 50 reais");
            else if (diff > 10 && diff <= 30)
                Console.WriteLine("O valor da multa será 100 reais"); // Realiza as comparações e imprime o valor da multa
            else if (diff > 30)
                Console.WriteLine("O valor da multa será 200 reais");
        }
        Console.ReadKey();
        break;








}
