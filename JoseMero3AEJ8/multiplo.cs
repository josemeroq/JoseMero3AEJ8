using System;
using System.Collections.Generic;
using System.Text;

namespace JoseMero3AEJ8
{
    public class multiplo
    {
        private int m { get; set; }
        public multiplo()
        {
            this.m = 1;
            
        }
        public void procesomultiplo()
        {
            m = m - 1;
            do
            {
                m = m + 3;
                Console.WriteLine(m);
            } while (m != 3000);
        }
        
    }
}
