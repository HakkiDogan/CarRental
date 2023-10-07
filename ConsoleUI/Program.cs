
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new(new EfCarDal());

            foreach (var car in carManager.GetAllByColorId(2))
            {
                Console.WriteLine(car.Description);
            }
            //Console.WriteLine("Hello");
        }
    }
}