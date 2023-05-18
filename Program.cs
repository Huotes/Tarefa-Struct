using Struct;

namespace TAD {

    class Program {
        
        static  void Main(string[] args)
        {
//--------------------------------US CLIENTE--------------------------------\\  
            Clientes cliente1 = new ();
            cliente1.nome = "athos";
            cliente1.cpf = "38970428860";
            cliente1.dataNascimento = "13/11/2004";
            cliente1.email = "athos@gmail.com";
            
            Console.WriteLine("--> CLIENTES");
            Console.WriteLine(cliente1.imprimir());

//--------------------------------US FUTEBOLISTAS--------------------------------\\
            Console.WriteLine("\n--> FUTEBOLISTAS");
            Futebolista Futebolista1 = new ();

            Futebolista1.nome = "athos";
            Futebolista1.cpf = "38970428860";
            Futebolista1.dataNascimento = "13/11/2004";
            Futebolista1.VinculoClube = "athos Bayer";
            Futebolista1.registrarNumeroCartoesAmarelos();
            Futebolista1.registrarNumeroCartoesVermelhos ();
            Console.WriteLine(Futebolista1.imprimir());
            Console.WriteLine(Futebolista1.verificarVinculoClube());

//--------------------------------US TIME--------------------------------\\           
            Console.WriteLine("\n--> EQUIPES");
            equipeEsports equipeEsports1 = new ();
            equipeEsports1.nome = "athos Bayer";
            equipeEsports1.campeonatosVencidos = 3;
            equipeEsports1.valorTotalPremiacoes = 1200;
            equipeEsports1.dataDeEstreiaEquipe = 2022;
            Console.WriteLine(equipeEsports1.imprimir());
            equipeEsports1.registrarCampeonatoVencido();
            equipeEsports1.atualizarValorTotalPremiacoes();
            Console.WriteLine(equipeEsports1.verificarAnoEstreia());
            
//--------------------------------US PRODUTO--------------------------------\\
            Console.WriteLine("\n--> PRODUTOS");
            Produto produto1 = new ();

            produto1.nome = "COCA";
            produto1.valor = 7;
            produto1.quantidadeEstoque = 200;
            System.Console.WriteLine(produto1.imprimir());
            System.Console.WriteLine("Deseja aplicar um cupom de desconto?");
            string decisaoAplicarCupom = Console.ReadLine();
            if (decisaoAplicarCupom == "sim"){
                System.Console.WriteLine("Deseja aplicar um desconto em Valor X ou em porcentagem?");
                string decisaoCupom = Console.ReadLine();
                if (decisaoCupom == "valor"){Console.WriteLine(produto1.aplicarCupomDescontoValor());}
                else if (decisaoCupom == "porcentagem"){Console.WriteLine(produto1.aplicarCupomDescontoPorcentagem());}
                else {System.Console.WriteLine("Operação não reconhecida!");}
            }

//--------------------------------US PROFESSOR--------------------------------\\
            Console.WriteLine("\n--> PROFESSOR");
            Professor professor1 = new ();

            professor1.nome = "athos";
            professor1.cpf = "38970428860";
            professor1.dataNascimento = "13/11/2004";
            professor1.email = "athos@gmail.com";
            professor1.salario = 1800;
            professor1.CargaHoraria = 50;
            System.Console.WriteLine(professor1.imprimir());
            System.Console.WriteLine("Deseja aplicar um reajuste salarial ao seu professor?");
            string decisaoAplicarReajuste = Console.ReadLine();
            if (decisaoAplicarReajuste == "sim"){
                System.Console.WriteLine("Deseja aplicar um desconto em Valor pré-definido ou em porcentagem?");
                string decisaoReajuste = Console.ReadLine();
                if (decisaoReajuste == "valor"){Console.WriteLine(professor1.reajusteSalarialEmValor());}
                else if (decisaoReajuste == "porcentagem"){Console.WriteLine(professor1.reajusteSalarialEmPorcentagem());}
                else {System.Console.WriteLine("Operação não identificada!");}
            System.Console.WriteLine("O professor possui alguma falta?");
            string decisaoFalta = Console.ReadLine();
            if (decisaoFalta == "sim"){
                System.Console.WriteLine("Digite a quantidade de faltas: ");
                professor1.faltas = Convert.ToInt32(Console.ReadLine());
                if (professor1.faltas > 0){System.Console.WriteLine("Deseja aplicar um desconto em Valor pré-definido ou em porcentagem?");
                decisaoReajuste = Console.ReadLine();
                if (decisaoReajuste == "valor"){Console.WriteLine(professor1.descontoSalarialPorFaltaEmValor());}
                else if (decisaoReajuste == "porcentagem"){Console.WriteLine(professor1.descontoSalarialPorFaltaEmPorcentagem());}
                else {System.Console.WriteLine("Operação não identificada!");}}
                else {System.Console.WriteLine("Nenhuma falta registrada!");}}
            System.Console.WriteLine("Deseja aumentar a carga horária do professor?");
            string decisaoAumentarCargaHoraria = Console.ReadLine();
            if (decisaoAumentarCargaHoraria == "sim"){Console.WriteLine(professor1.aumentarCargaHorariaDeTrabalho());}}}}}