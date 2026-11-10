namespace Exercicios.Estruturas;


class Fila
{
    class No
    {
        public int valor;

        public No proximo = null;
        public No(int valor) { this.valor = valor; }
    }
    No Inicio = null;
    No Fim = null;

    public void enqueue(int valor)
    {
        No ObjetoNaFila = new No(valor);
        if (Inicio == null && Fim == null)
        {
            Inicio = ObjetoNaFila;
            Fim = ObjetoNaFila;
        }
        else
        {
            Fim.proximo = ObjetoNaFila;
            Fim = ObjetoNaFila;
        }

    }

    public void Dequeue()
    {
        if (Inicio == null) return;
        else if (Inicio != null && Fim == Inicio)
        {
             Inicio = null;
             Fim = null;

    
        }
        else 
          Inicio = Inicio.proximo;
    }
}