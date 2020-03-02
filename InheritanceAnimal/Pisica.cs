using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAnimal
{
    public class Pisica : Animal
    {
        public string rasaPisica { get; set; }
        public Pisica(string rasaPisica) : base(rasaPisica)
        {
            rasaPisica = "Rasa pisica" + rasaPisica;
        }


        public string InformatiiAnimal()
        {
            return "\nTip Animal: Pisica" + "\nRasa pisica: " + rasaPisica + "\nvarsta pisica: " + base.varsta + "\nCuloare pisica: " + base.culoare;
        }
        public string CatSound()
        {
            return ("\nmiau!");
        }
    }
}
