using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    enum Teamcolors {Red, Green, Yellow, Grey, Blue};

    interface IParticipant
    {

      
        public string Name { get; set; }

        public int Points { get; set; }

        public IEquipment Equipment { get; set; }

        public Teamcolors Teamcolor { get; set; }

    }
}
