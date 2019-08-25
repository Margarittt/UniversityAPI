using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UStudentAPI.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string University { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
    
    /*
    
    
    public class ResponseResult<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public List<Message<MessageType, string>> Messages { get; set; }
    }
    
    
    */
}
