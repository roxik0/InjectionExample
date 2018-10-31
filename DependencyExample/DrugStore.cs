namespace DependencyExample
{
    partial class Program
    {
        public class DrugStore
        {
            private readonly IRepository _repository;
            private readonly IUserPrivileges _privileges;

            public DrugStore(IRepository repository, IUserPrivileges privileges)
            {
                _repository = repository;
                _privileges = privileges;
            }
            public decimal GetAllGoodsValue()
            {
                if (!_privileges.HasPrivileges()) return 0;
                return new HardwareCalculator(_repository).CalculateSum()+
                    new DrugCalculator(_repository).CalculateSum();
            } 
        }
    }
}
