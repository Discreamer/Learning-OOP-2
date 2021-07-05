using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace IHateSharp
{
	
	class Animal
	{
		public string Name;
		public virtual void Noise()
		{
			Console.WriteLine("Strange sounds");
		}
	}
	class Cat : Animal
	{
		public override void Noise()
		{
			Console.WriteLine("meow");
		}
	}
	class Dog : Animal
	{
		public override void Noise()
		{
			Console.WriteLine("suka");
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			int count=2;
			Animal[] animals = new Animal[count];
			Cat cat = new Cat();
			cat.Name="Kit";
			Dog dog =new Dog();
			dog.Name="Sobol";
			animals[0]=cat;
			animals[1]=dog;
			for (int i=0;i<animals.Length;i++)
			{
				animals[i].Noise();
				Console.WriteLine(animals[i].Name);
			}
			Animal an=new Animal();
			an.Noise();
			
        }
	}
}

