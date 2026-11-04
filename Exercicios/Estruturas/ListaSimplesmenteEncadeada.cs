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

        public void Remover()
        {

        }

        public void Buscar()
        {

        }
    }
}