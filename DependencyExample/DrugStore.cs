namespace DependencyExample
{
    partial class Program
    {
        public class DrugStore
        {
            private readonly IRepository _repository;

            public DrugStore(IRepository repository)
            {
                _repository = repository;
            }
            public decimal GetAllGoodsValue()
            {
                return new HardwareCalculator(_repository).CalculateSum()+
                    new DrugCalculator(_repository).CalculateSum();
            } 
        }
    }
}
