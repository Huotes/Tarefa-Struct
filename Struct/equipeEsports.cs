namespace Struct;

public struct equipeEsports {
    public string nome;
    public int campeonatosGanhos;
    public int valorTotalPremiacoes;
    public int dataDeEstreiaEquipe;

    // INFORMAÇÕES DOS BOLEIROS
    public equipeEsports(string nome, int campeonatosGanhos, int valorTotalPremiacoes, int dataDeEstreiaEquipe) {
        this.nome = nome;
        this.campeonatosGanhos = campeonatosGanhos;
        this.valorTotalPremiacoes = valorTotalPremiacoes;
        this.dataDeEstreiaEquipe = dataDeEstreiaEquipe;
    }


    public void registrarCampeonatoVencido(){
        this.campeonatosGanhos++;
        Console.WriteLine ("\nQual o valor que a equipe recebeu pelo vencimento do campeonato? ");
        int valorPremiacao = Convert.ToInt32(Console.ReadLine());
        this.valorTotalPremiacoes += valorPremiacao;
    }

    public void atualizarValorTotalPremiacoes(){
        Console.WriteLine("\nO valor de todas as premiações é: " + valorTotalPremiacoes);
    }

    public string verificarAnoEstreia(){
        DateTime dataatual = DateTime.Now;
        // ANU
        int ano = dataatual.Year;

        if (this.dataDeEstreiaEquipe == ano ){return("Equipe Nutella"); }else {return("Equipe raiz");}}
    
    public string imprimir() {
        return "\nNome: " + this.nome + "\nCampeonatos Ganhos: " + this.campeonatosGanhos + "\nValor total de premiações da equipe: " + this.valorTotalPremiacoes + "\nData de estreia da equipe: " + this.dataDeEstreiaEquipe;}
}