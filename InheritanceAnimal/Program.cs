using System;

namespace InheritanceAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Pisica pisica1 = new Pisica("pisica");
            pisica1.rasaPisica = "birmaneza";
            pisica1.culoare = "neagra";
            pisica1.varsta = 1;
            Console.WriteLine(pisica1.InformatiiAnimal());
            Console.WriteLine(pisica1.CatSound());

            Caine caine1 = new Caine("caine");
            caine1.rasaCaine = "Husky";
            caine1.culoare = "alb-neagru";
            caine1.varsta = 3;
            Console.WriteLine(caine1.InformatiiAnimal());
            Console.WriteLine(caine1.DogSound());



        }
    }
}
