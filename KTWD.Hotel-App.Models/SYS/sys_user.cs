using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace KTWD.Hotel_App.Models.SYS
{
    [Table("sys_user")]
    public class sys_user
    {
        /// <summary>
        /// user_id
        /// </summary>		
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string user_id { get; set; }
        /// <summary>
        /// user_name
        /// </summary>		
        public string user_name { get; set; }
        /// <summary>
        /// mobile
        /// </summary>		
        public string mobile { get; set; }
        /// <summary>
        /// weixin
        /// </summary>		
        public string weixin { get; set; }
        /// <summary>
        /// email
        /// </summary>		
        public string email { get; set; }
        /// <summary>
        /// pwd
        /// </summary>		
        public string pwd { get; set; }
        /// <summary>
        /// last_login_time
        /// </summary>		
        public string last_login_time { get; set; }
        /// <summary>
        /// org_id
        /// </summary>		
        public int org_id { get; set; }
        /// <summary>
        /// updatedAt
        /// </summary>		
        public DateTime updatedAt { get; set; }
        /// <summary>
        /// createdAt
        /// </summary>		
        public DateTime createdAt { get; set; }
        /// <summary>
        /// isvalid
        /// </summary>		
        public bool isvalid { get; set; }

        public string roleids { get; set; }

    }
}

