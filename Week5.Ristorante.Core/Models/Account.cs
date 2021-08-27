using System;
using System.Collections.Generic;
using System.Text;

namespace Week5.Ristorante.Core.Models
{
    public enum Role
    {
        Ristoratore,
        Cliente
    }
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
