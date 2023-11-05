using static System.Formats.Asn1.AsnWriter;
Console.WriteLine("Prosím, zadejte text, ve kterém chcete spočítat znaky:");
string text = Console.ReadLine();

var znaky = new Dictionary<char, int>();

for  (int i = 0; i < text.Length; i++)
{
    bool existuje = false;
    foreach (char x in znaky.Keys)
    {
        if (x == text[i])
        {
            existuje = true;
        }
    }
    if (existuje)
    {
        znaky[text[i]]++;
    }
    else { znaky.Add(text[i], 1); }
}

//je nutno dávat ve forech aktuálníIterace.Value, nikoliv kolekce.Value !!

foreach (var znak in znaky)
{
    char nazev = znak.Key;
    int pocet = znak.Value;
    Console.WriteLine($"{nazev}: {pocet}");
}