using System;
using System.Reflection.Metadata.Ecma335;

namespace lab9.Новая_папка
{
    public class Hotel
    {
        public string Name { get; set; }
        public List<string> service = new List<string>();
        private List<Client> clients = new List<Client>();
        private List<Client> booking = new List<Client>();
        private List<string> checkInLog = new List<string>();
        private List<string> checkOutLog = new List<string>();

        public Hotel() { }
        public Hotel(string name)
        {
            Name = name;
        }

        // Метод для бронирования номера в гостинице
        public void BookRoom(Client client)
        {
            booking.Add(client);
        }

        // Метод для заселения клиента в гостиницу
        public void CheckIn(Client client)
        {
            if (booking.Contains(client))
            {
                booking.Remove(client);
                clients.Add(client);
                string logEntry = $"Заселение: {client.Name} - {DateTime.Now}";
                checkInLog.Add(logEntry);
                Console.WriteLine(logEntry);
            }
            else
            {
                new ArgumentException("Клиент не проживает в гостинице");
            }
            GetDiscount(client);
        }

        // Метод для выселения клиента из гостиницы
        public void CheckOut(Client client)
        {
            if (clients.Contains(client))
            {
                clients.Remove(client);
                string logEntry = $"Выселение: {client.Name} - {DateTime.Now}. Cчёт: {client.account}";
                checkOutLog.Add(logEntry);
                Console.WriteLine(logEntry);
            }
            else
            {
                new ArgumentException("Клиент не проживает в гостинице");
            }
            CalculationAccount(client);
        }

        //Метод для вычисление счёта за проживание 
        private void CalculationAccount(Client client)
        {
            if (client.Room.Equals("Standard"))
            {
                client.account += client.Days * 30;
            }
            if (client.Room.Equals("Luxe"))
            {
                client.account += client.Days * 80;
            }
            if (client.Room.Equals("President"))
            {
                client.account += client.Days * 150;
            }
        }

        // Метод для добавления услуги на счет клиента
        public void AddServiceCharge(Client client, string service)
        {
            if (clients.Contains(client))
            {
                if (service.Equals("minibar"))
                {
                    client.account += 20;
                }
                if (service.Equals("restaurant"))
                {
                    client.account += 15;
                }
                if (service.Equals("laundry"))
                {
                    client.account += 10;
                }
            }
            else
            {
                new ArgumentException("Клиент не проживает в гостинице");
            }
        }

        // Метод для рассчёта скидки для клиента
        private void GetDiscount(Client client)
        {
            if(client.Days >=3 && client.Days < 7)
            {
                client.Discount = 5;
            }
            if(client.Days >=7 && client.Days < 30)
            {
                client.Discount = 10;
            }
            if(client.Days >= 30)
            {
                client.Discount = 20;
            }
        } 
    }

}

