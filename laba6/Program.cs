using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace labfile
{
    class Project
    {
        static void Read_info(StreamReader reader, int size, StreamWriter writer)
        {
            int distance;
            int M = 0, C = 0;
            int distance_m = 0, distance_c = 0;
            (string, int) tuple;
            string info = reader.ReadLine();
            bool MouseCaught = false;
            while (info != null && !MouseCaught)
            {
                if (!info.Equals("P"))
                {
                    tuple = (Regex.Split(info, @"\s+")[0], Regex.Split(info, @"\s+").Length > 1 ? Convert.ToInt32(Regex.Split(info, @"\s+")[1]) : 0);
                    switch (tuple.Item1)
                    {
                        case "M":
                            if (M != 0) distance_m += Math.Abs(tuple.Item2);
                            M = make_step(tuple.Item2, size, M, distance_m);
                            break;

                        case "C":
                            if (C != 0) distance_c += Math.Abs(tuple.Item2);
                            C = make_step(tuple.Item2, size, C, distance_c);
                            break;
                    }
                }
                else
                {
                    distance = Math.Abs(C - M);
                    if(C == 0 && M == 0)
                    {
                        writer.WriteLine("??\t??");
                    }

                    if (C == 0 && M != 0)
                    {
                        writer.WriteLine("??\t{0}", M);
                    }

                    if (M == 0 && C != 0)
                    {
                        writer.WriteLine("{0}\t??", C);
                    }

                    if (M != 0 && C != 0)
                    {
                        writer.WriteLine("{0}\t{1}\t{2}", C, M, distance);
                    }
                }
                if (C == M & C != 0)
                {
                    WriteResults(writer, distance_m, distance_c);
                    writer.WriteLine("Mouse caught at: {0}", C);
                    MouseCaught = true;
                    break;
                    writer.Close();
                }
                info = reader.ReadLine();
            }

            if (!MouseCaught)
            {
                WriteResults(writer, distance_m, distance_c);
                writer.WriteLine("\nMouse evaded Cat");
            }
        }

        static void Write_Info(StreamWriter writer)
        {
            writer.WriteLine("Cat and Mouse");
            writer.WriteLine();
            writer.WriteLine("Cat Mouse  Distance");
            writer.WriteLine("-------------------");
        }

        static void WriteResults(StreamWriter writer, int distance_m, int distance_c)
        {
            writer.WriteLine("-------------------\n\n");
            writer.WriteLine("Distance traveled:   Mouse    Cat");
            writer.WriteLine("                        {0}\t{1}\n", distance_m, distance_c);
        }

        static int make_step(int step, int size, int who, int distanc)
        {
            if(who == 0)
            {
                if (step % size == 0)
                {
                    return 1;
                }
                else
                {
                    return step % size;
                }
            }
            else
            {
                if(who + step > size)
                {

                    return (who + step) % size;
                }
                else if(who + step < 1)
                {
                    return size - Math.Abs(who + step) % size;
                }
                else
                {
                    return who + step;
                }
            }
        }


        static void Main(string[] args)
        {
            string pathin = "C:\\Users\\user\\Downloads\\2.ChaseData.txt";
            string pathout = "C:\\Users\\user\\Downloads\\1.Chaseout.txt";
            StreamReader reader = new StreamReader(pathin);
            StreamWriter writer = new StreamWriter(pathout);
            string first = reader.ReadLine();
            first = first.Trim();
            int size = Convert.ToInt32(first);
            Write_Info(writer);

            Read_info(reader, size, writer);

            reader.Close();
            writer.Close();
        }
    }
}