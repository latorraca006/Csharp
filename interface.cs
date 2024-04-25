using System;
// Interface representando um ataque
interface IAtaque {
    void Atacar();
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



