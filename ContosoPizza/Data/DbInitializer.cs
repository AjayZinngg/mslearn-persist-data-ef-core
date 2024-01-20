using ContosoPizza.Models;

namespace ContosoPizza.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PizzaContext context)
        {
            if (context.Pizzas.Any()
                && context.Toppings.Any()
                && context.Sauces.Any())
            {
                return;
            }

            var paneerTopping = new Topping { Name = "Paneer", Calories = 80 };
            var cornTopping = new Topping { Name = "Corn", Calories = 40 };
            var blackOlivesTopping = new Topping { Name = "Black Olives", Calories = 50 };
            var jalapenoTopping = new Topping { Name = "Jalapeno", Calories = 80 };
            var sundriedTomatoTopping = new Topping { Name = "Sundried Tomato", Calories = 80 };

            var tomatoSauce = new Sauce { Name = "Tomato", IsVegan = true };
                var alfredoSauce = new Sauce { Name = "Alfredo", IsVegan = false };

                var pizzas = new Pizza[]
                {
                    new Pizza
                    {
                        Name = "Peppy Paneer",
                        Sauce = tomatoSauce,
                        Toppings = new List<Topping>
                        {
                            paneerTopping,
                            cornTopping,
                            sundriedTomatoTopping,
                        }
                    },
                    new Pizza
                    {
                        Name = "Farmhouse",
                        Sauce = tomatoSauce,
                        Toppings = new List<Topping>
                        {
                            paneerTopping,
                            cornTopping,
                            sundriedTomatoTopping,
                            blackOlivesTopping,
                            jalapenoTopping,
                        }
                    },
                    new Pizza
                    {
                        Name = "Veg Doubles",
                        Sauce = alfredoSauce,
                        Toppings = new List<Topping>
                        {
                            cornTopping,
                            sundriedTomatoTopping,
                        }
                    },
                };

                context.Pizzas.AddRange(pizzas);
                context.SaveChanges();
        }
    }
}