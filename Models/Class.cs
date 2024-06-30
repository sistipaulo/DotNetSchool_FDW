using System.ComponentModel.DataAnnotations;

namespace DotNetSchool.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
