﻿// mediaDasIdades();
// TestaBurcarPalavras();

// static void mediaDasIdades()
// {
//     int[] idades = new int[5];

//     idades[0] = 12;
//     idades[1] = 32;
//     idades[2] = 43;
//     idades[3] = 23;
//     idades[4] = 55;

//     Console.WriteLine($"Tamanho do Array {idades.Length}");
//     for (int i = 0; i < idades.Length; i++)
//     {
//         int idade = idades[i];
//         Console.WriteLine($"Índice [{i}] = {idade}");
//         int media = idade / idades.Length;
//         Console.WriteLine($"\nMédia das idades: {media}");
//     }
// }

// void TestaBurcarPalavras()
// {
//     string[] arrayNomes = new string[5];
//     for (int i = 0; i < arrayNomes.Length; i++)
//     {
//         Console.Write($"Digite 0 {i + 1}ª nome: ");
//         arrayNomes[i] = Console.ReadLine();
//     }
//     System.Console.WriteLine($"Digite o nome desejado: ");
//     string busca = Console.ReadLine();
//     foreach (var nome in arrayNomes)
//     {
//         if (nome.Equals(busca))
//         {
//             System.Console.WriteLine($"Nome encontrado {busca}");
//         }
//     }
// }

// Array amostra = Array.CreateInstance(typeof(double), 5);
// amostra.SetValue(7.8, 0);
// amostra.SetValue(8, 1);
// amostra.SetValue(8, 2);
// amostra.SetValue(3.8, 3);
// amostra.SetValue(5.8, 4);

// TestaMediana(amostra);
// static void TestaMediana(Array array)
// {
//     if ((array == null) || (array.Length == 0))
//     {
//         System.Console.WriteLine("Array está vazio ou Nulo.");
//     }
//     double[] numerosOrdenados = (double[])array.Clone();
//     Array.Sort(numerosOrdenados);

//     int tamanho = numerosOrdenados.Length;
//     int meio = tamanho / 2;
//     double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio - 1] / 2);
//     System.Console.WriteLine($"Com base na amostra a mediana = {mediana}");
// }


// using bytebank.Modelos.Conta;
// using bytebank_ATENDIMENTO.bytebank.Util;

// void TestaArrayDeContaCorrente()
// {
//     ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
//     {
//         listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A", 123));
//         listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B", 5675455));
//         listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C", 75756));
//         listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C", 567567));
//         listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C", 6756));
//         listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C", 234));
//         listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C", 23424));
//     }

//     for (int i = 0; i < listaDeContas.Length; i++)
//     {

//     }

// };
// for (int i = 0; i < listaDeContas.Length; i++)
// {
//     ContaCorrente contaAtual = listaDeContas[i];
//     Console.WriteLine($"Índice {i} - {contaAtual.Conta}");
// }

// TestaArrayDeContaCorrente();

// System.Console.WriteLine("Digite a senha:");

// int x = int.Parse(Console.ReadLine());
// while (x != 2002)
// {
//     System.Console.WriteLine("Digite a senha:");
//     x = int.Parse(Console.ReadLine());

// }
// System.Console.WriteLine("Senha correta");

// while ()
// {

// }

Console.Write("Quantos numeros deseja somar? ");
int n = int.Parse(Console.ReadLine());
int soma = 0;
for (int i = 1; i <= n; i++)
{
    Console.Write($"Valor #{i}: ");
    int valor = int.Parse(Console.ReadLine());
    soma += valor;

}
Console.Write($"Soma = {soma}");