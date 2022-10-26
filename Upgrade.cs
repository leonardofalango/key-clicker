public abstract class Upgrade
{
    public int Quantidade { get; protected set; }
    public double Preco { get; protected set; }
    public int AumentoKey { get; protected set; }
    public string Nome { get; set; }

    public virtual void Compra()
    {
        this.Preco = this.Preco * 1.1;
        this.Quantidade++;
    }

    public virtual void Print(int escolha)
    {
        Console.WriteLine("--------------");
        Console.WriteLine($"-> {this.Nome} <-                       #{this.Quantidade}");
        Console.WriteLine($"Codigo de compra: {escolha}");
        Console.WriteLine($"R${this.Preco}");
        Console.WriteLine($"+{this.AumentoKey}");
    }
}