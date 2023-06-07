using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BEN_VAN_CHUYEN
{
    internal class SignPdfFile
    {
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
                            var contentBytes = stamper.GetUnderContent(pageIndex);

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



        /* public static string ExtractStringSignatureFromPDF(string filePath)
         {
             // Load the PDF document
             using (var reader = new PdfReader(filePath))
             {
                 // Initialize an empty string to store the extracted signature
                 var signature = "";

                 // Get the total number of pages in the PDF document
                 int totalPages = reader.NumberOfPages;
                 MessageBox.Show(totalPages.ToString());
                 // Iterate over each page
                 for (int pageIndex = 1; pageIndex <= totalPages; pageIndex++)
                 {
                     // Get the content byte array of the current page
                     var contentBytes = reader.GetPageContent(pageIndex);

                     // Parse the content bytes to extract the text
                     var strategy = new SimpleTextExtractionStrategy();
                     var extractedText = PdfTextExtractor.GetTextFromPage(reader, pageIndex, strategy);

                     // Check if the extracted text contains the signature
                     if (extractedText.Contains("th1s 1s s1gnature:"))
                     {
                         // Extract the signature from the extracted text
                         // Adjust the extraction logic based on the structure of your signature
                         // For example, you can use regular expressions to extract a specific pattern
                         signature = extractedText;

                         // Exit the loop if the signature is found on the current page
                         break;
                     }
                 }

                 // Return the extracted signature
                 return signature;
             }
         }*/

        public static string ExtractStringSignatureFromPDF(string filePath)
        {
            // Load the PDF document
            using (var reader = new PdfReader(filePath))
            {
                // Initialize an empty string to store the extracted signature
                var signature = "";

                // Get the total number of pages in the PDF document
                int totalPages = reader.NumberOfPages;

                // Iterate over each page
                for (int pageIndex = 1; pageIndex <= totalPages; pageIndex++)
                {
                    // Get the content byte array of the current page
                    var contentBytes = reader.GetPageContent(pageIndex);

                    // Parse the content bytes to extract the text
                    var strategy = new SimpleTextExtractionStrategy();
                    var extractedText = PdfTextExtractor.GetTextFromPage(reader, pageIndex, strategy);

                    // Define the regular expression pattern to match the signature
                    var pattern = @"th1s 1s s1gnature: (.+)";

                    // Find the signature using the regular expression pattern
                    var match = Regex.Match(extractedText, pattern);

                    // Check if a match is found
                    if (match.Success)
                    {
                        // Extract the signature from the matched group
                        signature = match.Groups[1].Value.Trim();

                        // Exit the loop if the signature is found on the current page
                        break;
                    }
                }

                // Return the extracted signature
                return signature;
            }
        }


    }
}
