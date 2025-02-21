using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Comanda
    {
        public int ID { get; set; }
        public string Client { get; set; }
        public string Produs { get; set; }
        public int Cantitate { get; set; }

        
        public Comanda() { }

        
        public Comanda(int id, string client, string produs, int cantitate)
        {
            ID = id;
            Client = client;
            Produs = produs;
            Cantitate = cantitate;
        }

        
        public Comanda(string client, string produs, int cantitate)
        {
            Client = client;
            Produs = produs;
            Cantitate = cantitate;
        }

        public override string ToString()
        {
            return $"ID: {ID} - {Client}, {Produs}, {Cantitate} buc.";
        }
    }
}
