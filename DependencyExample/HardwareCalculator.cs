using System;
using System.Collections;

namespace DependencyExample
{
    public class HardwareCalculator
    {
        private readonly IRepository _repository;

        public HardwareCalculator()
        {
            
        }
       
        public HardwareCalculator(IRepository repository)
        {
            _repository = repository;
        }
        public decimal CalculateSum()
        {
            var listOfGood =_repository.GetHardware();
            decimal sum = 0;
            foreach (var item in listOfGood)
            {
                sum += item.Price;
            }
            return sum;
        }
    }
}
