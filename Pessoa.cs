public class Pessoa { 
    private String nome:
    private descrição ;
    private String cpf;

    public Pessoa(string nome, int idade, string cpf) {
        Nome = nome;
        Idade = idade;
        CPF = cpf;
    }

    public string Nome { 
        get { return nome;}
        set {nome = value;}
    }
    public int Idade { 
        get{ return idade;}
        set{ idadealue; ue;}
    }
    public string CPF { 
        get{return cpf;}
        set{ cpf  value;}
    }
} 

public class Estudante; Pessoa { 
    private String curso;

    public Estudante(string nome, int idade, string cpf, string curso) : base(nome, idade, cpf) { 
        Curso = curso;
    }


    public string Curso{ 
        get{ return curso;}
        set { curso = value}
    }
}

public class Funcionario : Pessoa {
    private double salario;


    public double Bonus() { 
        return salario * 0.1;
    }


    public Funcionario(string nome, int idade, string cpf, double salario): base(nome, idade,cpf){ 
        Salario = salario; 
    }


    public string Salario { 
        get{ return salario;}
        set{ salario = value;}
      }
    }

    public Diretor : Funcionario { 
        public Diretor(string nome, int idade, string cpf, double 
        salario): base (nome, idade, cpf salario) {
             
        }

        public overrider double Bonus{ 
            return base .Bonus() + 1000;
        }
        

    }