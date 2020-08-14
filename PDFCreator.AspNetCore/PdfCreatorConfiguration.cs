using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace PDFCreator.AspNetCore
{
    public class PdfCreatorConfiguration
    {
        internal static string PdfCreatorPath { get; private set; }

        public static void Setup(IWebHostEnvironment env, string wkthtmlToPdfRelativePath = "PDFCreator")
        {
            var pdfCreatorPath = Path.Combine(env.WebRootPath, wkthtmlToPdfRelativePath);
            if (!Directory.Exists(pdfCreatorPath))
            {
                throw new ApplicationException("Folder containing wkhtmltopdf.exe not found. Path in setup: " + pdfCreatorPath);
            }

            PdfCreatorPath = pdfCreatorPath;
        }
    }
}