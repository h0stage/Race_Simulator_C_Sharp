using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Model
{
    class Competition
    {

        public List<IParticipant> Participants { get; set; }
        public Queue<Track> Tracks{ get; set; }

        public Track NextTrack ()
        {
            // if participants => 3 dan execute else warningmessage
            return Tracks.Dequeue();
        }


    }
}
