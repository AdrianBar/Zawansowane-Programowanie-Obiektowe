using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_1._3
{
    class StandardowyCzłowiek
    {
        public List<string> Imię;
        public int Wiek;
        public int IlośćKościSzkieletowych;
        public string MiejscePochodzenia;
        public int IlośćChromosomów;

        public StandardowyCzłowiek(List<string> imię, int wiek, int ilośćKościSzkieletowych, string miejscePochodzenia, int ilośćChromosomów)
        {
            this.Imię = imię;
            this.Wiek = wiek;
            this.IlośćKościSzkieletowych = ilośćKościSzkieletowych;
            this.MiejscePochodzenia = miejscePochodzenia;
            this.IlośćChromosomów = ilośćChromosomów;
        }

    }
}
