
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Vítej člověče, zde vidíš stanice metra A,B,C a budoucí stanici D");

string[] staniceA =
{
        "Depo Hostivař", "Skalka", "Strašnická", "Želivského", "Flora", "Jiřího z Poděbrad", "Náměstí Míru", "Muzeum", "Můstek",
        "Staroměstská", "Malostranská", "Hradčanská", "Dejvická", "Bořislavka", "Nádraží Veleslavín", "Petřiny", "Nemocnice Motol"
};

string[] staniceB =
{
        "Zličín", "Stodůlky", "Luka", "Lužiny", "Hůrka", "Nové Butovice", "Jironice, Radlická", "Smíchovské nádraží", "Anděl", "Karlovo náměstí",
        "Národní třída", "Můstek", "Náměstí Republiky", "FLorenc", "Křižíkova", "Invalidova", "Palmovka", "Českomoravská", "Vysočanská", "Kolbenova",
        "Hloubětín", "Rajská zahrada", "Černý Most"
    };

string[] staniceC =
{
        "Letňany", "Prosek", "Sřížkov", "Ládví", "Kobylisy", "nádraží Holešovice",
        "Vltavská", "Florenc", "hlavní nádraží"," muzeum", "I.P. Pavlova", "Vyšehrad",
        "Pražského povstání", "Pankrác", "Budějovická", "Kačerov – Depo", "Kačerov",
        "Roztyly", "Chodov", "Opatov", "Háje "

    };

string[] StaniceD = { "Náměstí Míru", "Náměstí Bří Synků", "Olbrachtova", "Nádraží Krč", "Nemocnice Krč", "Nové Dvory", "Libuš", "Písnice", "Depo Písnice" };

Console.WriteLine("Vyber metro, které chceš zobrazit:");
Console.ReadLine();

