namespace Exercicios.Algoritmos;

class OrdenaçãoPorSeleção
{
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

    public void OrdenaaçãoPorSeleção(int[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            int indice_do_menor = BuscaMenor(Array, i);
            int temp = Array[i];
            Array[i] = Array[indice_do_menor];
            Array[indice_do_menor] = temp;
        }
    }
}