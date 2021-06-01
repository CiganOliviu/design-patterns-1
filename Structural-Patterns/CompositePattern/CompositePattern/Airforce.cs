using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositePattern
{
    public class Airforce : IAlliancePart
    {
        private readonly List<IAlliancePart> _planes = new List<IAlliancePart>();
        
        public void Add(IAlliancePart alliancePart)
        {
            _planes.Add(alliancePart);
        }


        public int GetPersonnel()
        {
            return _planes.Sum(plane => plane.GetPersonnel());
        }
    }
}