using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDFService.Dto
{
    [Table("Settings")]
    public sealed class AppSettingRecord
    {
        /// <summary>
        /// Primary key of the Settings table
        /// </summary>
        public short SettingID { get; set; }

        /// <summary>
        /// Name of setting
        /// </summary>
        public string Setting { get; set; }

        /// <summary>
        /// Textual presentation of a setting value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Used to group the various settings into logical hierarchy
        /// </summary>
        public short? ParentID { get; set; }
    }
}