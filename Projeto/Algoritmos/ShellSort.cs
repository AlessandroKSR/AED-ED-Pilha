using OrdenacaoInterna.Projeto.Models;

namespace OrdenacaoInterna.Projeto.Algoritmos;


public static class ShellSort
{
public static int[] Executar(int[] vetor)
    {
        int n = vetor.Length;
        int h = 1;

        // 1. Calcula o incremento inicial (h) utilizando a sequência de Knuth: h = 3*h + 1
        while (h < n / 3)
        {
            h = 3 * h + 1;
        }

        // 2. Loop principal de redução do incremento h até que ele chegue a 0
        while (h > 0)
        {
            // 3. Aplica o Insertion Sort para cada pseudo-array espaçado por 'h'
            for (int i = h; i < n; i++)
            {
                int tmp = vetor[i];
                int j = i;

                // Desloca os elementos maiores para a direita dentro do pseudo-array
                while (j >= h && vetor[j - h] > tmp)
                {
                    vetor[j] = vetor[j - h];
                    j -= h;
                }

                vetor[j] = tmp;
            }

            // Reduz o h para o próximo passo da sequência (ex: de 4 para 1)
            h /= 3;
        }

        return vetor;
    }
}