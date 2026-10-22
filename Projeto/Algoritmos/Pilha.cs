
namespace OrdenacaoInterna.Projeto.Algoritmos;

public class Pilha
{
    public int[] item;
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
        item[this.topo++] = x;
    }
    public int desempilha()
    {
        if (vazia()) throw new Exception("Pilha vazia");
        return item[--this.topo];
    }
    public int consultaTopo()
    {
        if (vazia()) throw new Exception("Pilha vazia");
        return item[topo - 1];
    }
    public void mostra()
    {
        if (vazia()) throw new Exception("Pilha vazia");

        Console.Write("[");
        for (int i = 0; i < topo; i++)
        {
            if (i < topo - 1) Console.Write(item[i] + ", ");
            else Console.Write(item[i]);
        }
        Console.WriteLine("]");
    }

    public static string inverte(string s)
    {
        Pilha pilha = new Pilha(s.Length);
        char[] sInvertido = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            pilha.empilha(s[i]);
        }
        for (int i = 0; i < s.Length; i++)
        {
            sInvertido[i] = (char)pilha.desempilha();
        }

        string retorno = new string(sInvertido);
        return retorno;
    }

    public static int[] bubblePilhas(int[] v, out int comparacoes)
    {
        comparacoes = 0;
        int n = v.Length;

        Pilha A = new Pilha(n);
        Pilha B = new Pilha(n);
        Pilha R = new Pilha(n);

        for (int i = 0; i < n; i++) A.empilha(v[i]);

        for (int restantes = n; restantes >= 1; restantes--)
        {
            int carry = A.desempilha();

            for (int k = 0; k < restantes - 1; k++)
            {
                int x = A.desempilha();
                comparacoes++;

                if (carry > x)
                {
                    B.empilha(x);
                }
                else
                {
                    B.empilha(carry);
                    carry = x;
                }
            }

            R.empilha(carry);
            Pilha temp = A;
            A = B;
            B = temp;
        }

        int[] ordenado = new int[n];
        for (int i = 0; i < n; i++) ordenado[i] = R.desempilha();

        return ordenado;
    }

    public static Pilha ordenaPilha(Pilha p)
    {
        Pilha aux = new Pilha(p.tamanho());

        while (!p.vazia())
        {
            int t = p.desempilha();

            while (!aux.vazia() && aux.consultaTopo() > t)
                p.empilha(aux.desempilha());

            aux.empilha(t);
        }

        return aux;
    }
}