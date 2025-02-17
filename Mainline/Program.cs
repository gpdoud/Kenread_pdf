//
// add-package iText7
//
using iText.Kernel.Pdf; 
using iText.Kernel.Pdf.Canvas.Parser;

const string pdfPath = "C:\\repos\\Kenread_pdf\\Mainline\\2-Git-Github-ADO-v1.pdf";

GetPdfPageCount(pdfPath);

static void GetPdfPageCount(string pdfPath)
{
    using (PdfReader reader = new PdfReader(pdfPath))
    using (PdfDocument pdfDoc = new PdfDocument(reader))
    {
        int numberOfPages = pdfDoc.GetNumberOfPages();
        Console.WriteLine($"The PDF has {numberOfPages} pages.");
    }
}