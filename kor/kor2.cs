using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        class kor2
        {
            // osztályváltozó
            private double sugár, kerület, terület;

            // konstruktorok

            public kor2(){}
            public kor2(double r)
            {
                this.sugár = r;
                számítások();
            }
            // metódusok
            public void SetSugár(double r)
            {
                this.sugár = r;
            }
            public void kalkKerület()
            {
                this.kerület = 2 * this.sugár * Math.PI;
            }
            
            private double kalkTerület(double r)
            {
                return Math.Pow(r, 2) * Math.PI;
            }
            private void számítások()
            {
                kalkKerület();
                this.terület = kalkTerület(this.sugár);
            }

            public double GetKerület()
            {
                return this.kerület;
            }
            public double GetTerület()
            {
                return this.terület;
            }
            public double GetSugár()
            {
                return this.sugár;
            }
    }
    }
