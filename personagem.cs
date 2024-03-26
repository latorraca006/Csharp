// Classe base representando um funcionário genérico
public class Funcionario
{
    // Atributos encapsulados
    private string nome;
    private int idade;

    // Método construtor para inicializar o nome e a idade do funcionário
    public Funcionario(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    // Propriedades públicas para acessar os atributos encapsulados
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    // Método público que simula o trabalho do funcionário
    public void Trabalhar()
    {
        Console.WriteLine($"{nome} está trabalhando.");
    }
}

// Classe derivada representando um funcionário específico, por exemplo, um Desenvolvedor
public class Desenvolvedor : Funcionario
{
    // Método construtor que chama o construtor da classe base para inicializar o nome e a idade do desenvolvedor
    public Desenvolvedor(string nome, int idade) : base(nome, idade)
    {
    }

    // Método específico para desenvolvedores que simula escrever código
    public void EscreverCodigo()
    {
        Console.WriteLine($"{Nome} está escrevendo código.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto representando um desenvolvedor
        Desenvolvedor desenvolvedor = new Desenvolvedor("João", 30);

        // Chamando métodos da classe base e da classe derivada
        desenvolvedor.Trabalhar();
        desenvolvedor.EscreverCodigo();

        // Exibindo informações sobre o desenvolvedor
        Console.WriteLine($"Nome: {desenvolvedor.Nome}, Idade: {desenvolvedor.Idade}");
    }
}