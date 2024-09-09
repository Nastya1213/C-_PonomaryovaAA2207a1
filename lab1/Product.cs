using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public abstract class Product
    {
        public string Name { get; set; }
        public virtual decimal Price { get; set; }

        protected Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public abstract string GetInformation();

        
    }
    public class Toy : Product
    {
        public string AgeGroup { get; set; }
        public override decimal Price
        {
            get
            {
                decimal additionalDiscount = 5; 
                return base.Price * (1 - additionalDiscount / 100);
            }
        }
        public Toy(string name, decimal price, string ageGroup)
            : base(name, price)
        {
            AgeGroup = ageGroup;
        }

        public override string GetInformation()
        {
            return $"Toy: {Name}, Price: {Price}rub, Age Group: {AgeGroup}";
        }
    }
    public class Meat : Product
    {
        public string MeatType { get; set; }
        public override decimal Price
        {
            get
            {
                decimal additionalDiscount = 10;
                return base.Price * (1 - additionalDiscount / 100);
            }
        }
        public Meat(string name, decimal price, string meatType)
            : base(name, price)
        {
            MeatType = meatType;
        }

        public override string GetInformation()
        {
            return $"Meat: {Name}, Price: {Price}rub, Type: {MeatType}";
        }
    }
    public class Drinks : Product
    {
        public bool IsAlcoholic { get; set; }
        public override decimal Price
        {
            get
            {
                decimal additionalDiscount = 3; 
                return base.Price * (1 - additionalDiscount / 100);
            }
        }
        public Drinks(string name, decimal price, bool isAlcoholic)
            : base(name, price)
        {
            IsAlcoholic = isAlcoholic;
        }

        public override string GetInformation()
        {
            return $"Drink: {Name}, Price: {Price}rub, Alcoholic: {IsAlcoholic}";
        }
    }
    public class Electronics : Product
    {
        public string WarrantyPeriod { get; set; }
        public override decimal Price
        {
            get
            {
                decimal additionalDiscount = 15; 
                return base.Price * (1 - additionalDiscount / 100);
            }
        }
        public Electronics(string name, decimal price, string warrantyPeriod)
            : base(name, price)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public override string GetInformation()
        {
            return $"Electronics: {Name}, Price: {Price}rub, Warranty: {WarrantyPeriod}";
        }
    }
    public class Bread : Product
    {
        public string BreadType { get; set; }
        public DateTime ExpiryDate { get; set; }
        public override decimal Price
        {
            get
            {
                decimal additionalDiscount = 2;
                return base.Price * (1 - additionalDiscount / 100);
            }
        }
        public Bread(string name, decimal price, string breadType, DateTime expiryDate)
            : base(name, price)
        {
            BreadType = breadType;
            ExpiryDate = expiryDate;
        }

        public override string GetInformation()
        {
            return $"Bread: {Name}, Price: {Price}rub, Type: {BreadType}, Expiry Date: {ExpiryDate:MM/dd/yyyy}";
        }
    }
}
