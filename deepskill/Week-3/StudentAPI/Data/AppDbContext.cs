using StudentAPI.Models;

namespace StudentAPI.Data
{
    public class AppDbContext
    {
        public List<Student> Students { get; set; }

        public AppDbContext()
        {
            Students = new List<Student>();
        }
    }
}
