using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.ComponentModel;
using System.Web.Mvc;

namespace WebPortal.Models
{
    public class MaterijalModel
    {

        [Key]
        public int materijalId { get; set; }

        [DisplayName("Materijal")]
        [MaxLength]
        public byte[] materijalFile { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string fileMimeType { get; set; }

        //[DataType(DataType.MultilineText)]
        public string materijalOpis { get; set; }

        //[DataType(DataType.DateTime)]
        //[DisplayName("Created Date")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        //public DateTime CreatedDate { get; set; }


        //public string UserName { get; set; }


        public string materijalEkstenzija { get; set; }

        public string materijalNaziv { get; set; }

    }
}