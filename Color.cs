using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
//    №4
//შექმენით სტატიკური კლასი void Print(string line, int color) მეთოდით,
//რომელაც გამოაქვს ეკრანზე line ტექსტი მოცემული ფერით.გამოიყენეთ enum ჩამონათვალი
//მომხმარებლისთვის ფერის არჩევის უფლების მისაცემად.
//მომხმარებელს მიეცით საშუალება შეიყვანოს ტექსტი და ფერი, რომლითაც უნდა რომ ეს ტექსტი იყოს გამოტანილი ეკრანზე
        
    internal static class Color
    {
        public static void Print(string line, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color; Console.WriteLine(line);
            
        }
    }

}
