using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace lab9.Новая_папка
{
    public class Client
    {
        public string Name { get; set; }
        public double account = 0;
        public int Days { get; set; }
        public double Discount;
        public string Room { get; set; }
        public CreditCardClient card;

        public Client()
        {

        }

        public Client(string name, int days, string room)
        {
            Name = name;
            Days = days;
            Room = room;
        }

        public override string ToString()
        {
            return $"{Name}, время проживания: {Days} дней";
        }

        public static List<Client> LoadClientsFromJson(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<Client>>(json);
        }

    }
}