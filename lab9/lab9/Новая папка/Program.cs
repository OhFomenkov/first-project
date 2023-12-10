using System;
namespace lab9.Новая_папка
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\user\\Desktop\\журнал.txt");
            
            Client[] clients = Client.LoadClientsFromJson("C:\\Users\\user\\Desktop\\labC#\\lab9\\lab9\\Новая папка\\client.json");
            /*for(int i = 0; i < clients.Length; i++)
            {
                Client.CreditCardClient[]  = Client.CreditCardClient.LoadClientsCardsFromJson("C:\\Users\\user\\Desktop\\labC#\\lab9\\lab9\\Новая папка\\ClientCreaditCard.json");
            }*/
            Hotel RichmondBeach = new Hotel("RichmondBeach");
            
            Admin Luda = new Admin("Luda", RichmondBeach, sw);

            Luda.Zaselenie(clients[0]);
            RichmondBeach.AddServiceCharge(clients[0], "minibar");
            Luda.Viselenie(clients[0]);

            Luda.Zaselenie(clients[1]);
            RichmondBeach.AddServiceCharge(clients[0], "minibar");
            Luda.Viselenie(clients[1]);

            Luda.Zaselenie(clients[2]);
            RichmondBeach.AddServiceCharge(clients[0], "minibar");
            Luda.Viselenie(clients[2]);
            sw.Close();
        }
    }
}
// дополнить класс кредитная карта
// раскинуть классы в отдельнные файлы
// объекты инициилизируем из файлов
// категории номеров
// время прожиания
// администратор отдельно
// 