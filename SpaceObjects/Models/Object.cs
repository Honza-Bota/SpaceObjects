using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SpaceObjects.Model
{
    public class Object
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public long Age { get; set; }
        public static int Index { get; set; } = 0;

        public Object()
        {
            Index++;
        }

        int GetIndex() => Index;

        public override bool Equals(object obj)
        {
            // Check for null  
            if (ReferenceEquals(obj, null))
                return false;
            // Check for same reference  
            if (ReferenceEquals(this, obj))
                return true;
            var objec = (Object)obj;
            return this.GetIndex() == objec.GetIndex();
        }
        public override int GetHashCode()
        {
            return GetIndex() ^ 7;
        }
    }
}
