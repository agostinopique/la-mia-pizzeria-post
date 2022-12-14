using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace la_mia_pizzeria_static.Models
{
    public class MoreThanFiveValidationAttribute : ValidationAttribute 
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null)
            {
                string data = (string)value;


                if (data.Split(' ').Count() < 5)
                {
                    return new ValidationResult("La descrizione deve essere di almeno 5 parole");
                }
            }
            

            return ValidationResult.Success;
        }

    }
}