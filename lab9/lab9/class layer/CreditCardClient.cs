using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace lab9.Новая_папка
{
    public class CreditCardClient
    {
        public string Number { get; set; }
        public string CVV { get; set; }
        public string OwnerName { get; set; }
        public string Date { get; set; }
        public CreditCardClient(string number, string cVV, string ownerName, string date)
        {
            Number = number;
            CVV = cVV;
            OwnerName = ownerName;
            Date = date;
        }
        public CreditCardClient() { }

        public static void Getter(string number, string cVV, string ownerName, string date)
        {

        }

        public static List<CreditCardClient> LoadClientsCardsFromJson(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<CreditCardClient>>(json);
        }


    }
}