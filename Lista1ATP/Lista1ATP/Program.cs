// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;

int quest;
Console.WriteLine("Digite o número da questão desejada da lista 1: ");
quest = int.Parse(Console.ReadLine());

switch (quest)
{

    case 1:
        // Variáveis respectivas para base, altura, perímetro, área e diagonal
        double b, h, per, a, d;

        Console.WriteLine("Digite a base do retângulo");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do retângulo");
        h = double.Parse(Console.ReadLine());

        per = (b + h) * 2; // Cálculo do perímetro
        a = b * h; // Cálculo da área
        d = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2)); // Cálculo da diagonal

        Console.WriteLine("O perímetro do retângulo é: {0}", per);
        Console.WriteLine("A área do retângulo é: " + a);
        Console.WriteLine("A diagonal do retângulo é: " + d);
        break;


    case 2:
        // Variáveis respectivas para cateto adjacente, cateto opesto e hipotenusa
        double ca, co, hip;

        Console.WriteLine("Digite o valor do cateto adjacente do triângulo");
        ca = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do cateto oposto do triângulo");
        co = double.Parse(Console.ReadLine());

        hip = Math.Sqrt(Math.Pow(ca, 2) + Math.Pow(co, 2)); // Cálculo da hipotenusa

        Console.WriteLine("A hipotenusa do triângulo é: {0}", hip);
        break;


    case 3:
        // Variáveis respectivas para salário mínimo, quantidade gasta de kw, valor em reais de cada kw e o valor com desconto
        double sal, qtd, kw, val, desc;

        Console.WriteLine("Digite o valor do salário mínimo");
        sal = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de KW gasta na residência");
        qtd = double.Parse(Console.ReadLine());

        kw = ((sal / 7) / 100); // 100 KW equivale ao salário mínimo/7, 1kw equivale a isso dividido por 100
        val = kw * qtd; // O valor a ser pago é a quantidade de KW gasta vezes o valor de cada KW
        desc = val * 0.9; // Cálculo do desconto (90% do valor integral)

        Console.WriteLine("O valor de cada KW é: R$ " + kw);
        Console.WriteLine("O valor a ser pago é: R$ " + val);
        Console.WriteLine("O valor a ser pago com um desconto de 10% é: R$ " + desc);
        break;


    case 4:
        // Variáveis para os pontos x1, y1, x2, y2 e a distância entre os pontos
        double x1, y1, x2, y2, dist;

        Console.WriteLine("Digite a coordenada X do primeiro ponto");
        x1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a cordenada Y do primeiro ponto");
        y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a cordenada X do segundo ponto");
        x2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a cordenada Y do segundo ponto");
        y2 = double.Parse(Console.ReadLine());


        dist = (Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)))); // Cálculo da fórmula para encontrar a distância dos pontos

        Console.WriteLine("A distância entre os dois pontos é: " + dist);
        break;

    case 5:
        double p, i, tot; // Variáveis da fórmula
        int n;

        Console.WriteLine("Digite o valor da aplicação mensal");
        p = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da taxa em %");
        i = double.Parse(Console.ReadLine());
        i /= 100; // Divsão do valor por 100 para multiplicar na fórmula

        Console.WriteLine("Digite a quantidade de meses");
        n = int.Parse(Console.ReadLine());

        tot = p * ((Math.Pow(1 + i, n) - 1) / i); // Comando para realizr o cálculo completo da fórmula utilizada

        Console.WriteLine("O valor total acumulado em {0} meses será: R$: {1}", n, tot);
        break;

    case 6:       
        double var0, var1, var2;

        Console.WriteLine("Digite um número real qualquer");
        var1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite um segundo número real qualquer");
        var2 = double.Parse(Console.ReadLine());
        
        var0 = var1;
        var1 = var2; // Utiliza-se uma terceira variável para guardar o valor de uma das outras e depois realizar a troca
        var2 = var0;

        Console.WriteLine("Agora o primeiro número vale: {0} e o segundo número vale: {1}", var1, var2);
        break;

    case 7:
        int ano, meses, dias, qtdedias;

        Console.WriteLine("Digite a quantidade total de dias:");
        qtdedias = int.Parse(Console.ReadLine());

        ano = qtdedias / 360; // Divide os dias por 360 para encontrar o ano
        meses = (qtdedias  % 360) / 30; // Divide o resto dos dias por 30 para encontrar os meses
        dias = (qtdedias % 360) % 30; // Pega o resto dos anos e dos meses para encontrar os dias

        Console.WriteLine("{0} dias equivale a {1} ano(s) {2} meses e {3} dias", qtdedias, ano, meses, dias);
        break;

    case 8:
        // Variáveis para o número da conta, os dígitos separados, dígitos separados do número invertido, a soma de ambos
        // e o verificador final
        int numero,d1, d2, d3, di1, di2, di3, di4, inverso, somanumero = 0, verificador = 0;
        // Variável para o string do número inverso para verificar a quantidade de casas do número
        string inverso_string;

        Console.WriteLine("Digite o número da conta:");
        numero = int.Parse(Console.ReadLine());

        d1 = numero / 100; // Operação para pegar a casa das centenas do número da conta
        d2 = (numero % 100) / 10; // Operação para pegar a casa das dezenas do número da conta
        d3 = (numero % 100) % 10; // Operação para pegar a casa das unidades do número da conta

        inverso = (d3 * 100) + (d2 * 10) + (d1 * 1); // Operação para encontrar o número inverso
        inverso += numero; // Atribui o valor do número inverso como a soma do mesmo com o número da conta

        /* *** Neste momento supõe-se que caso a soma dos números resulte em um com mais de 4 digitos deve se
        multiplicar a casa das unidades por 4, pois a questão não específica essa condição. ***
        Usa o .Length para encontrar o tamanho da string, que nesse caso se refere a quantidade de dígitos da 
        soma do número inverso com o número da conta */

        inverso_string = Convert.ToString(inverso);
        if (inverso_string.Length == 4) 
        {                               
            di1 = inverso / 1000;
            di2 = (inverso % 1000) / 100;  // Mesmo processo para pegar cada dígito do número, porém com 4 casas
            di3 = (inverso % 1000) / 10 % 10;
            di4 = (inverso % 1000) % 10;

            di1 *= 1;
            di2 *= 2; // Multiplicação de cada dígito por seu respectivo valor, solicitada pela questão 
            di3 *= 3;
            di4 *= 4;

            somanumero = di1 + di2 + di3 + di4; // Soma de cada dígito, solicitada pela questão 
        }

        else if (inverso_string.Length == 3)
        {
            d1 = inverso / 100;
            d2 = (inverso % 100) / 10; // Mesmo processo para pegar cada dígito do número, agora com 3 casas
            d3 = (inverso % 100) % 10;

            d1 *= 1;
            d2 *= 2; // Multiplicação de cada dígito por seu respectivo valor, solicitada pela questão 
            d3 *= 3;

            somanumero = d1 + d2 + d3; // Soma de cada dígito, solicitada pela questão     
        }
    verificador = somanumero % 10; // Operação que seleciona o último dígito para o verificador
    Console.WriteLine("O dígito verificador é: " + verificador);
    break;


/* case 8:
    string digito;
    Console.WriteLine("Digite o dígito da conta:");
    digito = Console.ReadLine();
    if (digito.Length == 3) 
    {
        char[] caracteres = digito.ToCharArray(); // Converte o digito para um vetor de char 
        Array.Reverse(caracteres); // Reverte o vetor para conseguir o inverso do número  
        string inverter = new string (caracteres); // Usa o new string pois o 'Convert.ToString' não aceita um char array
        int inverso = int.Parse(inverter); // Transforma a string do número invertido em um int para realizar o cálculo  
        int soma = int.Parse(digito) + inverso; // Soma o número inicial com o inverso 
        string somastring = Convert.ToString(soma); // Converte a soma para string para separar os dígitos

        int d1 = int.Parse(somastring[0].ToString());
        int d2 = int.Parse(somastring[1].ToString()); // Seleciona cada dígito da string referente a soma  
        int d3 = int.Parse(somastring[2].ToString());

        d1 = d1 * 1; // Nesse momento o código apresentará um erro caso a soma do número original com o inverso seja maior
        d2 = d2 * 2; // do que 4 dígitos, pois a questão não específica valor para a casa dos milhares, portanto o último
        d3 = d3 * 3; // digito referente as unidades iria ser ignorado

        int soma_v = d1 + d2 + d3; // Soma cada dígito 

        string digito_v = soma_v.ToString(); // Transforma o resultado da soma e uma string para selecionar o último digito

        char verificador = digito_v[digito_v.Length - 1]; // Seleciona o dígito verificador

        Console.WriteLine("O dígito verificador é: " + verificador);
    }

    else
    {
        Console.WriteLine("O dígito precisa ter exatamente 3 casas");
    }
        break; */

    default:
        Console.WriteLine("Questão não encontrada");
        break;
}





