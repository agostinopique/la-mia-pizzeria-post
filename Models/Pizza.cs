using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{

    [Table("Pizze")]
    public class Pizza
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Price { get; set; }

       public Pizza(string name, string description, string picture, string price)
        {
            this.Name = name;
            this.Description = description;
            this.Picture = picture;
            this.Price = price;
        }
    }
}