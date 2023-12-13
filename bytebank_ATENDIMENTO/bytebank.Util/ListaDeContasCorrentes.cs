using bytebank.Modelos.Conta;

namespace bytebank_ATENDIMENTO.bytebank.Util;

public class ListaDeContasCorrentes
{
    private ContaCorrente[] itens = null;
    private int _proximaPosicao = 0;
    public ListaDeContasCorrentes(int tamanhoInicial = 5)
    {
        itens = new ContaCorrente[tamanhoInicial];
    }
    public void Adicionar(ContaCorrente item)
    {
        System.Console.WriteLine($"Adicionando item na posição: {_proximaPosicao}");
        itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }
    private void VeririficarCapacidade(int tamanhoNecessario)
    {
        if (itens.Length >= tamanhoNecessario)
        {
            return;
        }

        Console.WriteLine("Aumentando a capacidade da lista:");
        ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];
        for (int i = 0; i < itens.Length; i++)
        {
            novoArray[i] = itens[i];
        }
        itens = novoArray;

    }
}
