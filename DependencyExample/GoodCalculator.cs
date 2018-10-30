using System;
using System.Collections;

namespace DependencyExample
{
    public class GoodCalculator
    {
        private readonly IGoodRepository _goodRepository;

        public GoodCalculator(IGoodRepository goodRepository)
        {
            _goodRepository = goodRepository;
        }
        public decimal CalculateSum()
        {
            var listOfGood =_goodRepository.GetGoods();
            decimal sum = 0;
            foreach (var item in listOfGood)
            {
                sum += item.Price;
            }
            return sum;
        }
    }
}
