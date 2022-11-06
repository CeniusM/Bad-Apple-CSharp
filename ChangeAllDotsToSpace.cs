

namespace FileChangeThingy;

class IDoStuff
{
    public static void Start1()
    {
        
        
        
        List<string> file = File.ReadAllLines("allFrames.txt").ToList();



        List<char[]> lines = new List<char[]>();
        for (int i = 0; i < file.Count; i++)
            lines.Add(file[i].ToCharArray());



        for (int i = 0; i < lines.Count; i++)
        {
            for (int j = 0; j < lines[i].Length; j++)
            {
                if (lines[i][j] == '.')
                    lines[i][j] = ' ';
            }
        }

        file.Clear();
        for (int i = 0; i < lines.Count; i++)
            file.Add(new string(lines[i]));

        File.WriteAllLines("allFrames.txt", file);
    }

    public static void Start2()
    {
        string[] file = File.ReadAllLines("allFrames.txt");

        int NormalLineL = file[0].Length;
        for (int i = 0; i < file.Length; i++)
        {
            for (int j = file[i].Length; j < NormalLineL; j++)
            {
                file[i] += ' ';
            }
        }

        File.WriteAllLines("allFrames.txt", file);
    }


    public static void Data()
    {
        
    }
}