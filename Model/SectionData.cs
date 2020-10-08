using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class SectionData 
    {

        public IParticipant Left { get; set; }

        public int DistanceLeft { get; set; }

        public IParticipant Right { get; set; }

        public int DistanceRight { get; set; }

        // Moet dit wel hieronder? Zo ja, waarom? (omdat het abstract is zeker | zelfs als je bepaalde prop niet gebruikt moet je het toch helemaal implementeren)
        
     /*
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEquipment Equipment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Teamcolors Teamcolor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
     */
    }
}
