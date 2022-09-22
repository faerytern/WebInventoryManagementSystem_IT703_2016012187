using System.ComponentModel.DataAnnotations;

namespace WebInventoryManagementSystem_IT703_2016012187.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [DataType(DataType.PhoneNumber)]
        [MinLength(8,ErrorMessage ="Phone numbers have to be a minimum of 8 characters.")]
        [MaxLength(11, ErrorMessage ="Phone numbers cant be more than 11 characters.")]
        [Phone]
        [DisplayFormat(DataFormatString = "{0:###-###-####}",ApplyFormatInEditMode = true)]
        public string Phone { get; set; }
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }
    }
}