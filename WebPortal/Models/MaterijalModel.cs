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
    /// <summary>
    /// Ovo je klasa Ucenik
    /// </summary>
    public class MaterijalModel
    {

        /// <summary>
        /// Deklaracija svojstva materijalId.
        /// </summary>
        /// <value>
        /// materijalId identifikator.Int
        /// </value>
        [Key]
        public int materijalId { get; set; }

        /// <summary>
        /// Deklaracija svojstva materijalFile.
        /// </summary>
        /// <value>
        /// materijal file.Byte[]
        /// </value>
        [DisplayName("Materijal")]
        [MaxLength]
        public byte[] materijalFile { get; set; }

        /// <summary>
        /// Deklaracija svojstva MIME tipa fajla.
        /// </summary>
        /// <value>
        /// MIME tip fajla.String
        /// </value>
        [HiddenInput(DisplayValue = false)]
        public string fileMimeType { get; set; }

        //[DataType(DataType.MultilineText)]
        //public string opisMaterijal { get; set; }

        //[DataType(DataType.DateTime)]
        //[DisplayName("Created Date")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        //public DateTime CreatedDate { get; set; }


        //public string UserName { get; set; }


        /// <summary>
        /// Deklaracija svojstva materijalEkstenzija.
        /// </summary>
        /// <value>
        /// materijal ekstenzija.String
        /// </value>
        public string materijalEkstenzija { get; set; }

        /// <summary>
        /// Deklaracija svojstva materijalNaziv.
        /// </summary>
        /// <value>
        /// materijalNaziv.String
        /// </value>
        public string materijalNaziv { get; set; }

    }
}