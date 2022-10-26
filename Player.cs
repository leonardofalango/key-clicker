public class Player
{
    public double Bonoros { get; private set; }
    public int ValorKey { get; private set; }
    public List<Upgrade> Upgrades {get; private set; }
    public Player()
    {
        this.Bonoros = 0d;
        this.ValorKey = 1;
        this.Upgrades = new List<Upgrade>();
        this.Upgrades.Add(new Funcionario());
        this.Upgrades.Add(new Esteira());
    }

    public bool BuyUpgrade(Upgrade u)
    {
        if (this.Bonoros >= u.Preco)
        {
            this.Bonoros -= u.Preco;
            this.ValorKey += u.AumentoKey;
            u.Compra();
            return true;
        }
        return false;
    }

    public void Loja()
    {
        Console.WriteLine("________LOJINHA________\n");
        for (int i = 0; i < Upgrades.Count; i++)
        {
            Upgrades[i].Print(i+1);
        }
        char x = Console.ReadKey().KeyChar;
        int compra = int.Parse(x.ToString()) - 1;
        if (!(compra >= Upgrades.Count || compra < 0))
        {
            if (this.BuyUpgrade(Upgrades[compra]))
                Console.WriteLine($"\n{Upgrades[compra].Nome} Comprado!\n\n");
            else
                Console.WriteLine("Você não possui dinheiro suficiente!");
        }
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey(true);

    }

    public void Click()
    {
        this.Bonoros += ValorKey;
    }

}