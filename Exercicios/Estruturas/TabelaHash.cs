using System.ComponentModel;
using System.Reflection.Metadata;

namespace Exercicios.Estruturas;


class NoHash
{
    public string chave;
    public int valor;
    public NoHash proximo = null;
}

class TabelaHash
{
    private NoHash[] buckets;
    private int tamanho;

    public TabelaHash(int tamanho)
    {
        this.tamanho = tamanho;
        this.buckets = new NoHash[tamanho];
    }


    private int FuncaoHash(string chave)
    {
        return Math.Abs(chave.GetHashCode()) % tamanho;

    }


    public void inserir(string chave, int valor)
    {
        int indice = FuncaoHash(chave);
        NoHash novoNo = new NoHash();
        novoNo.chave = chave;
        novoNo.valor = valor;
        if (buckets[indice] == null)
        {
            buckets[indice] = novoNo;
            
        }
        else if (buckets[indice] != null)
        {

            NoHash atual = buckets[indice];
            while ( atual.proximo != null)
            {
             
               atual = atual.proximo;
            }
            atual.proximo = novoNo;
        }
    }

    public int Buscar (string chave )
    {
        int indice = FuncaoHash(chave);
        NoHash atual = buckets[indice];
        while ( atual != null)
        {
            if (atual.chave == chave)
            return atual.valor;
            else
            {
                atual = atual.proximo;
            }
        }
        return -1;
        
    }
}

