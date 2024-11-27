using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğitimKampı301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}

/*
 Field-Veriable-Property
 */
/*
 int x; şeklinde sınıfın içine tanımlanırsa Field olur.
public int y {get;set;} olursa property olur.
void test()
        {
            int z; şeklinde metod olarak tanımlanırsa veriable olur.
        }
 */