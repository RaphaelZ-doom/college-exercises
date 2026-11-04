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

   
}