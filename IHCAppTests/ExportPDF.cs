using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelectPdf;

namespace IHCAppTests
{
    [TestClass]
    public class ExportPDF
    {
        [TestMethod]
        public void TestMethod1()
        {
            // instantiate the html to pdf converter 
            HtmlToPdf converter = new HtmlToPdf();

            // convert the url to pdf 
            PdfDocument doc = converter.ConvertUrl("URL**");

            var file = "This is the file path";
            // save pdf document 
            doc.Save(file);

            // close pdf document 
            doc.Close();
        }
    }
}
