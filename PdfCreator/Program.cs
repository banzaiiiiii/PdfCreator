using Spire.Pdf;
using Spire.Pdf.Fields;
using Spire.Pdf.Graphics;
using Spire.Pdf.Graphics.Fonts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfDocument pdf = new PdfDocument();
            pdf.LoadFromFile(@"C:/Users/robin/desktop/Swaebisch_Hall_AussenOhneFooter.pdf");



            PdfPageBase page = pdf.Pages[1];
            // Adding Source Sans pro test
            PdfTrueTypeFont trueTypeFont = new PdfTrueTypeFont(new Font("SourceSansPro", 8.7f, FontStyle.Regular));

            // getting the used fonts



            PdfGraphicsState state = page.Canvas.Save();
            //draw rectangles
            PdfPen pen = new PdfPen(Color.Black, 0.5f);

            page.Canvas.DrawRectangle(pen, new Rectangle(new Point(18, 450), new Size(269, 60)));
            page.Canvas.DrawRectangle(pen, new Rectangle(new Point(300, 450), new Size(269, 60)));

            //restor graphics
            page.Canvas.Restore(state);


            PdfBrush brush = PdfBrushes.Black;
            float x = 22;
            float y = 458;


            string text = "Ort, Datum";
            page.Canvas.DrawString(text, trueTypeFont, brush, x, y);
            PdfTextBoxField textbox = new PdfTextBoxField(page, "OrtDatum");
            textbox.Bounds = new RectangleF(22f, 480f, 100, 22);
            textbox.BorderWidth = 1f;
            textbox.BorderStyle = PdfBorderStyle.Solid;
            pdf.Form.Fields.Add(textbox);

            string text2 = "Unterschrift des Besichtigers";
            page.Canvas.DrawString(text2, trueTypeFont, brush, 304, y);

            pdf.SaveToFile(@"C:/Users/robin/desktop/test123.pdf");
            System.Diagnostics.Process.Start(@"C:/Users/robin/desktop/test123.pdf");



        }
    }
}
