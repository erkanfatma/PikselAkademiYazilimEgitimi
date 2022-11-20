using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta9Ders3
{
    public class Person
    {
        //private int yas;
        //public int Yas
        //{
        //    get
        //    {
        //        return yas;
        //    }
        //    set
        //    {
        //     yas = value; 
        //    }
        //} 
        public int Yas { get; set; }
        public string AdiSoyadi { get; set; }
        public int DogumYili
        {
            get { return 2022 - Yas; }
        }
    }
}
