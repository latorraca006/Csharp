using System;

public abstract class Instrumentos
{
    //Atributos da classe Instrumentos
    private string nome;
    private int cordas;
    private string som;
    private string afinadores;

    //Construto da classe Instrumentos 
    public Instrumentos ( string nome, int cordas, string som, string afinadores;) 
    {
        this.nome = nome;
        this.cordas = cordas;
        this.som = som;
        this.afinadores = afinadores;
        
    }

    // Getter para o nome
    public string GetNome(){
        return nome;
    }
    // Seter para o nome 
    public void SetNome(string nome){
        this.nome = nome;
    }
    // Getter para o cordas
    public string GetCordas(){
        return cordas;
    }
    // Seter para o cordas 
    public void SetCordas(string cordas){
        this.cordas = cordas;
    }
    // Getter para o som
    public string GetSom(){
        return som;
    }
    // Seter para o nome 
    public void SetSom(string som){
        this.som = som;
    }
    // Getter para o afinadores
    public string GetAfinadores(){
        return afinadores;
    }
    // Seter para o afinadores 
    public void SetAfinadores(string afinadores){
        this.afinadores = afinadores;
    }
    public void SetCor(string cor){
        this.cor = cor;
    }
    public abstract void Nome(); //Método abstrato
    public abstract void Cordas(); //Método abstrato
    public abstract void Som(); //Método abstrato
    public abstract void Afinadores(); //Método abstrato    
}

public class Piano : Instrumentos {
    private bool som;
    public piano(string nome, double madeira, string metais, string cor, bool tecidos) : base(nome, madeira, metais, cor){
        this.som = som
    }
    public string GetSom(){
        return som;
    }
    // Seter para o cor 
    public void SetSom(bool Som){
        this.som = som;
    }
    public abstract void tocar(){
        Console.WriteLine($"{GetNome()} tocou!");   
    }
    public abstract void Ligar(){
        Console.WriteLine($"{GetNome()} ligou!");   
    }
    public abstract void Desligar(){
        Console.WriteLine($"{GetNome()} desligou!");   
    }
    public abstract void parar(){
        Console.WriteLine($"{GetNome()} parou!");   
    } 
}
public class Violino : Instrumentos {
    private bool arco;
    public Violino(string nome, double microafinadores, string espaleira, string cor, bool arco) : base(nome, microafinadores, espaleira, cor){
        this.arco = arco
    }
    public string GetArco(){
        return arco;
    }
    // Seter para o cor 
    public void SetArco(bool arco){
        this.arco = arco;
    }
    public abstract void tocar(){
        Console.WriteLine($"{GetNome()} tocou!");   
    }
    public abstract void Ligar(){
        Console.WriteLine($"{GetNome()} ligou!");   
    }
    public abstract void Desligar(){
        Console.WriteLine($"{GetNome()} desligou!");   
    }
    public abstract void parar(){
        Console.WriteLine($"{GetNome()} parou!");   
    } 
}
class Program
{
    static void Main(string[] args)
    {
        Piano piano = new Piano("Cauda", 4.0, "2024", "branco", true);
        piano.tocar();
        piano.Mover();
        piano.parar();
        piano.Desligar();

        Violino violino = new Violino("acústico", 300, "2024", "preta", true);
        violino.tocar();
        Violino.Mover();
        Violino.parar();
        Violino.Desligar();           

    }
}