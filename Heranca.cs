public class Produto  { 
    private string nome:
    private decimal preco;
    private string descricao;
    private string categoria; 


    public Produto (string nome, decimal preco, string descricao, string categoria) {
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
    }

    public string Nome { 
        get { return nome;}
        set {nome = value;}
    }
    public int Preco { 
        get{ return preco;}
        set{ preco = value;}
    }
    public string Descricao { 
        get{return descricao;}
        set{ descricao =  value;}
    }
    public string Categoria { 
        get{return categoria;}
        set{ categoria =  value;}
    }
} 

public class ConsoleGame: Produto { 
    private int capacidadeArmazenamento;

    public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int capacidadeArmazenamento) : base(nome, preco, descricao,categoria ) { 
        this.capacidadeArmazenamento = capacidadeArmazenamento;
    }


    public string CapacidadeArmazenamento{ 
        get{ return capacidadeArmazenamento;}
        set { capacidadeArmazenamento = value;}
    }
}

public class Jogo : Produto {
    private string genero;

    public Jogo(string nome, decimal preco, string descricao, string categoria, string genero): base(nome, preco,descricao, categoria){ 
        this.genero = genero; 
    }

    public string Genero { 
        get{ return genero;}
        set { genero = value;}
    }


}
public class Acessorio : Produto {
    private string tipo;

    public Acessorio(string nome, decimal preco, string descricao, string categoria, string tipo): base(nome, preco,descricao, categoria){ 
        this.tipo = tipo; 
    }

    public string Tipo { 
        get{ return tipo;}
        set { tipo = value;}
    }


}
public class Colecionavel : EdicaoLimitada {
    private bool edicaoLimitada;

    public Colecionavel(string nome, decimal preco, string descricao, string categoria, string edicaoLimitada): base(nome, preco,descricao, categoria){ 
        this.edicaoLimitada = edicaoLimitada; 
    }

    public string EdicaoLimitada { 
        get{ return edicaoLimitada;}
        set { edicaoLimitada = value;}
    }
}

public class Progam { 
    public static void main (String[] args) { 

        Produto produto;
        produto = new ConsoleGame("PlayStation 5", 5.900, "Console de Video Game PlayStation 5 Slim com 1 Tera de armazenamento", "Console", 1024000);

        Jogo jogo = new Jogo("Marvel's Spider-Man 2 PREMIUM", 299;9,"Jogo completo Marvel's Spider-Man 2 para PS5:", "Jogo PS5", "Ação e Aventura");

        Acessorio acessorio = new Acessorio("Fone de Ouvido sem Fio", 199.99, "Fone de ouvido estéreo com conexão Bluetooth", "Eletrônicos", "Fone de Ouvido");

        Colecionavel colecionavel = new Colecionavel("Action Figure Mario", 79.99m, "Action Figure colecionável do personagem Mario", "Brinquedos", true);


    }
}