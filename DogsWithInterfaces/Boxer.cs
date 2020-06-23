using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace DogsWithInterfaces {

    class Boxer : IDog {

        public string Name { get; set; }
        public string Color { get; set; }
        public string BarkSound { get; set; }

        public void Bark() {
            Console.WriteLine($"A boxer goes {BarkSound}");
        }
    }
}
