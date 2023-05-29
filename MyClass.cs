using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{

//    №3
//შექმენით კლასი MyClass და სტრუქტურა MyStruct, რომლებიც შეიცავენ public string change ცვლადს.
//მთავარ კლასში შექმენით ორი მეთოდი
//* static void ClassTaker(MyClass myClass), რომელიც მიანიჭებს myClass-ის ველ change-ს მნიშვნელობას "Changed"
//* static void StructTaker(MyStruct myStruct), რომელიც მიანიჭებს myStruct-ის ველ change-ს მნიშვნელობას "Changed"
//შექმენით ორივე კლასის ობიექტი, გამოიძახეთ ეს მეთოდები ამ ობიექტების გადაცემით და დაბეჭდეთ მონაცემები მეთოდების მუშაობის შემდეგ,
//გააანალიზეთ მიღებული შედეგი.

    internal class MyClass
    {
        public string change { get; set; }

    }

    internal struct MyStruct
    {
        public string change { get; set; }
    }

}
