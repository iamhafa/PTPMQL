//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTPMQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public partial class Article
    {
        public string ArticleID { get; set; }
        public string Author { get; set; }
        [AllowHtml]
        public string ArticleContent { get; set; }
    }
}
