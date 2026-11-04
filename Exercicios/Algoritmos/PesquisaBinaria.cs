namespace Exercicios.Algoritmos;

class PesquisaBinaria{
    public int PesquisaBinaaria(int[] array, int alvo)
    {
        int baixo = 0;
        int alto = array.Length - 1;
        while (baixo <= alto)
        {
            int meio = (alto - baixo) / 2 + baixo;
            int chute = array[meio];

            if (chute == alvo)
                return meio;
            if (chute > alvo)
                alto = meio - 1;
            else
                baixo = meio + 1;
        }
        return -1;
    }

    public int BuscaMenor(int[] Array, int contagem)
    {
        int menor = Array[contagem];
        int menor_indice = contagem;
        for (int i = contagem; i < Array.Length; i++)
        {
            if (Array[i] < menor)
            {
                menor = Array[i];
                menor_indice = i;
            }
        }
        return menor_indice;
    }
}