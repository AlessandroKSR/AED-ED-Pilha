
namespace OrdenacaoInterna.Projeto.Algoritmos;

public class Pilha
{
    private int[] item;
    private int topo;

    public Pilha(int maxTam)
    {
        this.item = new int[maxTam];
        this.topo = 0;
    }

    public bool vazia() { return topo == 0; }
    public bool cheia() { return topo == item.Length; }
    public int tamanho() { return topo; }
    public void empilha(int x)
    {
        if (cheia()) throw new Exception("Pilha cheia");
        item[topo++] = x;
    }
    public int desempilha()
    {
        if (vazia()) throw new Exception("Pilha vazia");
        return item[--topo];
    }
    public int consultaTopo()
    {
        if (vazia()) throw new Exception("Pilha vazia");
        return item[topo];
    }
    public void mostra()
    {
        if (vazia()) throw new Exception("Pilha vazia");

        Console.Write("[");
        while (!vazia())
        {
            Console.Write(desempilha() + ", ");
        }
        Console.Write("]");
    }
}