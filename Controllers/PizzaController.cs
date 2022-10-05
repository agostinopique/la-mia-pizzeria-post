﻿using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        
        public List<Pizza> GeneratePizzas()
        {
            List<Pizza> pizzas = new List<Pizza> {
                        new Pizza("Margherita", "Pizza con pomodoro, mozzarella e basilico", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Pizza_Margherita_stu_spivack.jpg/1280px-Pizza_Margherita_stu_spivack.jpg", "5"),
                        new Pizza("Marinara", "Pizza con pomodoro, mozzarella e basilico", "https://www.buttalapasta.it/wp-content/uploads/2021/03/pizza-marinara.jpg","4"),
                        new Pizza("Napoli", "Pizza napoletana", "https://wips.plug.it/cips/buonissimo.org/cms/2012/07/pizza-napoli-5.jpg", "6,50"),
                        new Pizza("Wurstel", "pizza con pomodoro mozzarella e wurtel", "https://www.lospicchiodaglio.it/img/ricette/pizzawurstel.jpg", "6"),
                        new Pizza("Salamino piccante",  "Pizza con pomodoro, mozzarella e salamino piccante", "https://api.molinocasillo.com/wp-content/uploads/2020/07/pizza.jpg", "6"),
                        new Pizza("Maialona", "Pizza margherita con wurstel, salsiccia, salamino picccante", "https://media-cdn.tripadvisor.com/media/photo-s/13/a4/63/f8/pizza-maialona.jpg", "7")
                    };
            return pizzas;
        }

        public IActionResult Index()
        {
            List<Pizza> pizzas = GeneratePizzas(); 

            return View(pizzas);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> pizzas = GeneratePizzas();

            Pizza pizzaDetails= pizzas[id];

            return View(pizzaDetails);
        }
    }
}
