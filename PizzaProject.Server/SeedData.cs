namespace PizzaProject.Server
{
    public static class SeedData
    {
        public static void Initialize(PizzaStoreContext db)
        {
            var toppings = new Topping[]
            {
                new Topping()
                {
                    Name = "Допълнително сирене",
                    Price = 1.50m,
                },
                new Topping()
                {
                    Name = "Американски бекон",
                    Price = 1.99m,
                },
                new Topping()
                {
                    Name = "Британски бекон",
                    Price = 1.99m,
                },
                new Topping()
                {
                    Name = "Канадски бекон",
                    Price = 1.99m,
                },
                new Topping()
                {
                    Name = "чай с бисквити",
                    Price = 3.00m
                },
                new Topping()
                {
                    Name = "Прясно изпечени котлети",
                    Price = 3.50m,
                },
                new Topping()
                {
                    Name = "Камби",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Лук",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Гъби",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Пеперони",
                    Price = 1.00m,
                },
                new Topping()
                {
                    Name = "Патешко месо",
                    Price = 2.20m,
                },
                new Topping()
                {
                    Name = "Кюфтенца",
                    Price = 1.50m,
                },
                new Topping()
                {
                    Name = "Омар",
                    Price = 44.50m,
                },
                new Topping()
                {
                    Name = "Хайвер",
                    Price = 80.75m,
                },
                new Topping()
                {
                    Name = "Артишок",
                    Price = 2.40m,
                },
                new Topping()
                {
                    Name = "Пресни домати",
                    Price = 0.50m,
                },
                new Topping()
                {
                    Name = "Босилек",
                    Price = 0.50m,
                },
                new Topping()
                {
                    Name = "Пържола (medium-rare)",
                    Price = 8.50m,
                },
                new Topping()
                {
                    Name = "Люти чушки",
                    Price = 2.20m,
                },
                new Topping()
                {
                    Name = "Buffalo chicken",
                    Price = 5.00m,
                },
                new Topping()
                {
                    Name = "Синьо сирене",
                    Price = 1.50m,
                },
            };

            var specials = new PizzaSpecial[]
            {
                new PizzaSpecial()
                {
                    Name = "Basic Cheese Pizza",
                    Description = "Много вкусна. Защо не си вземеш една?",
                    BasePrice = 9.99m,
                    ImageUrl = "img/pizzas/cheese.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 2,
                    Name = "The Baconatorizor",
                    Description = "Има ВСЕКИ вид бекон",
                    BasePrice = 11.99m,
                    ImageUrl = "img/pizzas/bacon.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 3,
                    Name = "Classic pepperoni",
                    Description = "Пицата от твоето детство, но с повече люто!",
                    BasePrice = 10.50m,
                    ImageUrl = "img/pizzas/pepperoni.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 4,
                    Name = "Buffalo chicken",
                    Description = "Пикантно пилешко едно от най-добрите",
                    BasePrice = 12.75m,
                    ImageUrl = "img/pizzas/meaty.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 5,
                    Name = "Mushroom Lovers",
                    Description = "Има гъби.Очевидно",
                    BasePrice = 11.00m,
                    ImageUrl = "img/pizzas/mushroom.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 6,
                    Name = "Veggie Delight",
                    Description = "Като салата, но върху пица",
                    BasePrice = 11.50m,
                    ImageUrl = "img/pizzas/salad.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 7,
                    Name = "Margarita",
                    Description = "Традиционна италианска пица с домати и босилек",
                    BasePrice = 9.99m,
                    ImageUrl = "img/pizzas/margherita.jpg",
                },
            };

            db.Toppings.AddRange(toppings);
            db.Specials.AddRange(specials);
            db.SaveChanges();
        }
    }
}
