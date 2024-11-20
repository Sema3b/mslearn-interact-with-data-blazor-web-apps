using System.Collections.Generic;

namespace BlazingPizza.Data
{
    public class PizzaService //eigentlicher Dienst 
    {
        public Task<PizzaItem[]> GetPizzasAsync() //async so that other code can be run while waiting for answer 
        {
            List<PizzaItem[]> pizzaItems = new List<PizzaItem[]>(); //list that holds arrays of type PizzaItem


            pizzaItems.AddRange(new List<PizzaItem[]> //Each added array can hold multiple PizzaItem-objects
            {
                //Add Arrays of type PizzaItem[]
                new PizzaItem[]
                {
                    new PizzaItem(){PizzaId= 1 ,Name="The Baconatorizor", Description="It has EVERY kind of bacon", Price=11.99M, Vegetarian = false, Vegan= false}
                },
                new PizzaItem[]
                {
                    new PizzaItem(){PizzaId= 2 ,Name="Buffalo chicken", Description="Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", Price=12.75M, Vegetarian = false, Vegan= false}
                },
                new PizzaItem[]
                {
                    new PizzaItem(){PizzaId= 3 ,Name="Veggie Delight", Description="It's like salad, but on a pizza", Price=11.5M, Vegetarian = true, Vegan= true}
                },
                new PizzaItem[]
                {
                    new PizzaItem(){PizzaId= 4 ,Name="Margherita", Description="Traditional Italian pizza with tomatoes and basil", Price=9.99M, Vegetarian = true, Vegan= false}
                },
                new PizzaItem[]
                {
                    new PizzaItem(){PizzaId= 5 ,Name="Basic Cheese Pizza", Description="It's cheesy and delicious. Why wouldn't you want one?", Price=11.99M, Vegetarian = true, Vegan= false}
                },
                new PizzaItem[]
                {
                    new PizzaItem(){PizzaId= 6 ,Name="Classic pepperoni", Description="It's the pizza you grew up with, but Blazing hot!", Price=10.5M, Vegetarian = false, Vegan= false}
                }
                //kann ich nicht gleich ein Array machen?
            });

            //create Array of type PizzaItem




            return null; //Rueckgabe soll Array sein, aber Arrays sind in einer Liste? Wozu brauch ich die Liste dann
                          
            // TODO: Array vom Typ Pizza zurueckgeben, in dem alle verfuegbaren Pizzen stehen

        }
    }
}
