using System;
using System.Collections.Generic;
using System.Text;

namespace Week5.Ristorante.Core.Models
{
    public enum Tipo
    {
        Primo, 
        Secondo, 
        Contorno, 
        Dolce
    }
    public class Piatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public Tipo Tipo { get; set; }
        public decimal Prezzo { get; set; }
    }
}
