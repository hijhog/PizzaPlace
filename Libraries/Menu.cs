using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libraries
{
   public class Menu
   {
      public List<Pizza> Pizzas { get; set; }

      public Pizza GetPizza(int id)
         => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
   }
}
