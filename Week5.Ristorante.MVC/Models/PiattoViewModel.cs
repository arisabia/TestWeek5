using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week5.Ristorante.MVC.Models
{
    public enum Tipo
    {
        Primo,
        Secondo,
        Contorno,
        Dolce
    }
    public class PiattoViewModel
    {
        public int Id { get; set; }
        [Required, DisplayName("Nome"), StringLength(50, MinimumLength = 2)]
        public string Nome { get; set; }
        [Required, DisplayName("Descrizione")]
        public string Descrizione { get; set; }
        [Required, DisplayName("Tipologia")]
        public Tipo Tipo { get; set; }
        [Required, DisplayName("Prezzo"), DataType(DataType.Currency)]
        public decimal Prezzo { get; set; }
    }
}
