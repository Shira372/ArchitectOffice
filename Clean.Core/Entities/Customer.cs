namespace ArchitectsOffice.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }


        public Customer(int id, string name, int status)
        {
            Id = id;
            Name = name;
            Status = status;
        }
    }
}
