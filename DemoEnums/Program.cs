using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEnums
{
    public enum AnimalTypeEnum {Bird,Fish};
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Specie
    {
        private string name;
        private int numbersOfEyes;
        private int numbersOfLegs;
        private AnimalTypeEnum animalType = AnimalTypeEnum.Fish;

        public string Name       {     get   {  return name;     }        }
        public int NumbersOfEyes { get { return numbersOfEyes; } }
        public int NumbersOfLegs { get { return numbersOfLegs; } }


        public Specie(string name, int numbersOfEyes, int numbersOfLegs)
        {
            this.name = name;
            this.numbersOfEyes = numbersOfEyes;
            this.numbersOfLegs = numbersOfLegs;
        }
        public string Talk()
        {
            switch (this.animalType)
            {
                case AnimalTypeEnum.Bird:
                    return "Pip pip";
                    //break;
                case AnimalTypeEnum.Fish:
                    return ".... blop";
                default:
                    return "blideer";
            }
            //return "efjl";
        }
    }

}