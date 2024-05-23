namespace IntegrationProjectSample.DataAccess.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
    }
}
