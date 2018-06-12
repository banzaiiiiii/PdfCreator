using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Widget;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfCreator
{
    class Creator
    {
        
            

            PdfDocument pdf = new PdfDocument();


            public PdfPageBase page { get; set; }
            public PdfTrueTypeFont font { get; set; }
            public PdfBrush brush { get; set; }
            public PdfPen pen { get; set; }
            public PdfMargins margin { get; set; }


            // page Operationen

            public void addNewPage()
            {
                page = pdf.Pages.Add(PdfPageSize.A4, margin);
            }

            public void setPageToEdit(int pageIndex)
            {
                page = pdf.Pages[pageIndex];
            }

            public void removePageFromPdf(int pageIndexToRemove)
            {
                pdf.Pages.RemoveAt(pageIndexToRemove);
                pdf.Pages.RemoveAt(pageIndexToRemove);
            }
            // Dokumenten Operationen

            public void loadPdf(string path)
            {
                pdf.LoadFromFile(path);
            }

            public void saveAndOpenPdf(string path)
            {
                pdf.SaveToFile(path);
                pdf.Close();
                System.Diagnostics.Process.Start(path);
            }
            // Layout, Styling Operationen

            public void setMarginForA4Document()
            {
                PdfUnitConvertor unitCvtr = new PdfUnitConvertor();
                margin = new PdfMargins();
                margin.Top = unitCvtr.ConvertUnits(2.54f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
                margin.Bottom = margin.Top;
                margin.Left = unitCvtr.ConvertUnits(3.17f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
                margin.Right = margin.Left;

                PdfPageTemplateElement leftSpace = new PdfPageTemplateElement(margin.Left, PdfPageSize.A4.Height);
                pdf.Template.Left = leftSpace;
                PdfPageTemplateElement topSpace = new PdfPageTemplateElement(PdfPageSize.A4.Width, margin.Top);
                topSpace.Foreground = true;
                pdf.Template.Top = topSpace;
                PdfPageTemplateElement rightSpace = new PdfPageTemplateElement(margin.Right, PdfPageSize.A4.Height);
                pdf.Template.Right = rightSpace;
                PdfPageTemplateElement bottomSpace = new PdfPageTemplateElement(PdfPageSize.A4.Width, margin.Bottom);
                bottomSpace.Foreground = true;
                pdf.Template.Bottom = bottomSpace;
            }


            public void setBrush()
            {
                brush = PdfBrushes.Black;
            }

            public void setFontToSourceSansPro()
            {
                font = new PdfTrueTypeFont(new Font("SourceSansPro", 8.7f, FontStyle.Regular));
            }

            public void setStringFormat()
            {
                PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Right);

            }
            public void setPen(float penWidth)
            {
                pen = new PdfPen(Color.Black, penWidth);
            }
            // Abgrenzungen Einzeichnen

            public void drawRectangle(int positionX, int positionY, int sizeX, int sizeY)
            {
                PdfGraphicsState state = page.Canvas.Save();


                page.Canvas.DrawRectangle(pen, new Rectangle(new Point(positionX, positionY), new Size(sizeX, sizeY)));
                //page.Canvas.DrawRectangle(pen, new Rectangle(new Point(300, 450), new Size(269, 60)));
                page.Canvas.Restore(state);

            }
            // Strings einzeichnen

            public void drawString(string text, float x, float y)
            {
                page.Canvas.DrawString(text, font, brush, x, y);
            }

            // FelderOperationen

            public void getFieldsFromPdf()
            {
                PdfFormWidget formWidget = pdf.Form as PdfFormWidget;
                for (int i = 0; i < formWidget.FieldsWidget.List.Count; i++)
                {
                    PdfField field = formWidget.FieldsWidget.List[i] as PdfField;
                    string fieldName = field.Name;
                    Console.WriteLine(fieldName);
                }
                Console.ReadLine();
            }
        }
}
