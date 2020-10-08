using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    enum SectionTypes { Straight, Leftcorner, Rightcorner, StartGrid, Finish}
    class Section
    {
        public SectionTypes SectionType { get; set; }
    }
}
