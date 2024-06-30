using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetSchool.Models
{
    public class Student
    {
        public int Id { get; set; }

        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Responsável")]
        public string GuardianName { get; set; }

        [DisplayName("Contato")]
        public string GuardianContact { get; set; }

        [DisplayName("Endereço")]
        public string Address { get; set; }
    }
}
