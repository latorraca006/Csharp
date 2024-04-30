using System;
// Interface representando um ataque
interface IAtacante {
    void Atacar();
}
public abstract class Heroi
{
    //Atributos da classe Heroi
    private string nome;
    private int vida;
    private string forca;
    private string agilidade;

    //Construto da classe Heroi 
    public Instrumentos ( string nome, int vida, string forca, string agilidade;) 
    {
        this.nome = nome;
        this.vida = vida;
        this.forca = forca;
        this.agilidade = agilidade;
        
    }

    // Getter para o nome
    public string GetNome(){
        return nome;
    }
    // Seter para o nome 
    public void SetNome(string nome){
        this.nome = nome;
    }
    // Getter para o vida
    public string GetVida(){
        return vida;
    }
    // Seter para o vida 
    public void SetVida(string vida){
        this.vida = vida;
    }
    // Getter para o forca
    public string GetForca(){
        return forca;
    }
    // Seter para o forca 
    public void SetForca(string forca){
        this.forca = forca;
    }
    // Getter para o agilidade
    public string GetAgilidade(){
        return agilidade;
    }
    // Seter para o agilidade 
    public void SetAgilidade(string agilidade){
        this.agilidade = agilidade;
    }
    public void SetAgilidade(string agilidade){
        this.agilidade = agilidade;
    }

// Classe Guerreiro implementando a interface IAtaque
class Guerreiro : IAtaque {
    public void Atacar() {
        Console.WriteLine("Guerreiro ataca com espada");
    }
}
// Classe Mago implementando a interface IAtaque
class Mago : IAtaque {
    public void Atacar() {
        Console.WriteLine("Mago lanca bola de fogo");
    }
}
// Classe Arqueiro implementando a interface IAtaque
class Arqueiro : IAtaque {
    public void Atacar() {
        Console.WriteLine("Arqueiro dispara flechas!");
    }
}
class Program{
    static void Main(string[] args) {
        // Criando instancias de diferentes personagens
    IAtaque guerreiro = new Guerreiro();
    IAtaque mago = new Mago();
    IAtaque arqueiro = new Arqueiro();

    // Chamando o metodo Atacar de cada personagens
    guerreiro.Atacar();
    mago.Atacar();
    arqueiro.Atacar();
    }

}