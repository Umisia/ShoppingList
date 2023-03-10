namespace SimpleShoppingList.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleShoppingList.Data.SimpleShoppingListContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleShoppingList.Data.SimpleShoppingListContext context)
        {
            context.ShoppingLists.AddOrUpdate(
                new Models.ShoppingList
                {
                    Name = "groceries",
                    Items =
                    {
                        new Models.Item {Name = "milk"},
                        new Models.Item {Name = "cos"},
                        new Models.Item {Name = "cos znow"},
                    }
                },
                    new Models.ShoppingList
                    {
                        Name = "Hardware"
                    }
                );
        }
    }
}
