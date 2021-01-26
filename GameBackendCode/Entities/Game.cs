using System;
using System.Collections.Generic;
using System.Text;

namespace OyunKayitSistemi.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
