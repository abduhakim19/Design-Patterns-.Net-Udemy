using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SOLID
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }

    public class Persistance
    {
        public void SaveToFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, j.ToString());
            }
        }
    }

    public class SingleResponsibility
    {
        public void run()
        {
            var j = new Journal();
            j.AddEntry("Coba belajar");
            j.AddEntry("Saya Lapar");
            Console.WriteLine(j);

            var p = new Persistance();
            var filename = @"d:\designp\journal.txt";
            p.SaveToFile(j, filename, true);
            Process.Start("notepad.exe", @"d:\designp\journal.txt");
        }
    }
}
