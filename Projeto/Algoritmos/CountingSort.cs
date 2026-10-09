using OrdenacaoInterna.Projeto.Models;

namespace OrdenacaoInterna.Projeto.Algoritmos;

public static class CountingSort {
   public static int[] Executar(int[] array)
{
    if (array == null || array.Length <= 1)
    {
        return array;
    }

    int n = array.Length;

    // Encontra o maior elemento do array para definir o tamanho do vetor de contagem
    int maior = array[0];
    for (int i = 1; i < n; i++)
    {
        if (array[i] > maior)
        {
            maior = array[i];
        }
    }

    // 1. Array para contar o número de ocorrências de cada elemento[cite: 1]
    int[] count = new int[maior + 1];
    int[] ordenado = new int[n];

    // 2. Inicializar cada posição do array de contagem com zero[cite: 1]
    for (int i = 0; i < count.Length; i++)
    {
        count[i] = 0;
    }

    // 3. Agora, o count[i] contém o número de elementos iguais a i[cite: 1]
    for (int i = 0; i < n; i++)
    {
        count[array[i]]++;
    }

    // 4. Agora, o count[i] contém o número de elementos menores ou iguais a i[cite: 1]
    for (int i = 1; i < count.Length; i++)
    {
        count[i] += count[i - 1];
    }

    // 5. Ordenando (preenchendo o array de saída de trás para frente)[cite: 1]
    for (int i = n - 1; i >= 0; i--)
    {
        ordenado[count[array[i]] - 1] = array[i];
        count[array[i]]--;
    }

    // Retorna o array ordenado conforme a assinatura solicitada
    return ordenado;
}
}