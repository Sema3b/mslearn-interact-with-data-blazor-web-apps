namespace BlazingPizza.Data //DB that contains available pizzas which are later shown on site
{
    public class PizzaItem //class that contains all needed objects for a pizza
    {
        public int PizzaId {  get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }
    }
}
