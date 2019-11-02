namespace DataProvider.Infrastructure.Entity
{
    public class Projects:Entity
    {
        public string ProjectName { get; set; }

        public Country Country { get; set; }

        public Customer Customer { get; set; }
    }
}
