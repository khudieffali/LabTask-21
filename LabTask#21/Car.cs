using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_21
{
    internal  class Car
    {
        public int Id { get; set; }
        public static int Count { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Price { get; set; }

        public Car(string name,int speed,int price)
        {
            Count++;
            Id= Count;
            Name= name;
            Speed= speed;
            Price= price;
        }

        public void GetInfoCar()
        {
            Console.WriteLine($"{Id} {Name} {Speed} {Price}");
        }
    }
}
