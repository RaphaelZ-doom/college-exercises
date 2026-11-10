using System.Data.Common;
using System.Runtime.CompilerServices;

namespace Exercicios.Estruturas;


class No
{
    public int valor;
    public No anterior = null;
    public No proximo = null;

}


class ListaDuplamenteEncadeada
{
    No head = null;

    public void Inserir(int valorNovo)
    {
        No vagao = new No();
        vagao.valor = valorNovo;
        if (head == null)
        {
            head = vagao;
        }
        else
        {
            No atual = head;
            while (atual.proximo != null)
            {
                atual = atual.proximo;
            }
            atual.proximo = vagao;
            vagao.anterior = atual;
        }

    }

    public void remover(int ValoraRemover)
    {
        No AtualParaRemover = head;
        if (head == null) return;

        if (head.valor == ValoraRemover)
        {
            AtualParaRemover = head.proximo;
            if (head == null)
            {
                return;
            }
            head.anterior = null;
        }
        while (AtualParaRemover != null)
        {
            if (AtualParaRemover.valor == ValoraRemover)
            {
                AtualParaRemover.anterior.proximo = AtualParaRemover.proximo;
                if (AtualParaRemover.proximo != null)
                {
                     AtualParaRemover.proximo.anterior = AtualParaRemover;
                }
         
            }
            AtualParaRemover = AtualParaRemover.proximo;
        }
        
    }

    public bool buscar(int valor)
    {
        No Procurando = head;
        while (Procurando != null)
        {
            if (Procurando.valor == valor)
                return true;

            Procurando = Procurando.proximo;

        }
        return false;

    }
}