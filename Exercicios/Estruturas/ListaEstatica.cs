namespace Exercicios.Estruturas;

class ListaEstática
{
    int quantidadeMAX;
    public ListaEstática    (int quantidade)
    {
        this.quantidadeMAX = quantidade;
        array = new int[quantidadeMAX];
    }
    int[] array;
    int TamanhoATUAL;

    public bool TamanhoCheio()
    {
        if (TamanhoATUAL == quantidadeMAX)
        {
            return true;
        }
        else
            return false;
    }

    public void Inserir(int Elemento)
    {
        if (TamanhoCheio() == false)
        {
            array[TamanhoATUAL] = Elemento;
            TamanhoATUAL++;
        }
        else
            throw new Exception("cheio");
    }

    public void Remover(int indice)
    {
        if (indice >= 0 && indice < TamanhoATUAL)
        {
            for (int i = indice; i < TamanhoATUAL - 1; i++)
            {
                array[i] = array[i + 1];
            }
            TamanhoATUAL--;
        }
        else
            throw new Exception("Não há itens para remover");

    }

    public void Exibir()
    {
        for (int i = 0; i < TamanhoATUAL; i++)
        {
            Console.WriteLine($"{array[i]}, ");
        }
        Console.WriteLine();
    }
}