namespace TaskManagement.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ManagerId { get; set; }
        public User Manager { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
