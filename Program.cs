namespace OrdenacaoInterna;

using OrdenacaoInterna.Projeto.Algoritmos;
using OrdenacaoInterna.Projeto.Models;
using OrdenacaoInterna.Projeto.Utils;

class Program
{
    static void Main(string[] args)
    {
                
        TipoVetor tipoVetor = (TipoVetor)3;
        int[] vetor = GeradorVetores.Gerar(10,  tipoVetor);
       
        Impressao.ExibirVetor(vetor);
        vetor = BubleSort.Executar(vetor);

        Impressao.ExibirVetor(vetor);

        
    }
}
