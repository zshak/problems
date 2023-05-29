using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    //№1
    //შექმენით კლასი Article, რომელიც შეიცავს შემდეგ დახურულ ველებს
    //* ნივთის სახელი
    //* იმ მაღაზიის სახელი, რომელშიც იყიდება ნივთის
    //* ღირებულება ლარებში
    //შექმენით კლასი Store, რომელიც შეიცავს დახურულ Article ტიპის ელემენტების მასივს
    //და შეასრულეთ შემდეგი
    //* Store კლასში უზრუნველყავით შესაძლებლობა ელემენტის ამოღების ინდექსის მიხედვით ( გამოიყენეთ ინდექსატორი, ინდექსი იყოს ნივთის სახელი)
    //*ეკრანზე იმ ნივთის შესახებ ინფორმაციის გამოტანა, რომლის სახელიც იყო შეყვანილი კლავიატურიდან, თუ მსგავსი ნივთი არ არსებობს, გამოიტანეთ შესაბამისი შეტყობინება
    //დაწერეთ პროგრამა, რომელიც გამოიტანს ინფორმაცის ნივთის შესახებ
    //P.S მოახდინეთ ინდექსატორის ვალიდაცია
    internal class Article
    {
        private int ItemName { get; set;}
        private string StoreName { get; set;}
        private double Price { get; set; }

        public int GetItemName()
        {
            return ItemName;
        }

        public void SetItemName(int val)
        {
            this.ItemName = val;
        }

        public String GetStoreName()
        {
            return StoreName;
        }

        public void SetStoreName(String val)
        {
            this.StoreName = val;
        }
        
        public Double GetPrice()
        {
            return Price;
        }

        public void SetPrice(double val)
        {
            this.Price = val;
        }
        public override string ToString()
        {
            
            return ("ItemName: " + this.ItemName + "\nStoreName: " + this.StoreName + "\nPrice: " + this.Price);
        }
    }
}
