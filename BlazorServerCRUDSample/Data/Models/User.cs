using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlazorServerCRUDSample.Data.Models
{
    /// <summary>
    /// ユーザーモデル
    /// </summary>
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "ユーザー名は必須です")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mailアドレスは必須です")]
        public string MailAddress { get; set; }

        [Required(ErrorMessage = "誕生日は必須です")]
        public DateTime BirthDay { get; set; }
    }
}
