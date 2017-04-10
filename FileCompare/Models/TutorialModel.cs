using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutorial.FileUpload.Models
{
    public class FileCompareModel
    {
		public HttpPostedFileBase Attachment1 { get; set; }
		public HttpPostedFileBase Attachment2 { get; set; }
	}
}