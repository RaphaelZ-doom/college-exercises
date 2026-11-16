namespace Exercicios.Algoritmos;

class PesquinaBinaria
{
    public int PesquinaBinariaa(int[] vetor, int alvo)
    {
        int inicio = 0;
        int Fim = vetor.Length - 1;

        while (inicio <= Fim)
        {
            int meio = 0;
            meio= (inicio + Fim) / 2;
            if (vetor[meio] == alvo)
                return meio;

            else if (alvo < vetor[meio])
            {
                Fim = meio - 1;

            }

            else if (alvo > vetor[meio])
            {
                inicio = meio + 1;
            }
        }
        return -1;
    }
}



