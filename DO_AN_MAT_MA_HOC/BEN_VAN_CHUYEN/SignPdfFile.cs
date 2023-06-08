using iText.Signatures;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography.X509Certificates;
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



        public static string ConvertPdfToString(string pdfPath)
        {
            StringBuilder text = new StringBuilder();
            PdfReader pdfReader = new PdfReader(pdfPath);

            for (int page = 1; page <= pdfReader.NumberOfPages; page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string currentPageText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);
                text.Append(currentPageText);
            }

            pdfReader.Close();
            return text.ToString();
        }
        public static void ConvertStringToPdf(string text, string outputFilePath)
        {
            using (Document document = new Document())
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputFilePath, FileMode.Create));
                document.Open();
                document.Add(new Paragraph(text));
            }
        }
        public static void AddStringToPdf(string inputFilePath, string outputFilePath, string additionalString)
        {
            // Read the input PDF file
            PdfReader reader = new PdfReader(inputFilePath);

            // Create a new PDF document
            Document document = new Document();

            // Create a PDF writer to write the modified content
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputFilePath, FileMode.Create));

            // Open the document
            document.Open();

            // Create a new content byte array
            PdfContentByte content = writer.DirectContent;

            // Loop through each page of the input PDF
            for (int pageNum = 1; pageNum <= reader.NumberOfPages; pageNum++)
            {
                // Import the page from the input PDF
                PdfImportedPage importedPage = writer.GetImportedPage(reader, pageNum);

                // Add the page to the new document
                document.NewPage();

                // Draw the imported page content onto the new document
                content.AddTemplate(importedPage, 0, 0);

                // Add the additional string to the new document
                ColumnText.ShowTextAligned(content, Element.ALIGN_LEFT, new Phrase(additionalString), 100, 100, 0);
            }

            // Close the document
            document.Close();

            // Close the reader
            reader.Close();
        }


        public string RemoveAndRetrieveLast64Bits(string inputFilePath)
        {
            // Read the input PDF file
            PdfReader reader = new PdfReader(inputFilePath);

            // Variable to store the last 64 bits
            string last64Bits = "";

            // Get the last 64 bits from the file
            if (reader.XrefSize > 0)
            {
                int lastObjNum = reader.XrefSize - 1;
                PdfObject lastObj = reader.GetPdfObject(lastObjNum);
                if (lastObj != null && lastObj.IsStream())
                {
                    PRStream stream = (PRStream)lastObj;
                    byte[] streamBytes = PdfReader.GetStreamBytes(stream);

                    // Check if the stream contains at least 8 bytes
                    if (streamBytes.Length >= 8)
                    {
                        // Get the last 64 bits (8 bytes) from the stream
                        byte[] last64BitsBytes = new byte[8];
                        Array.Copy(streamBytes, streamBytes.Length - 8, last64BitsBytes, 0, 8);
                        last64Bits = BitConverter.ToString(last64BitsBytes).Replace("-", "");

                        // Remove the last 64 bits from the stream
                        Array.Resize(ref streamBytes, streamBytes.Length - 8);
                        stream.Clear();
                        stream.SetData(streamBytes);
                    }
                }
            }

            // Close the reader
            reader.Close();

            // Return the last 64 bits as a hexadecimal string
            return last64Bits;
        }



    }
}
