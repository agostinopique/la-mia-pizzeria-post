using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{

    [Table("Pizze")]
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "IL nome inserito è troppo lungo!")]
        public string Name { get; set; }

        //[Required]
        [StringLength(25, ErrorMessage = "La descrizione è troppo lunga!")]
        [MoreThanFiveValidation]
        public string Description { get; set; }

        [Required]
        public string Picture { get; set; }

        [Required]
        [Range(1, 25, ErrorMessage = "Inserisci un prezzo valido (tra 1 e 25 euro)")]
        public string Price { get; set; }


        public Pizza()
        {

        }
        public Pizza(string name, string description, string picture, string price)
        {
            int id = 0;
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Picture = picture;
            this.Price = price;
            id++;
        }
    }
}