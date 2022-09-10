namespace TextModEditor.Scripts;
internal class KeysManager
{
    private static readonly string litPath = "Keys/raw.keys", worPath = "Keys/worded.keys";

    public static List<string> literal = new();
    public static List<string> worded = new();

    public static void GetKeys()
    {
        literal = new(File.ReadAllLines(litPath));
        worded = new(File.ReadAllLines(worPath));
    }

    public static void Add(string lit, string wor)
    {
        using var l = File.AppendText(litPath);
        l.Write($"\n{lit}");

        using var w = File.AppendText(worPath);
        w.Write($"\n{wor}");
    }

    public static void Remove(string lit, string wor)
    {
        File.WriteAllLines(litPath,
            File.ReadLines(litPath).Where(l => l != $@"{lit}").ToList());

        File.WriteAllLines(worPath,
            File.ReadLines(worPath).Where(l => l != $@"{lit}").ToList());
    }

}
