namespace Exercicios.Algoritmos;


class PesquisaSequencial
{

    public int PesquisaSequenciaal(int[] vetor, int alvo)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == alvo)
                return i;

        }
        return -1;


    }

    public int PesquisaSequenciaalOrdenada(int[] vetor, int alvo)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == alvo)
                return i;
            else if (vetor[i] > alvo)
                return -1;
        }
        return -1;


    }
}