using Ninject;

namespace DependencyExample
{
    public class DrugCalculator
    {
        private readonly IRepository _repository;

        public DrugCalculator(IRepository repository)
        {
            _repository = repository;
        }
        public decimal CalculateSum()
        {
            var listOfGood = _repository.GetDrugs();
            decimal sum = 0;
            foreach (var item in listOfGood)
            {
                sum += item.Price;
            }
            return sum;
        }
    }
}