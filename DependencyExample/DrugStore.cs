namespace DependencyExample
{
    partial class Program
    {
        public class DrugStore
        {
            public decimal GetAllGoodsValue()
            {
                return new HardwareCalculator(new AzureDatabase()).CalculateSum()+
                    new DrugCalculator(new AzureDatabase()).CalculateSum();
            } 
        }
    }
}
