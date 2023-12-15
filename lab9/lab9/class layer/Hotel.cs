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

        public Hotel() { }
        public Hotel(string name)
        {
            Name = name;
        }

        // Метод для бронирования номера в гостинице
        public void BookRoom(Client client)
        {
            if (!booking.Contains(client) && !clients.Contains(client))
            {
                booking.Add(client);
                Console.WriteLine($"Номер забронирован на имя {client.Name}");
            }
            else
            {
                Console.WriteLine($"У {client.Name} уже забронирован номер");
            }

        }

        // Метод для заселения клиента в гостиницу
        public void CheckIn(Client client)
        {
            if (booking.Contains(client))
            {
                booking.Remove(client);
                clients.Add(client);
                Console.WriteLine($"{client.Name} был заселён в {Name}");
            }
            else
            {
                Console.WriteLine($"{client.Name} не забронировал номер в {Name}");
            }
            GetDiscount(client);
        }

        // Метод для выселения клиента из гостиницы
        public void CheckOut(Client client)
        {
            if (clients.Contains(client))
            {
                clients.Remove(client);
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
            if (client.Days >= 3 && client.Days < 7)
            {
                client.Discount = 5;
            }
            if (client.Days >= 7 && client.Days < 30)
            {
                client.Discount = 10;
            }
            if (client.Days >= 30)
            {
                client.Discount = 20;
            }
        }
    }

}

