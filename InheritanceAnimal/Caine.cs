using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAnimal
{
    public class Caine : Animal
    {
        public string rasaCaine { get; set; }
        public Caine(string rasaCaine) : base(rasaCaine)
        {
            rasaCaine = "Rasa caine:" + rasaCaine;
        }
        public string InformatiiAnimal()
        {
            return "\nTip Animal: Caine" + "\nRasa caine: " + rasaCaine + "\nvarsta caine: " + base.varsta + "\nCuloare caine: " + base.culoare;
        }
        public string DogSound()
        {
            return "\nHam!";
        }
    }
}
