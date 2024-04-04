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
    private string Tipo;

    public Acessorio(string nome, decimal preco, string descricao, string categoria, string tipo): base(nome, preco,descricao, categoria){ 
        this.tipo = tipo; 
    }

    public string Tipo { 
        get{ return tipo;}
        set { tipo = value;}
    }


}
public class Colecionavel : EdicaoLimitada {
    private string edicaoLimitada;

    public Colecionavel(string nome, decimal preco, string descricao, string categoria, string edicaoLimitada): base(nome, preco,descricao, categoria){ 
        this.edicaoLimitada = edicaoLimitada; 
    }

    public string edicaoLimitada { 
        get{ return edicaoLimitada;}
        set { edicaoLimitada = value;}
    }


}