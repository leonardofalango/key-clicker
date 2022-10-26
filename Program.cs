char? en = null;
Player p1 = new Player();


while (en != 'x')
{
    Console.Clear();
    Console.WriteLine($"R${p1.Bonoros}  |   Key: {p1.ValorKey}");
    en = Console.ReadKey(true).KeyChar;
    // Console.WriteLine($"\n{en}\n");
    if (en == '1')
        p1.Loja();
    else
        p1.Click();
}