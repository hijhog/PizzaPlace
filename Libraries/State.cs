using System.Linq;

namespace Libraries
{
    public class State
    {
        public Menu Menu { get; set; } = new Menu();
        public Basket Basket { get; set; } = new Basket();
        public UI UI { get; set; } = new UI();
        public decimal TotalPrice
            => Basket.Orders.Sum(id => Menu.GetPizza(id).Price);
    }
}
