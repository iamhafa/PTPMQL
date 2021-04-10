using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTPMQL.Models
{
    [Table("CheckAccounts")]
    public class CheckAccount
    {
        [Key]
        [Required(ErrorMessage = "UserName không được để trống")]
        public string CheckUserName { get; set; }
        [Required(ErrorMessage = "Password không được để trống")]
        [DataType(DataType.Password)]
        public string CheckPassword { get; set; }
    }
}