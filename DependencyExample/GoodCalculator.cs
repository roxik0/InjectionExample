using System;

namespace DependencyExample
{
    public class GoodCalculator
    {
        public GoodCalculator()
        {
           
        }
        public void Calculate()
        {
            var listOfGood =new Database().GetGoods();
            decimal sum = 0;
            foreach (var item in listOfGood)
            {
                sum += item.Price;
            }
            Console.WriteLine(sum);
        }
    }
}
