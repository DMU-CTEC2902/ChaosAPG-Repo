using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReviewMVC.Models
{
    public class UserModel
    {
        public virtual int UserID { get; set; }
        public virtual string UserName { get; set; }
        public virtual DateTime JoinDate { get; set; }
    }
}