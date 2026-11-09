using System.Net;

namespace Exercicios.Estruturas;

class ListaSimplesmenteEncadeada
{
    class No
    {
        public int valor;
        public No proximo = null;

    }

    class LinkedList
    {
        No Head = null;

        public void Adicionar(int valorNovo)
        {
            No vagao = new No();
            vagao.valor = valorNovo;
            if (Head == null)
            {
                Head = vagao;
            }
            else
            {
                No atual = Head;
                while (atual.proximo != null)
                {
                    atual = atual.proximo;
                }
                atual.proximo = vagao;
            }

        }

        public void Remover(int ValorParaRemover)
        {
            if (Head == null) return;
            if (Head.valor == ValorParaRemover)
            {
                
                Head = Head.proximo;
                return;
            }
            No anterior = null;
            No atual = Head;

            while (atual != null)
            {
                if (atual.valor == ValorParaRemover)
                {
                    anterior.proximo = atual.proximo;
                    
                    return;
                }
                anterior = atual;
                atual = atual.proximo;
            }


        }

        public bool Buscar(int  value)
        {
            No procurando = Head;
            while (procurando != null)
            {
                if (procurando.valor == value)
                    return true;
                else
                    procurando = procurando.proximo;
                    
            }
            return false;
        }
    }
}