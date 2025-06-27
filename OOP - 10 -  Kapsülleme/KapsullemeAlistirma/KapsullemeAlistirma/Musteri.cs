using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeAlistirma
{
    internal class Musteri
    {
        public Musteri() 
        { 
        
        }

        private string _tckimliknumarasi;

        public string TCKimlikNumarasi 
        {
            get
            {
              return _tckimliknumarasi.Substring(0, 3); 
            }

            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (karakterKontrol)
                        {
                            // sayisal deger demektir
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }

                    if (bayrak)
                    {
                        Console.WriteLine("TC Kimlik Numarasi icindeki degerler sayisal olmalidir...");
                    }
                    else
                    {
                        this._tckimliknumarasi = value;
                    }
                }
                else 
                {
                    Console.WriteLine("TC Kimlik Numarasi 11 Hane Olmalidir...");
                }
            }
        }
    }

}
