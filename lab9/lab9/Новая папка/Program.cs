using System;
using System.Text.Json;
using Newtonsoft.Json;

namespace lab9.Новая_папка
{
    class Program
    {
        static void Vzaim(List<Client> clients, Hotel ht, Admin admin)
        {
            int move = 0;
            while (move != 5) { 
            Console.WriteLine("\n\t\tСписок клиентов: ");

            for (int i = 0; i < clients.Count; i++)
            {
                Console.Write($"{clients[i].Name} - ({i + 1}) ");
            }
            Console.WriteLine("\n\t\tВыберите клинта по его номеру(Введите 0 чтобы закончить)");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\t\tВыберите действие:\n(1) - забронировать номер в отеле, (2) - заселиться в отель, (3) - Воспользоваться услугами отеля, (4) - Выселиться из отеля, (5)-Закончить");
            move = Convert.ToInt32(Console.ReadLine());
                switch (move)
                {
                    case 1:
                        ht.BookRoom(clients[a - 1]);
                        break;

                    case 2:
                        admin.Zaselenie(clients[a - 1]);
                        break;

                    case 3:
                        Console.WriteLine("\n\t\tВыберите услугу:\n(1) - minibar, (2) - restaurant, (3) - laundry");
                        int b = Convert.ToInt32(Console.ReadLine());
                        switch (b)
                        {
                            case 1:
                                ht.AddServiceCharge(clients[a - 1], "minibar");
                                break;
                            case 2:
                                ht.AddServiceCharge(clients[a - 1], "restaurant");
                                break;
                            case 3:
                                ht.AddServiceCharge(clients[a - 1], "laundry");
                                break;
                            default:
                                Console.WriteLine("Некорректный формат входных данных");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine($"{clients[a - 1].Name} выселился из {ht.Name}");
                        admin.Viselenie(clients[a - 1]);
                        break;
                    case 5:

                        break;
                }
                string jsonq = JsonConvert.SerializeObject(clients);
                File.WriteAllText("C:\\Users\\user\\Desktop\\labC#\\lab9\\client.json", jsonq);
            }
        }

        static void AddClient(List<Client> clients, List<CreditCardClient> cards)
        {
            Console.WriteLine("\n\t\tВведите данные клиента");
            Console.WriteLine("Имя: ");

            string Name = Console.ReadLine();

            Console.WriteLine("Количство дней проживания в отеле");

            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Тип номера в отеле (Luxe, Standard, President)");

            string room = Console.ReadLine();

            Console.WriteLine("\t\tЕсть ли у новго клиента кредитная карта?\n(1) - Есть, (2) - Нету");
            int f = Convert.ToInt32(Console.ReadLine());
            if (f == 1)
            {
                var new_client = new Client(Name, days, room);
                Console.WriteLine("Введите номер кредитной карты нового клиента:");
                string Number = Console.ReadLine();
                Console.WriteLine("Введите CVV кредитной карты нового клиента:");
                string CVV = Console.ReadLine();
                Console.WriteLine("Введите имя владельца карты");
                string OwnerName = Console.ReadLine();
                Console.WriteLine("Введите срок действия карты нового клиента");
                string Date = Console.ReadLine();
                var new_card = new CreditCardClient(Number, CVV, OwnerName, Date);
                new_client.card = new_card;

                clients.Add(new_client);
                cards.Add(new_card);

                string json = JsonConvert.SerializeObject(cards);
                File.WriteAllText("C:\\Users\\user\\Desktop\\labC#\\lab9\\Cards.json", json);

            }
            if(f == 2)
            {
                var new_client = new Client(Name, days, room);
                clients.Add(new_client);
                new_client.card = null;
            }

            string jsonq = JsonConvert.SerializeObject(clients);
            File.WriteAllText("C:\\Users\\user\\Desktop\\labC#\\lab9\\client.json", jsonq);

        }


        public static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\user\\Desktop\\журнал.txt");
            List<CreditCardClient> cards = CreditCardClient.LoadClientsCardsFromJson("C:\\Users\\user\\Desktop\\labC#\\lab9\\Cards.json");
            List<Client> clients = Client.LoadClientsFromJson("C:\\Users\\user\\Desktop\\labC#\\lab9\\client.json");
            
            Hotel RichmondBeach = new Hotel("RichmondBeach");
            
            Admin Luda = new Admin("Luda", RichmondBeach, sw);

            Console.WriteLine("\t\tВыберите действие\n(1) - Взаимодействие с клиентами, (2) - добавить клиента в базу данных");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Vzaim(clients, RichmondBeach, Luda);
                    break;

                case 2:
                    AddClient(clients, cards);
                    break;

                default:
                    Console.WriteLine("Некорректный формат входных данных");
                    break;
            }
            sw.Close();
        }
    }
}

//Работа с клиентами через коносоль, запись в json  