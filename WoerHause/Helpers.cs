using System;
using System.Collections.Generic;
using System.Text;

namespace WoerHause
{
    public class Helpers
    {
        public int GiveMeNumber()
        {
            SomeStructure stru = new SomeStructure();

            int number = 5;

            return number;

        }

        public enum ItemType
        {
            Glosery = 1,
            Clothing,
            Electronics,

        }
        public struct SomeStructure
        {
            private int numberForStructure;
            private string naemOfStructure;

            public SomeStructure(int number, string naeme)

            {
                numberForStructure = number;


            }

        }
    }
}
