using System;

namespace DogsWithInterfaces {
    class Program {
        static void Main(string[] args) {

            var col = new Collie {
                Name = "Lassie", Color = "Light Brown", BarkSound = "A collie goes Woof!"
            };
            col.Bark();

            var box = new Boxer {
                Name = "Rocky", Color = "Black", BarkSound = "Woof Woof!"
            };
            box.Bark();

            var chi = new Chihuahua {
                Name = "Killer", Color = "White", BarkSound = "Yip!"
            };
            chi.Bark();

            IDog[] dogs = new IDog[10];
            dogs[0] = col;
            dogs[1] = box;
            dogs[2] = chi;
            foreach(var dog in dogs) {
                if(dog == null) continue;
                Console.WriteLine($"Name is {dog.Name}, color is {dog.Color}");
                dog.Bark();
            }
        }
    }
}
