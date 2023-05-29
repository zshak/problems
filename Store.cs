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
    internal class Store
    {
        private List<Article> Articles { get; set; }

        
        public String this[string item]
        {
            get
            {
                foreach (var article in Articles)
                {
                    return article.ToString();
                }
                return "No Value";
            }
        }

    }
}
