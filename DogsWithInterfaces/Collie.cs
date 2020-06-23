using System;
using System.Collections.Generic;
using System.Text;

namespace DogsWithInterfaces {
    
    class Collie : IDog {

        public string Name { get; set; }
        public string Color { get; set; }
        public string BarkSound { get; set; }

        public void Bark() {
            Console.WriteLine(BarkSound);
        }
    }
}
