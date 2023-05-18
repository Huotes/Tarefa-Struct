namespace Struct;

public struct Professor{
    public string nome;
    public string cpf;
    public string dataNascimento;
    public string email;
    public double salario;
    public int faltas;
    public int parametroDescontoFaltas;
    public int CargaHoraria;

    // AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA PROFESSOR.
    public Professor(string nome, string cpf, string dataNascimento, string email, double salario, int faltas, int parametroDescontoFaltas, int CargaHoraria) {
        this.nome = nome;
        this.cpf = cpf;
        this.dataNascimento = dataNascimento;
        this.email = email;
        this.salario = salario;
        this.faltas = faltas;
        this.parametroDescontoFaltas = parametroDescontoFaltas;
        this.CargaHoraria = CargaHoraria;
    }
        public string reajusteSalarialEmPorcentagem(){
        System.Console.WriteLine("\nDigite o valor de desconto do salário (Em porcentagem)");
        int descontoPorcentagem = Convert.ToInt32(Console.ReadLine());
        double valorDescontado = (salario + ((salario * descontoPorcentagem) / 100));
        return ("O valor após o reajuste foi: R$" + valorDescontado);}
    public string reajusteSalarialEmValor(){
        System.Console.WriteLine("\nDigite o valor de desconto do salário (Em Valor)");
        int descontoValor = Convert.ToInt32(Console.ReadLine());
        double valorDescontado = (salario + descontoValor);
        return ("O valor após o reajuste foi: R$" + valorDescontado);}
    public string descontoSalarialPorFaltaEmValor(){
        Console.WriteLine("Qual valor deve ser descontado do salário de um professor a cada falta cometida pelo mesmo?");
        parametroDescontoFaltas = Convert.ToInt32(Console.ReadLine());
        if (faltas > 0);{double salarioDescontado = salario - (parametroDescontoFaltas * faltas);
            return ("O salário após o desconto de faltas ficou: R$" +salarioDescontado);}}
        public string descontoSalarialPorFaltaEmPorcentagem(){
        Console.WriteLine("Qual valor deve ser descontado do salário de um professor a cada falta cometida pelo mesmo?");
        parametroDescontoFaltas = Convert.ToInt32(Console.ReadLine());
        if (faltas > 0){
            double salarioDescontado = salario - ((100 / (parametroDescontoFaltas)) * faltas);
            return ("O salário após o desconto de faltas ficou: R$" +salarioDescontado);}
        return ("Esse professor não possuiu nenhuma falta!");}
        public string aumentarCargaHorariaDeTrabalho(){
            System.Console.WriteLine("Qual deve ser o valor a ser aumentado na carga horária deste professor?");
            int valorAcrescimoCargaHoraria = Convert.ToInt32(Console.ReadLine());
            CargaHoraria = CargaHoraria + valorAcrescimoCargaHoraria;
            return ("A carga horária atualizada é: " +CargaHoraria);}
    
    public string imprimir() {return "\nNome: " + this.nome + "\nCPF: " + this.cpf + "\nData Nascimento: " + this.dataNascimento + "\nEmail: " + this.email + "\nSalário: " + this.salario + "\nCarga horária: " + this.CargaHoraria;}}