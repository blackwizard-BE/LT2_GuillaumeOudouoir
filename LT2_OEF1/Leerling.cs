using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT2_OEF1
{
    public class Leerling
    {
        private string Voornaam;//maakt strings aan
        private string Naam;
        private string Klas;

        public Leerling(string voornaam, string naam, string klas)
        {
            Voornaam = voornaam;//zet gelijk
            Naam = naam;
            Klas = klas;
        }
        public string getDataLeerling()
        {
            string dataLeerling = $"Voornaam: {Voornaam}, Naam: {Naam}, Klas: {Klas}";//maakt string en returnt deze
            return dataLeerling;

        }



    }
}
