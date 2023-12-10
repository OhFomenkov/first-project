using System;
using System.IO;
using Newtonsoft.Json;

namespace lab9.Новая_папка
{
    public class Client
    {
        public string Name { get; set; }
        public string CreditCardNumber { get; }
        public double account = 0;
        public int Days { get; set; }
        public double Discount;
        public string Room;

        public Client()
        {

        }

        public Client(string name, string creditCardNumber, int days, string room)
        {
            Name = name;
            CreditCardNumber = creditCardNumber;
            Days = days;
            Room = room;
        }

        public class CreditCardClient
        {
            private string Number { get; }
            private string CVV { get; }
            private string OrderName { get; }
            private string Date { get; }
            public CreditCardClient(string number, string cVV, string orderName, string date)
            {
                Number = number;
                CVV = cVV;
                OrderName = orderName;
                Date = date;
            }
            public CreditCardClient() { }

            public static Client.CreditCardClient LoadClientsCardsFromJson(string jsonFilePath)
            {
                string json = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<Client.CreditCardClient>(json);
            }

        }

        public override string ToString()
        {
            return $"{Name}, время проживания: {Days} дней";
        }

        public static Client[] LoadClientsFromJson(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<Client[]>(json);
        }

    }
}