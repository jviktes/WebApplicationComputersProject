using WebApplicationComputersProject.Models;

namespace WebApplicationComputersProject.Services
{
    public class DataServices
    {
        

        public List<Computer> GetComputers ()
        {
            List<Computer> data = new List<Computer>();
            //fake data:
            for (int i = 0; i < 100; i++)
            {
                data.Add(new Computer() { ComputerId = i, ComputerDomain = $"domena_{i}.cz", ComputerName = $"PC-{i}", RealizedMigrationDate = RandomDay(), PlannedMigrationDate = RandomDay() });
            }

            return data;
        }

        public bool SavePlannedMigrationDate(int computerId, DateTime? dateTime) {
            //TODO - ulozeni do BD
            return true;
        }

        private DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(2022, 4, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
