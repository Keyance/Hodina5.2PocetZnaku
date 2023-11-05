using static System.Formats.Asn1.AsnWriter;

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


//je potřeba key value pair zapsat do konzole, přijít na to jak...
foreach (var key in znaky.Keys)
{
    Console.WriteLine($"Key: {key}");
}

foreach (var value in znaky.Values)
{
    Console.WriteLine($"\tValue: {value}");
}