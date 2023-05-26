using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltYapi
{
    public class Hayvan
    {
        public string Tur { get; set; }

        public int Tag { get; set; }

        private int yas;
		public int Yas
		{
			get { return yas; }
			set 
			{
				if (value < 0 || value > 100)
					yas = 0;
				else
					yas = value;
			}
		}
        public Cinsiyet Cinsiyet { get; set; }


        public override string ToString()
        {
			return $"TUR: {this.Tur} YAS: {this.Yas} CİNSİYET: {Cinsiyet}";
        }

    }
}
