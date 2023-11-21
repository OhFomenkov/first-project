using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace GeneticsProject
{
    public struct GeneticData
    {
        public string name; //protein name
        public string organism;
        public string formula; //formula
    }

    class Program
    {
        static List<GeneticData> data = new List<GeneticData>();
        static int count = 1;
        static string GetFormula(string proteinName)
        {
            foreach (GeneticData item in data)
            {
                if (item.name.Equals(proteinName)) return item.formula;
            }
            return null;
        }
        static void ReadGeneticData(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] fragments = line.Split('\t');
                GeneticData protein;
                protein.name = fragments[0];
                protein.organism = fragments[1];
                protein.formula = fragments[2];
                data.Add(protein);
                count++;
            }
            reader.Close();
        }
        static void ReadHandleCommands(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            StreamWriter writer = new StreamWriter("C:\\Users\\user\\Downloads\\geneout.txt");
            writer.WriteLine("Fomenkov Artyom\nGenetic Searching\n---------------------------------------------------------");
            int counter = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine(); counter++;
                string[] command = line.Split('\t');
                if (command[0].Equals("search"))
                {
                    //001   search  SIIK
                    writer.WriteLine($"{counter.ToString("D3")}   {"search"}   {command[1]}");
                    writer.WriteLine("organism\t\t\t\tprotein");
                    int index = Search(command[1]);
                    if (index != -1)
                        writer.WriteLine($"{data[index].organism}    {data[index].name}");
                    else
                        writer.WriteLine("NOT FOUND");
                    writer.WriteLine("================================================");
                }
                if (command[0].Equals("diff"))
                {
                    writer.WriteLine($"{counter.ToString("D3")}   {"diff"}   {command[1]}   {command[2]}");
                    writer.WriteLine("amino-acids difference:");
                    string form1 = GetFormula(command[1]);
                    string form2 = GetFormula(command[2]);
                    if (form1 == null)
                        writer.WriteLine("MISSSING: {0}", command[1]);
                    if (form2 == null)
                        writer.WriteLine("MISSSING: {0}", command[2]);
                    else
                    {
                        writer.WriteLine(Diff(form1, form2));
                    }
                    writer.WriteLine("================================================");
                }
                if (command[0].Equals("mode"))
                {

                    string form = GetFormula(command[1]);
                    writer.WriteLine($"{counter.ToString("D3")}   {"mode"}   {command[1]}");
                    writer.WriteLine("amino-acid occurs:");
                    if (form == null)
                    {
                        writer.WriteLine("MISSING: {0}", command[1]);
                    }
                    else
                    {
                        Mode(form, writer);
                    }
                    writer.WriteLine("================================================");
                }
            }
            reader.Close();
            writer.Close();
        }
        static bool IsValid(string formula)
        {
            List<char> letters = new List<char>() { 'A', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'Y' };
            foreach (char ch in formula)
            {
                if (!letters.Contains(ch)) return false;
            }
            return true;
        }
        static string Encoding(string formula)
        {
            string encoded = String.Empty;
            for (int i = 0; i < formula.Length; i++)
            {
                char ch = formula[i];
                int count = 1;
                while (i < formula.Length - 1 && formula[i + 1] == ch)
                {
                    count++;
                    i++;
                }
                if (count > 2) encoded = encoded + count + ch;
                if (count == 1) encoded = encoded + ch;
                if (count == 2) encoded = encoded + ch + ch;

            }
            return encoded;

        }
        static string Decoding(string formula)
        {
            string decoded = String.Empty;
            for (int i = 0; i < formula.Length; i++)
            {
                if (char.IsDigit(formula[i]))
                {
                    char letter = formula[i + 1];
                    int conversion = formula[i] - '0';
                    for (int j = 0; j < conversion - 1; j++) decoded = decoded + letter;
                }
                else decoded = decoded + formula[i];
            }
            return decoded;
        }
        static int Search(string amino_acid)
        {
            //       FKIII                FK3I
            string decoded = Decoding(amino_acid);
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].formula.Contains(decoded)) return i;
            }
            return -1;
        }
        static int Diff(string protein1, string protein2)
        {
            int counter = 0;
            for (int i = 0; i < (protein1.Length > protein2.Length ? protein2.Length : protein1.Length); i++)
            {
                if (protein1[i] != protein2[i])
                    counter++;
            }
            counter += Math.Abs(protein1.Length - protein2.Length);
            return counter;
        }
        static void Mode(string form, StreamWriter wr)
        {
            form = Decoding(form);
            StringBuilder temp = new StringBuilder();
            Dictionary<char, int> Dic = new Dictionary<char, int>();
            for (int i = 0; i < form.Length; i++)
            {
                if (!Dic.ContainsKey(form[i]))
                    Dic.Add(form[i], 1);
                else
                    Dic[form[i]]++;
            }
            int max = 0;
            List<(char, int)> lst = new List<(char, int)>();
            foreach (var itm in Dic)
                if (itm.Value > max)
                    max = itm.Value;

            foreach (var itm in Dic)
                if (itm.Value == max)
                    lst.Add((itm.Key, itm.Value));
            lst.Sort((x, y) => x.Item1.CompareTo(y.Item1));
            wr.Write("{0}       {1}\n", lst[0].Item1, lst[0].Item2);
        }
    
        static void Main(string[] args)
        {

            string formula2 = Decoding("FK3I");
            ReadGeneticData("C:\\Users\\user\\Downloads\\sequences.2.txt");
            Console.WriteLine("=============Search===================");
            ReadHandleCommands("C:\\Users\\user\\Downloads\\commands.2.txt");
            Console.WriteLine("=============Get Formula of the Protein===================");
            string formula = GetFormula("6.8 kDa mitochondrial proteolipid");
            if (formula != null) Console.WriteLine(formula);
        }
    }
}
