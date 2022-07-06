using Domain.Entities.BookAggregation;
using Domain.Entities.PersonAggregation;
using Domain.Entities.PersonAggregation.Enums;
using System;

namespace LibraryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Andre", "Neto", "andre.neto@iatec.com", Genre.Male);
            Console.WriteLine("Executado com sucesso.");

            Console.WriteLine("andre2neto".IndexOf("@"));
        }
    }
}
