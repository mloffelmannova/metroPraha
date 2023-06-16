
using metroPraha;
using System.ComponentModel.DataAnnotations;

while (true) //nekonečný cyklus
{
    Console.ForegroundColor = ConsoleColor.Cyan; //barvičkyyyy
    Console.WriteLine("Vítej člověče, zde vidíš stanice metra A,B,C a budoucí stanici D");

    string[] staniceA =
    {
        "Depo Hostivař", "Skalka", "Strašnická", "Želivského", "Flora", "Jiřího z Poděbrad", "Náměstí Míru", "Muzeum", "Můstek",
        "Staroměstská", "Malostranská", "Hradčanská", "Dejvická", "Bořislavka", "Nádraží Veleslavín", "Petřiny", "Nemocnice Motol"
    };
    //linka A

    string[] staniceB =
    {
        "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jironice, Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí",
        "Národní třída", "Můstek", "Náměstí Republiky", "FLorenc", "Křižíkova", "Invalidova", "Palmovka", "Českomoravská", "Vysočanská", "Kolbenova",
        "Hloubětín", "Rajská zahrada", "Černý Most"
    };
    //linka B

    string[] staniceC =
    {
        "Letňany", "Prosek", "Sřížkov", "Ládví", "Kobylisy", "nádraží Holešovice", "Vltavská", "Florenc", "hlavní nádraží"," muzeum", "I.P. Pavlova", "Vyšehrad",
        "Pražského povstání", "Pankrác", "Budějovická", "Kačerov – Depo", "Kačerov", "Roztyly", "Chodov", "Opatov", "Háje "
    };
    //linka C

    string[] staniceD =
    { "Náměstí Míru", "Náměstí Bří Synků", "Olbrachtova", "Nádraží Krč", "Nemocnice Krč", "Nové Dvory", "Libuš", "Písnice", "Depo Písnice" };
    //linka D

    Console.WriteLine("Zadej linku, kterou chceš využít A/B/C/D");
    string volbaLinky = Console.ReadLine();

    //linka A
    if (volbaLinky == "A")
    {
        LinkaMetra linkaA = new LinkaMetra()
        { Name = "A", Color = "zelená", Aktivni = true, Stanice = staniceA };
        linkaA.NastavLinku();
        Console.WriteLine("Chcete vypsat 1. všechny stanice, 2. první a poslední, 3. zjistit čas cesty");
        string volba = Console.ReadLine();
        if (volba == "1")
        {
            linkaA.VypisVsechnyStanice();
        }
        else if (volba == "2")
        {
            linkaA.VypisPrvniPosledni();
        }
        else if (volba == "3")
        {
            linkaA.CasCesty();
        }

    }
    
    //linka B
    else if (volbaLinky == "B")
    {
        LinkaMetra linkaB = new LinkaMetra()
        { Name = "B", Color = "červená", Aktivni = true, Stanice = staniceB };
        linkaB.NastavLinku();
        Console.WriteLine("Chcete vypsat 1. všechny stanice, 2. první a poslední, 3. zjistit čas cesty");
        string volba = Console.ReadLine();
        if (volba == "1")
        {
            linkaB.VypisVsechnyStanice();
        }
        else if (volba == "2")
        {
            linkaB.VypisPrvniPosledni();
        }
        else if (volba == "3")
        {
            linkaB.CasCesty();
        }
    }

    //linka C
    else if (volbaLinky == "C")
    {
        LinkaMetra linkaC = new LinkaMetra()
        { Name = "C", Color = "žlutá", Aktivni = true, Stanice = staniceC };
        linkaC.NastavLinku();
        Console.WriteLine("Chcete vypsat 1. všechny stanice, 2. první a poslední, 3. zjistit čas cesty");
        string volba = Console.ReadLine();
        if (volba == "1")
        {
            linkaC.VypisVsechnyStanice();
        }
        else if (volba == "2")
        {
            linkaC.VypisPrvniPosledni();
        }
        else if (volba == "3")
        {
            linkaC.CasCesty();
        }
    }

    //linka D
    else if (volbaLinky == "D")
    {
        LinkaMetra linkaD = new LinkaMetra()
        { Name = "D", Color = "modrá", Aktivni = true, Stanice = staniceD };
        linkaD.NastavLinku();
        Console.WriteLine("Chcete vypsat 1. všechny stanice, 2. první a poslední, 3. zjistit čas cesty");
        string volba = Console.ReadLine();
        if (volba == "1")
        {
            linkaD.VypisVsechnyStanice();
        }
        else if (volba == "2")
        {
            linkaD.VypisPrvniPosledni();
        }
        else if (volba == "3")
        {
            linkaD.CasCesty();
        }
        Console.ReadLine();
    }
}

//Console.WriteLine("Vyber metro, které chceš zobrazit:");
//Console.ReadLine();