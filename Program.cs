namespace OrdenacaoInterna;

using OrdenacaoInterna.Projeto.Algoritmos;

class Program
{
    static void Main(string[] args)
    {

        // Pilha p = new Pilha(5);
        // p.empilha(1); p.empilha(3); p.empilha(5); p.empilha(7);
        // p.mostra(); // [1, 3, 5, 7]
        // Console.WriteLine(p.desempilha()); // 7
        // Console.WriteLine(p.consultaTopo()); // 5
        // p.empilha(8); p.empilha(9);
        // p.mostra(); // [1, 3, 5, 8, 9]
        // Console.WriteLine(p.cheia()); // True
        // try { p.empilha(2); }
        // catch (Exception e) { Console.WriteLine(e.Message); } // Erro: pilha cheia

        // Pilha pilha = new Pilha(4);

        // pilha.empilha(10);
        // pilha.mostra();
        // Console.WriteLine(pilha.consultaTopo());

        // pilha.empilha(20);
        // pilha.mostra();
        // Console.WriteLine(pilha.consultaTopo());

        // Console.WriteLine(pilha.desempilha());
        // pilha.mostra();
        // Console.WriteLine(pilha.consultaTopo());

        // pilha.empilha(30);
        // pilha.mostra();
        // Console.WriteLine(pilha.consultaTopo());

        // pilha.empilha(40);
        // pilha.mostra();
        // Console.WriteLine(pilha.consultaTopo());

        // Console.WriteLine(pilha.desempilha());
        // pilha.mostra();
        // Console.WriteLine(pilha.consultaTopo());

        // Console.WriteLine(pilha.desempilha());
        // pilha.mostra();
        // Console.WriteLine(pilha.consultaTopo());

        // pilha.empilha(50);
        // pilha.mostra();
        // Console.WriteLine(pilha.consultaTopo());

        // Console.WriteLine(pilha.item[2]);

        // Console.WriteLine(Pilha.inverte("PUCMINAS"));

        int[] a = Pilha.bubblePilhas(new int[] { 15, 2, 9, 1, 7 }, out int c1);
        Console.WriteLine($"[{string.Join(", ", a)}] comparações: {c1}");

        int[] b = Pilha.bubblePilhas(new int[] { 1, 2, 3, 4, 5 }, out int c2);
        Console.WriteLine($"[{string.Join(", ", b)}] comparações: {c2}");

        // Pilha pilha = new Pilha(5);

        // pilha.empilha(50);
        // pilha.empilha(40);
        // pilha.empilha(30);
        // pilha.empilha(20);
        // pilha.empilha(10);

        // pilha.mostra();

        // pilha = Pilha.ordenaPilha(pilha);

        // pilha.mostra();
    }
}
