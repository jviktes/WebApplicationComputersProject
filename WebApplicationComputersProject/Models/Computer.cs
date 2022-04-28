namespace WebApplicationComputersProject.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }
        public string ComputerName { get; set; }
        public string ComputerDomain { get; set; }
        public DateTime? PlannedMigrationDate { get; set; }
        public DateTime? RealizedMigrationDate { get; set; }

    }
}
