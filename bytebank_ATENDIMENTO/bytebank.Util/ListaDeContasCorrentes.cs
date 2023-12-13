using bytebank.Modelos.Conta;

namespace bytebank_ATENDIMENTO.bytebank.Util;

public class ListaDeContasCorrentes
{
    private ContaCorrente[] itens;
    private int _proximaPosicao = 0;
    public ListaDeContasCorrentes(int tamanhoInicial = 5)
    {
        itens = new ContaCorrente[tamanhoInicial];
    }
    public void Adicionar(ContaCorrente item)
    {
        Console.WriteLine($"Adicionando item na posição: {_proximaPosicao}");

        // ListaSaldo(_proximaPosicao);
        VerificarCapacidade(_proximaPosicao + 1);
        itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }
    private void VerificarCapacidade(int tamanhoNecessario)
    {
        if (itens.Length >= tamanhoNecessario)
        {
            return;
        }

        Console.WriteLine("Aumentando a capacidade da lista");
        ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];
        for (int i = 0; i < itens.Length; i++)
        {
            novoArray[i] = itens[i];
        }
        itens = novoArray;
    }
    // private void ListaSaldo()

    // {

    //     for (int i = 0; itens.Length > 0; i++)
    //     {
    //         System.Console.WriteLine(itens[i]);
    //     }


    // }
}
