namespace DependencyExample
{
    partial class Program
    {
        public class DrugStore
        {
            public decimal GetAllGoodsValue()
            {
                return new HardwareCalculator(new Database()).CalculateSum()+
                    new DrugCalculator(new Database()).CalculateSum();
            } 
        }
    }
}
