using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.ComponentModel;
using System.Web.Mvc;
using WebPortal.Models;

namespace WebPortal.Models
{
    public class MaterijalPoPredmetu
    {
      

        [Key,ForeignKey("MaterijalModel"),Column(Order =0)]
        public int MaterijalModelId { get; set; }
        [Key,ForeignKey("PredmetModel"),Column(Order = 1)]
        public int PredmetModelId { get; set; }

        public MaterijalModel MaterijalModel { get; set; }
        public PredmetModel PredmetModel { get; set; }
    }
}