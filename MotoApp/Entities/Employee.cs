
namespace MotoApp.Entities
{
    public class Employee : EntityBase
    {
        public string? Firstname { get; set; }

        public override string ToString() => $"Id:{Id}, FirstName:{Firstname}";
    }
}
