using System;

using System.Collections.Generic;

namespace Collection.induk
{
    public abstract class Elektronik
    {
        public abstract string Prosesor { get; set; }
		public abstract string Merk { get; set; }
        public abstract string Ram {get; set;}
        public abstract string Ukuran {get; set;}
        public double Harga{get; set;}
        public abstract string ID { get; set; }
    }
}

