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
    [Table("Mission")]
    public class Mission
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int missionID { get; set; }

        [DisplayName("Mission Name")]
        public string missionName { get; set; }

        [DisplayName("Mission Presidents Name")]
        public string missionPres { get; set; }

        [DisplayName("Mission Address")]
        public string missionAddress { get; set; }

        [DisplayName("Mission Language")]
        public string language { get; set; }

        [DisplayName("Mission Climate")]
        public string climate { get; set; }

        [DisplayName("Dominate Religion")]
        public string dominateReligion { get; set; }

        [DisplayName("Mission Flag")]
        public string flag { get; set; }

    }
}