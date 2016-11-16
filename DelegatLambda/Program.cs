using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var personer = new List<Person>();

            var hund = new Specie("Hund",2,4);
            var spider = new Specie("Spider", 8, 8);
            var king = new Pet(hund,"Hund");
            personer.Add (new  Person("Åse",new Pet(spider,"black") ));
            personer.Add(new Person("Jens", king));
            personer.Add(new Person("Egon", new Pet(hund, "Rolo")));

            Console.WriteLine("TO console:");
            Debug.WriteLine("data:");
            Debug.WriteLine(personer.ToString());
            Console.ReadKey();

        }
    }
    public class Specie
    {
        private string name;
        private int numbersOfEyes;
        private int numbersOfLegs;

        public string Name       { get {  return name; }   }
        public int NumbersOfEyes { get { return numbersOfEyes; } }
        public int NumbersOfLegs { get { return numbersOfLegs; } }

        public Specie(string name, int numbersOfEyes, int numbersOfLegs)
        {
            this.name = name;
            this.numbersOfEyes = numbersOfEyes;
            this.numbersOfLegs = numbersOfLegs;
        }
    }
    public class Pet
    {
        private Specie spicie;
        private string name;

        public Specie Spicie { get { return spicie; } }
        public string Name { get { return name; } }

        public Pet(Specie spicie, string name)
        {
            this.spicie = spicie;
            this.name = name;
        }
    }

    public class Person : INotifyPropertyChanged
    {
        private string name;
        private int yearBorn;
        private Pet pet;
        private EventHandler<string> NameChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (this.Name != value)
                {

                    this.name = value;
                    OnNameChanged();
                    // on
                }
            }
        }
        public int YearBorn { get { return yearBorn; } }
        public Pet Pet { get { return pet; } }

        public void OnNameChanged()
        {
            EventHandler<string> handler = NameChanged;
            if (NameChanged != null)
            {
                handler(this, this.name);
            }
        }

        public Person(string name, int yearBorn, Pet pet)
        {
            this.name = name;
            this.yearBorn = yearBorn;
            this.pet = pet;
        }
        public Person(string name) : this(name, 0, null) { }
        public Person(string name, Pet pet) : this(name, 0, pet) { }
        public Person(string name, string petName, Specie specie)
        {
            this.name = name;
            Pet newPet = new Pet(specie, petName);
            this.pet = newPet;
        }

        public string getName()
        {
            return this.Name;
        }
        public int getAlder()
        {
            return System.DateTime.Now.Year - this.YearBorn;
        }
        public int getPeronsPetsNumberOfEyes()
        {
            return pet.Spicie.NumbersOfEyes;
        }

        private void OnPropertyChanged(string propertyName)
        {
            //ProgressChangedEventHandler handler = PropertyChanged;
            //if (handler != null)
            {
              //  handler(this, new ProgressChangedEventArgs(propertyName));
            }
        }
    }

    // skriv delegate
    public delegate bool Filter(Person person);

    public static class PersonExtention
    {
        public static List<Person> FilterOut(this List<Person> personer, Filter filter)
        {
            var personListe = new List<Person>();
            foreach (var person in personer)
            {
                if (!filter(person))
                {
                    personListe.Add(person);
                }
            }
            return personListe;
        }
    }

}
