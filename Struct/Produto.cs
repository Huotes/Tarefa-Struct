namespace Struct;

public struct Produto {
    public string nome;
    public int idProduto;
    public double valor;
    public int quantidadeEstoque;

    // COQUINHA GELADA HMMMMM
    public Produto(string nome, int idProduto, double valor, int quantidadeEstoque) {
        this.nome = nome;
        this.idProduto = idProduto;
        this.valor = valor;
        this.quantidadeEstoque = quantidadeEstoque;
    }

    public string aplicarCupomDescontoPorcentagem(){
        System.Console.WriteLine("\nDigite o valor de desconto do cupom (Em porcentagem)");
        int descontoPorcentagem = Convert.ToInt32(Console.ReadLine());
        double valorDescontado = (valor - ((valor * descontoPorcentagem) / 100));
        if (valorDescontado == null) {
            return ("Não fora descontado nenhum valor");
        }
        return ("O valor após o desconto foi: R$" + valorDescontado);
    }

    public string aplicarCupomDescontoValor(){
        System.Console.WriteLine("\nDigite o valor de desconto do cupom (Em Valor)");
        int descontoValor = Convert.ToInt32(Console.ReadLine());
        double valorDescontado = (valor - descontoValor);
        if (valorDescontado == null) {
            return ("Não fora descontado nenhum valor");
        }
        return ("O valor após o desconto foi: R$" + valorDescontado);
    }

    public string verificarQuantidadeEmEstoque() {
        return("\nA quantidade em estoque do produto '" +nome +"' é de: " +quantidadeEstoque + " Unidades" );
    }

    public string imprimir() {
        idProduto++;
        return "\nNome: " + this.nome + "\nId do Produto: " + this.idProduto + "\nValor do Produto: R$" + this.valor + "\nQuantidade disponível em Estoque: " + this.quantidadeEstoque;
    }
}