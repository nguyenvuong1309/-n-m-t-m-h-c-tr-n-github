using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEN_VAN_CHUYEN
{
    public class removeSignaturePdfFile
    {
        public static void AddSignatureToPdf(string inputFilePath, string outputFilePath, string signatureText)
        {
            PdfReader reader = new PdfReader(inputFilePath);
            using (FileStream fs = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            {
                PdfStamper stamper = new PdfStamper(reader, fs);
                int pageCount = reader.NumberOfPages;

                for (int i = 1; i <= pageCount; i++)
                {
                    PdfContentByte content = stamper.GetOverContent(i);
                    ColumnText.ShowTextAligned(content, Element.ALIGN_CENTER, new Phrase(signatureText), 300, 50, 0);
                }

                stamper.Close();
            }
        }

        public static void RemoveSignatureFromPdf(string inputFilePath, string signatureText)
        {
            PdfReader reader = new PdfReader(inputFilePath);
            using (FileStream fs = new FileStream(inputFilePath + ".tmp", FileMode.Create, FileAccess.Write))
            {
                PdfStamper stamper = new PdfStamper(reader, fs);
                int pageCount = reader.NumberOfPages;

                for (int i = 1; i <= pageCount; i++)
                {
                    PdfDictionary pageDict = reader.GetPageN(i);
                    PdfArray annotsArray = pageDict.GetAsArray(PdfName.ANNOTS);
                    if (annotsArray == null)
                        continue;

                    for (int j = 0; j < annotsArray.Size; j++)
                    {
                        PdfDictionary annotDict = annotsArray.GetAsDict(j);
                        PdfString content = annotDict.GetAsString(PdfName.CONTENTS);
                        if (content != null && content.ToString().Contains(signatureText))
                        {
                            annotsArray.Remove(j);
                            j--;
                        }
                    }
                }

                stamper.Close();
            }

            File.Delete(inputFilePath);
            File.Move(inputFilePath + ".tmp", inputFilePath);
        }
        /*
                public static void RemoveStringSignatureFromPDF(string inputFilePath, string outputFilePath, string signature)
                {
                    // Load the PDF document
                    using (var reader = new PdfReader(inputFilePath))
                    {
                        // Create a temporary file to write the modified PDF content
                        using (var fileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                        {
                            // Create a PDF stamper to modify the PDF
                            using (var stamper = new PdfStamper(reader, fileStream))
                            {
                                // Get the total number of pages in the PDF document
                                int totalPages = reader.NumberOfPages;

                                // Iterate over each page
                                for (int pageIndex = 1; pageIndex <= totalPages; pageIndex++)
                                {
                                    // Create a new graphics state
                                    var graphicsState = new PdfGState();
                                    graphicsState.FillOpacity = 0.5f;

                                    // Get the content byte array of the current page
                                    var contentBytes = stamper.GetUnderContent(pageIndex);

                                    // Clear the existing content from the content byte array
                                    contentBytes.SetLiteral("Q");

                                    // Set the graphics state on the content byte array
                                    contentBytes.SetGState(graphicsState);

                                    // Begin text mode
                                    contentBytes.BeginText();

                                    // Create a BaseFont for the signature text
                                    var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                                    // Set the font and font size for the signature text
                                    contentBytes.SetFontAndSize(baseFont, 12);

                                    // Set the position where the signature text will be placed
                                    contentBytes.SetTextMatrix(100, 100);

                                    // Extract the existing text from the content byte array
                                    var existingText = PdfTextExtractor.GetTextFromPage(reader, pageIndex, new SimpleTextExtractionStrategy());

                                    // Remove the signature text from the existing text
                                    var updatedText = existingText.Replace(signature, "");

                                    // Show the updated text
                                    contentBytes.ShowText(updatedText);

                                    // End text mode
                                    contentBytes.EndText();
                                }
                            }
                        }
                    }
                }*/


        public static void AddStringSignatureToPDF(string inputFilePath, string outputFilePath, string signature)
        {
            // Load the PDF document
            using (var reader = new PdfReader(inputFilePath))
            {
                // Create a temporary file to write the modified PDF content
                using (var fileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                {
                    // Create a PDF stamper to modify the PDF
                    using (var stamper = new PdfStamper(reader, fileStream))
                    {
                        // Get the total number of pages in the PDF document
                        int totalPages = reader.NumberOfPages;

                        // Iterate over each page
                        for (int pageIndex = 1; pageIndex <= totalPages; pageIndex++)
                        {
                            // Get the content byte array of the current page
                            var contentBytes = stamper.GetOverContent(pageIndex);

                            // Create a BaseFont for the signature text
                            var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                            // Create a new graphics state
                            var graphicsState = new PdfGState();
                            graphicsState.FillOpacity = 0.5f;

                            // Set the graphics state on the content byte array
                            contentBytes.SetGState(graphicsState);

                            // Begin text mode
                            contentBytes.BeginText();

                            // Set the font and font size for the signature text
                            contentBytes.SetFontAndSize(baseFont, 12);

                            // Set the position where the signature text will be placed
                            contentBytes.SetTextMatrix(100, 100);

                            // Show the signature text
                            contentBytes.ShowText(signature);

                            // End text mode
                            contentBytes.EndText();
                        }
                    }
                }
            }
        }


    }
}
