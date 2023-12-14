using System;


namespace lab9.Новая_папка
{
    public class Admin 
    {
        StreamWriter sw;
        Hotel hotel;
        public string Name { get; set; }

        public Admin() { }
        public Admin(string name, Hotel hotel, StreamWriter sw)
        {
            Name = name;
            this.hotel = hotel;
            this.sw = sw;
        }

        //Заселение клиента в гостиницу
        public void Zaselenie(Client client)
        {
            DateTime dt = new DateTime();
            hotel.CheckIn(client);
            sw.Write($"Заселение: {client.Name}. Дата и Время: {DateTime.UtcNow}\n");
        }

        public void Viselenie(Client client)
        {
            DateTime dt = new DateTime(2023, 12, 11);
            hotel.CheckOut(client);
            sw.Write($"Выселение: {client.Name}. Дата и Время: {dt.AddDays(client.Days)} \nСчёт : {client.account * (1 - client.Discount / 100)}$, Скидка: {client.Discount}%\n");
        }


    }
}
