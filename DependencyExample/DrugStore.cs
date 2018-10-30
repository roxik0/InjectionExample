namespace DependencyExample
{
    partial class Program
    {
        public class DrugStore
        {
            public decimal GetAllGoodsValue()
            {
                return new HardwareCalculator(new MsSqlDatabase()).CalculateSum()+
                    new DrugCalculator(new MsSqlDatabase()).CalculateSum();
            } 
        }
    }
}
