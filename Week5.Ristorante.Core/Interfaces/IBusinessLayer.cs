using System;
using System.Collections.Generic;
using System.Text;
using Week5.Ristorante.Core.Models;

namespace Week5.Ristorante.Core.Interfaces
{
    public interface IBusinessLayer
    {
        IEnumerable<Piatto> FetchPiatti();
        Piatto GetPiattoById(int id);
        PiattoResult AddNewPiatto(Piatto newPiatto);
        PiattoResult EditPiatto(Piatto data);
        PiattoResult DeletePiatto(Piatto data);

        Account GetAccount(string username);
    }
}
