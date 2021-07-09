using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTrainingJuli.Pages.Modul5
{
    public class Person
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="da muss was rein")]
        [Range(150,200,ErrorMessage ="keine Achterbahn")]
        public double Gross { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        [StringLength(maximumLength:20,ErrorMessage ="reicht kurz 20 Zeichen")]
        public string Name { get; set; }
        public DateTime GebDat { get; set; }
    }
}
