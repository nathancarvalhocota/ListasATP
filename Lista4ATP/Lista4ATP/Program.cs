// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Digite o número da questão");
int questao = int.Parse(Console.ReadLine());

switch (questao)
{ 
    case 1:

        void notas()
        {
            double n1, n2, n3, media = 0.0;
            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite A para média aritimética e P para média ponderada");
            char tipo = char.Parse(Console.ReadLine());
            switch (tipo)
            {
                case 'A':
                case 'a':
                    media = (n1 + n2 + n3) / 3;
                    break;
                case 'P':
                case 'p':
                    media = (n1 * 5 + n2 * 3 + n3 * 2) / 3;
                    break;
            }
            Console.WriteLine("A média é: " + media);
        }

        int alunos;
        Console.WriteLine("Digite a quantidade de alunos: ");
        alunos = int.Parse(Console.ReadLine());
        do
        {
            notas();
            alunos--;
        } while (alunos > 0);
        break;

    case 2:
        void Pesquisa()
        {
            double salario = 0, total_s = 0, media;
            int filhos, total_p = 0;

            do
            {
                Console.WriteLine("Digite o salário");
                salario = double.Parse(Console.ReadLine());
                if (salario > 0)
                {
                    Console.WriteLine("Digite a quantidade de filhos");
                    filhos = int.Parse(Console.ReadLine());
                    total_p += filhos + 1;
                    total_s += salario;
                }

            } while (salario > 0);


            media = total_s / total_p;

            Console.WriteLine("A média do salário é R$: " + media);
        }

        Console.WriteLine(" - - - - - - DIGITE 0 PARA SAIR - - - - - -");
        Pesquisa();
        break;

    case 3:
        void Ordem(int a, int b, int c)
        {
            int maior = 0, menor = 0, meio = 0;

            if (a > b && a > c)
                maior = a;
            else if (b > a && b > c)
                maior = b;
            else if (c > a && c > b)
                maior = c;

            if (a < b && a < c)
                menor = a;
            else if (b < a && b < c)
                menor = b;
            else if (c < a && c < b)
                menor = c;

            if (a < maior && a > menor)
                meio = a;
            else if (b < maior && b > menor)
                meio = b;
            else if (c < maior && c > menor)
                meio = c;

            Console.WriteLine("A ordem crescente dos números é: {0}, {1}, {2}", menor, meio, maior);
        }

        Console.WriteLine("Digite quantas vezes deseja realizar o procedimento");
        int vezes = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("Digite 3 valores inteiros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Ordem(a, b, c);
            vezes--;
        } while (vezes > 0);
        break;


    case 4:
        void Triangulo(int x, int y, int z)
        {
            if (x == y && y == z)
                Console.WriteLine("Triângulo equilátero");
            else if (x == y || x == z || y == z)
                Console.WriteLine("Triângulo isóceles");
            else
                Console.WriteLine("Triângulo Escaleno");
        }

        Console.WriteLine("Digite os lados do triângulo: ");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());

        while (x > y + z || y > x + z || z > y + x)
        {
            Console.WriteLine("Esses valores não podem ser comprimentos dos lados de um triângulo! Digite outros valores");
            Console.WriteLine("Digite os lados do triângulo: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
        }

        Triangulo(x, y, z);
        break;

    case 5:
        int Mdc(int num1, int num2)
        {
            int mdc = 0;
            while (num2 != 0)
            {
                mdc = num1 % num2;
                num1 = num2;
                num2 = mdc;
            }
            return num1;
        }

        Console.WriteLine("Digite dois valores inteiros: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("O máximo divisor comum entre os números é: " + Mdc(num1, num2));
        break;

    case 6:
        bool positivo(int num)
        {
            bool positivo = true;

            if (num < 0) positivo = false;

            return positivo;
        }

        Console.WriteLine("Digite quantos números deseja verificar");
        int qtde = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Digite um valor inteiro");
            int num = int.Parse(Console.ReadLine());

            if (positivo(num)) Console.WriteLine("Este número é positivo \n");

            else if (!positivo(num)) Console.WriteLine("Este número é negativo \n");

            qtde--;
        } while (qtde > 0);
        break;

    case 7:
        void media(double nota)
        {
            if (nota < 40)
                Console.WriteLine("Conceito: F");
            else if (nota >= 40 && nota < 60)
                Console.WriteLine("Conceito: E");
            else if (nota >= 60 && nota < 70)
                Console.WriteLine("Conceito: D");
            else if (nota >= 70 && nota < 80)
                Console.WriteLine("Conceito: C");
            else if (nota >= 80 && nota < 90)
                Console.WriteLine("Conceito: B");
            else if (nota >= 90)
                Console.WriteLine("Conceito: A");

        }
        Console.WriteLine("Digite quantas notas serão lidas:");
        int qtd = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Digite sua nota");
            double nota = double.Parse(Console.ReadLine());
            media(nota);
            qtd--;
        } while (qtd > 0);
        break;

    case 8:
        double calculo(int n)
        {
            double s = 0;
            for (int i = 1; i <= n; i++)
                s += (Math.Pow(i, 2) + 1) / (i + 3);
            return s;
        }

        Console.WriteLine("Digite um valor inteiro e positivo");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("O resultado da fórmula é: " + calculo(n));
        break;


    case 9:
        double media_notas(int aluno, ref int aprovado)
        {
            aprovado = 0;
            double nota, soma = 0;
            do
            {
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                if (nota >= 6)
                {
                    soma += nota;
                    aprovado++;
                }

                aluno--;
            } while (aluno > 0);

            return soma / aprovado;
        }

        Console.WriteLine("Digite a quantidade de alunos");
        int aluno = int.Parse(Console.ReadLine());
        int aprovado = 0;

        double medianotas = media_notas(aluno, ref aprovado);

        if (aprovado == 0)
            Console.WriteLine("Nenhum aluno foi aprovado");
        else
            Console.WriteLine("A média da nota dos alunos aprovados é: " + medianotas);
        break;

    case 10:
        char categoria(int idade)
        {
            if (idade >= 5 && idade <= 7)
                return 'F';
            else if (idade >= 8 && idade <= 10)
                return 'E';
            else if (idade >= 11 && idade <= 13)
                return 'D';
            else if (idade >= 14 && idade <= 15)
                return 'C';
            else if (idade >= 16 && idade <= 17)
                return 'B';
            else if (idade >= 18)
                return 'A';

            return 'X';
        }
        Console.WriteLine("Digite a idade do nadador");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("A catégoria é: " + categoria(idade));
        break;

    /* - - - - - - - - - - EXERCÍCIOS EXTRAS - - - - - - - - -
    case 11:

        int Potencia(int aa, int nn)
        {
            int soma = 0;
            for (int i = 0; i < nn; i++)
            {
                if (nn == 0)
                    soma = 1;
                else if (i == 1)
                    soma = aa * aa;
                else if (i > 1)
                    soma = soma * aa;

                // Console.WriteLine(soma);
            }
            return soma;
        }
        int aa = int.Parse(Console.ReadLine());
        int nn = int.Parse(Console.ReadLine());
        Console.WriteLine(Potencia(aa, nn));
        break;

    case 12:
        int Menor(int[] vetor)
        {
            int maior = vetor[0];
            for (int i = 1;i < vetor.Length; i++)
            {              
                if (vetor[i] < maior)
                    maior = vetor[i];
            }

            return maior;
        }
        int[] vetor = new int[5];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("O menor é" + Menor(vetor));
        break;

    case 13:
        double raio, area, numm = 3.14159;
        raio = double.Parse(Console.ReadLine());
        area = numm * Math.Pow(raio, 2);
        Console.WriteLine("A={0:f4}", area);
        break;

    case 14:
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int soma = a + b;
        Console.WriteLine("SOMA = " + soma);
        break;

    case 15:
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int prod = n1 * n2;
        Console.WriteLine("PROD = " + prod);
        break;

    case 16:
        double x = Math.Round(double.Parse(Console.ReadLine()),1);
        Console.WriteLine(x);
        double y = Math.Round(double.Parse(Console.ReadLine()),1);
        Console.WriteLine(y);
        double media = ((x * 3.5) + (y * 7.5)) / 11;
        Console.WriteLine("MEDIA = {0:f5}", media);
        break;

    case 17:
        double num1 = Math.Round(double.Parse(Console.ReadLine()),1);
        double num2 = Math.Round(double.Parse(Console.ReadLine()),1);
        double num3 = Math.Round(double.Parse(Console.ReadLine()),1);
        double med = ((num1 * 2) + (num2 * 3) + (num3 * 5)) / 10;
        Console.WriteLine("MEDIA = {0:f1}", med);
        break;

    case 18:
        int numero = int.Parse(Console.ReadLine());
        int horas = int.Parse(Console.ReadLine());
        double salario_hora = Math.Round(double.Parse(Console.ReadLine()), 2);
        double salario = salario_hora * horas;
        Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " + salario);
        break;

    case 19:
        double pi = 3.14159;
        double r = double.Parse(Console.ReadLine());
        double volume = (4.0/3.0) * pi * Math.Pow(r,3);
        Console.WriteLine("VOLUME = {0:f3}", volume);
        break;

    case 20:
        double n_1, n_2, n_3;
        n_1 = double.Parse(Console.ReadLine());
        n_2 = double.Parse(Console.ReadLine());
        n_3 = double.Parse(Console.ReadLine());
        double area_t = (n_1 * n_3) / 2;
        double area_c = 3.14159 * Math.Pow(n_3, 2);
        double area_trap = ((n_1 + n_2) * n_3)/ 2;
        double area_q = n_2 * n_2;
        double area_r = n_1 * n_2;
        Console.WriteLine("TRIANGULO: {0:f3}", area_t);
        Console.WriteLine("CIRCULO: {0:f3}", area_c);
        Console.WriteLine("TRAPEZIO: {0:f3}", area_trap);
        Console.WriteLine("QUADRADO: {0:f3}", area_q);
        Console.WriteLine("RETANGULO: {0:f3}", area_r);

        break;*/
}