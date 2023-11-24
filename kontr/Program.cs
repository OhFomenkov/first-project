using System;
using System.Data;
using System.Collections.Generic;

namespace krfile
{

    abstract class TrainCar
    {
        public int TrainCarNum { get; }
        public int TrainCarLen { get; }
        public TrainCar(int TrainCarNum, int TrainCarLen)
        {
            if (TrainCarNum <= 0)
            {
                throw new ArgumentException("Невозмоожное значение: номер вагона");
            }
            else
            {
                this.TrainCarNum = TrainCarNum;
            }
            if (TrainCarLen <= 0)
            {
                throw new ArgumentException("Невозможное значение: длина вагона");
            }
            else
            {
                this.TrainCarLen = TrainCarLen;
            }
        }
        public override string ToString()
        {
            return $"Номер вагона: {TrainCarNum}\nДлина вагона{TrainCarLen}\n";
        }
    }

    class PassengerCar : TrainCar
    {
        public int PassangerSeats = 8;
        public PassengerCar(int TrainCarNum, int TrainCarLen, int PassangerSeats) : base(TrainCarNum, TrainCarLen)
        {
            if (PassangerSeats < 8)
            {
                throw new ArgumentException("Кол-во посадочных мест не может быть меньше 8");
            }
            else
            {
                this.PassangerSeats = PassangerSeats;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"Кол-во посадочных метс: {PassangerSeats}";
        }

    }

    class MailCar : TrainCar
    {
        public int gruzopod;
        private int TrainCarNum;
        private int TrainCarLen;
        public MailCar(int TrainCarNum, int TrainCarLen, int gruzopod) : base(TrainCarNum, TrainCarLen)
        {
            if (gruzopod <= 0)
            {
                throw new ArgumentException("Недопустимая грузоподъёмность");
            }
            else
            {
                this.gruzopod = gruzopod;
            }
            this.TrainCarNum = TrainCarNum;
            this.TrainCarLen = TrainCarLen;
        }

        public override string ToString()
        {
            return base.ToString() + $"Грузоподъёмность: {gruzopod}";
        }
    }

    class Train : TrainEqual
    {
        static List<TrainCar> list = new List<TrainCar>();

        static public void Add(TrainCar obj)
        {
            list.Add(obj);
        }

        public string IsMailCar()
        {
           foreach(TrainCar obj in list)
            {
                string str = obj.ToString();
                string[] arr = str.Split(' ');
                foreach(string i in arr)
                {
                    if (i.Equals("Грузоподъёмность:"))
                    {
                        return "Есть почтовый вагон";
                    }
                }
            }
            return "Нету почтовго вагона";
        }

        public static int GetLength()
        {
            int sumlen = 0;
            foreach(TrainCar obg in list)
            {
                sumlen += obg.TrainCarLen;
            }
            return sumlen;
        }

        public static void ToString()
        {
            foreach (TrainCar obj in list)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        public static void Sort()
        {
            list.Sort();
            while (Train.GetLength() > 100)
            {
                list.Remove(list[-1]);
            }
        }
    }







    class Project
    {
        static void Main(string[] args)
        {
            PassengerCar vagon1 = new PassengerCar(1, 11, 8);
            PassengerCar vagon2 = new PassengerCar(2, 10, 9);
            MailCar vagon3 = new MailCar(3, 13, 10);
            MailCar vagon4 = new MailCar(4, 15, 12);
            Train.Add(vagon1);
            Train.Add(vagon2);
            Train.Add(vagon3);
            Train.Add(vagon4);
            //Train.Sort();
            Train.ToString();
        }
    }
}