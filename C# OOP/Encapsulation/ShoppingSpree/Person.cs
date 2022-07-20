namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private int money;
        private List<string> bagOfProducts;

        public Person()
        {
            this.bagOfProducts = new List<string>();
        }

        public Person(string name, int money)
            : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public int Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new Exception($"{this.Name} can't afford {product.Name}");
            }

            this.Money -= product.Cost;
            this.bagOfProducts.Add(product.Name);
        }

        public string BagOfProducts(Person person)
        {
            if (this.bagOfProducts.Count > 0)
            {
                return string.Join(", ", this.bagOfProducts);
            }
            else
            {
                return "Nothing bought";
            }


        }
    }
}
