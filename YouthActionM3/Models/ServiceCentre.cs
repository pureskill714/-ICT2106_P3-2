using System.ComponentModel.DataAnnotations;
namespace YouthActionM3.Models
{
    public class ServiceCentre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? Manager { get; set; }
        public int NoOfProjects { get; set; }
        public int NoOfEmployees { get; set; }

    }
}
