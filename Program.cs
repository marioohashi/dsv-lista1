using System;

namespace ExerciciosMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Selecione um exercício:");
                Console.WriteLine("1. Exercício 1");
                Console.WriteLine("2. Exercício 2");
                Console.WriteLine("3. Exercício 3");
                Console.WriteLine("4. Exercício 4");
                Console.WriteLine("5. Exercício 5");
                Console.WriteLine("6. Exercício 6");
                Console.WriteLine("7. Sair");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;
                    case 7:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }

                Console.WriteLine();
            }
        }

        // Implemente os métodos de exercício aqui
        static void Exercicio1()
        {
            Console.WriteLine("#Exercício 01");
            Console.WriteLine("Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.");
            Console.WriteLine("Informe a altura do retângulo:");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a largura do retângulo:");
            double largura = Convert.ToDouble(Console.ReadLine());
            double resultado = altura * largura;

            Console.WriteLine("Altura = " + altura);
            Console.WriteLine("Largura = " + largura);
            Console.WriteLine($"Área = {resultado:F2}");
        }

        static void Exercicio2()
        {
            Console.WriteLine("#Exercício 02");
            Console.WriteLine("Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos em:");
            Console.WriteLine("a) Dólar(1 dólar = 5, 18 reais)");
            Console.WriteLine("b) Euro(1 euro = 5, 31 reais)");
            Console.WriteLine("c) Peso argentino(1 peso argentino = 0,04 reais ");
            Console.WriteLine("Informe o valor em reais: ");
            double real = Convert.ToDouble(Console.ReadLine());
            double dolar = real * 5.18;
            double euro = real * 5.31;
            double peso = real * 0.04;

            Console.WriteLine("R$" + real);
            Console.WriteLine($"US${dolar:F2}");
            Console.WriteLine($"EU${euro:F2}");
            Console.WriteLine($"${peso:F2} pesos");
        }

        static void Exercicio3()
        {
            Console.WriteLine("#Exercício 03");
            Console.WriteLine("Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior.\n");
            Console.WriteLine("Informe o valor de N1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de N2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine($"N1:{n1} é maior que N2:{n2}");
            }
            else if (n2 > n1)
            {
                Console.WriteLine($"N2:{n2} é maior que N1:{n1}");
            }
            else
            {
                Console.WriteLine($"N1:{n1} é igual a N2:{n2}");
            }
        }

        static void Exercicio4()
        {
            Console.WriteLine("#Exercício 04\nDesenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens: se idade <= 13: Criança, se idade > 13 e <= 18: Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60: Idoso.\n");
            Console.WriteLine("Informe a idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade <= 13)
            {
                Console.WriteLine("Criança");
            }
            else if (idade > 13 && idade <= 18)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade > 18)
            {
                Console.WriteLine("Adulto");
            }
            else if (idade <= 60)
            {
                Console.WriteLine("Idoso");
            }
            else if (idade > 122)
            {
                Console.WriteLine("Highlander - Pessoa mais velha do mundo");
            }
        }

        static void Exercicio5()
        {
            Console.WriteLine("#Exercício 05");
            Console.WriteLine("Criar um algoritmo que receba um valor positivo inteiro e imprima a sequência Fibonacci até o valor lido. Por exemplo: caso o usuário insira o número 15, o programa deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13.");
            Console.WriteLine("Informe um numero inteiro");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sequência de Fibonacci até o valor informado:");
            ImprimirSequenciaFibonacci(n);


            static void ImprimirSequenciaFibonacci(int limite)
            {
                int primeiro = 0, segundo = 1, proximo;
                Console.Write(primeiro + ", " + segundo);
                proximo = primeiro + segundo;
                while (proximo <= limite)
                {
                    Console.Write(", " + proximo);
                    primeiro = segundo;
                    segundo = proximo;
                    proximo = primeiro + segundo;
                }
                Console.WriteLine();
            }

        }

        static void Exercicio6()
        {
            Console.WriteLine("#Exercício 06");
            Console.WriteLine("Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.");
            Console.WriteLine("a) Desenvolver o algoritmo de ordenação;");
            Console.WriteLine("b) Utilizar uma função em C# para ordenação;");
            int tamanho = 1000;
            int[] vetor = new int[tamanho];
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = random.Next(1, 10001); // Gera números entre 1 e 10000
            }

            foreach (int num in vetor)
            {
                Console.Write(num + " ");
            }

            Array.Sort(vetor); // Reordena o vetor

            Console.WriteLine("\nVetor ordenado usando Array.Sort:\n");
            foreach (int num in vetor)
            {
                Console.Write(num + " ");
            }
        }


    }
}

