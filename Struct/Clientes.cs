namespace Struct;

public struct Clientes {
    public string nome;
    public string cpf;
    public string dataNascimento;
    public string email;

    // INFORMAÇÕES DUS TCHOLAS
    public Clientes(string nome, string cpf, string dataNascimento, string email) {
        this.nome = nome;
        this.cpf = cpf;
        this.dataNascimento = dataNascimento;
        this.email = email;
    }

    public string imprimir() {
        return "\nNome: " + this.nome + "\nCPF: " + this.cpf + "\nData Nascimento: " + this.dataNascimento + "\nEmail: " + this.email;}}