namespace StudentAPI.Models
{
    public class Students
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string Department { get; set; }
    }
}