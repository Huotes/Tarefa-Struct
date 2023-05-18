namespace Struct;

public struct jogadorFutebol {
    public string nome;
    public string cpf;
    public string dataNascimento;
    public int numeroCartoesAmarelos;
    public int numeroCartoesVermelhos;
    public string VinculoClube;

    // U BOLEIRO DO MAL
    public jogadorFutebol(string nome, string cpf, string dataNascimento, int numeroCartoesAmarelos, int numeroCartoesVermelhos, string VinculoClube) {
        this.nome = nome;
        this.cpf = cpf;
        this.dataNascimento = dataNascimento;
        this.numeroCartoesAmarelos = numeroCartoesAmarelos;
        this.numeroCartoesVermelhos = numeroCartoesVermelhos;
        this.VinculoClube = VinculoClube;
    }
    public void registrarNumeroCartoesAmarelos(){
        this.numeroCartoesAmarelos++;
    }
    public void registrarNumeroCartoesVermelhos(){
        this.numeroCartoesVermelhos++;
    }
    public Boolean verificarVinculoClube(){
        if(this.VinculoClube == null){return false;}
        else {return true;}}

    public string imprimir() {
        return "\nNome: " + this.nome + "\nCPF: " + this.cpf + "\nData Nascimento: " + this.dataNascimento + "\nNúmero de Cartões amarelos: " + this.numeroCartoesAmarelos + "\nNúmero de cartões vermelhos: " + this.numeroCartoesVermelhos + "\nVinculo Clube: " + this.VinculoClube;
    }
}