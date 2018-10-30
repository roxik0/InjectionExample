namespace DependencyExample
{
    partial class Program
    {
        public class DrugStore
        {
            public decimal GetAllGoodsValue()
            {
                return new HardwareCalculator(ApplicationDependency.CurrentRepository).CalculateSum()+
                    new DrugCalculator(ApplicationDependency.CurrentRepository).CalculateSum();
            } 
        }
    }
}
