using System;

namespace Löner
{
    public class PersonInkomst
    {
        public string namn;
        public int timlön;
        public int timmar;

        // En metod Lön
        public int Lön()
        {
            return timmar * timlön;
        }

    }
}