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
    public int tamanho() { return topo;}
    public void empilha(int x) { /* ... */ }
    public int desempilha() { /* ... */ }
    public int consultaTopo() { /* devolve o topo SEM remover */ }
    public void mostra() { /* imprime base -> topo, ex.: [1, 3, 5] */ }
}