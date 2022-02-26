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

        [Required]
        public string UserName { get; set; }

        public string MailAddress { get; set; }

        public DateTime BirthDay { get; set; }
    }
}
