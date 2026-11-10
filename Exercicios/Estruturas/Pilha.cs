using System.ComponentModel;

namespace Exercicios.Estruturas;

class Pilha
{
    class No
    {
        public int valor;

        public No proximo = null;

        public No(int carga)
        {
            valor = carga;
        }
    }
    No Topo = null;

    public void Push(int ValorNovo)
    {
        No prato = new No(ValorNovo);
        prato.proximo = Topo;
        Topo = prato;

    }

    public void Pop()
    {
        if (Topo == null)
            return;
        else
        {
            Topo = Topo.proximo;  
        }
    }

    public int peek()
    {
        if (Topo == null)
        return -1;
        else 
        return Topo.valor;
      
    }
}
