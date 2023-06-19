using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
        [Display(Name = "Rok")]
        [Required,Range(1899, 2022, ErrorMessage = "Podaj rok z zakresu {1} i {2}")]
        public int? Year { get; set; }

		[Display(Name = "Imie")]
		[Required, StringLength(100)]
		public string? Name { get; set; }

        public bool Leap { get; set; }

		public string? AlertInfo { get; set; }
        public string? AlertStyle { get; set; }

        public FizzBuzzForm() {
            Leap = false;
            AlertInfo = "";
            AlertStyle = "invisible";
        }

        public void Check(){
            AlertInfo = Name;
            //Checking if name is female or male, but this method doesn't guarantee 100% right
            if (char.ToLower(Name[Name.Length-1]) == 'a') AlertInfo += " urodziła";
            else AlertInfo += " urodził ";

            AlertInfo += " się w " + Year + " roku. To";
            //Checking Leap year
            if (!(Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0)) AlertInfo += " nie";
            else Leap = true;

            AlertInfo += " był rok przestępny. ";
            AlertStyle = "alert alert-primary";

        }
    }
}