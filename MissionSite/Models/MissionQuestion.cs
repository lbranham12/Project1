using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Models
{
    [Table("MissionQuestion")]
    public class MissionQuestion
    {
        [Key]
        [HiddenInput(DisplayValue= false)]
        public int missionQuestionID { get; set; }

        [HiddenInput(DisplayValue=false)]
        public int missionID { get; set; }

        [HiddenInput(DisplayValue=false)]
        public int userID { get; set; }

        [DisplayName("Question")]
        public string question { get; set; }

        [DisplayName("Answer")]
        public string answer { get; set; }

    }
}