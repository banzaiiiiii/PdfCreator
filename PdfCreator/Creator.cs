using Spire.Pdf;
using Spire.Pdf.Fields;
using Spire.Pdf.Graphics;
using Spire.Pdf.Widget;
using System;
using System.Drawing;


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

        float koordinateX = 10;
        float koordianteY = 10;
        float checkboxSizeX = 6;
        float checkboxSizeY = 6;

        int rectangleKoordinateX = 0;
        int rectangleKoordinateY = 0;
        int intSizeX = 538;
        int intSizeY = 80;

        int textboxHeight = 11;



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

        public void setMarginForA4Document(float valueTopBottom, float valueLeftRight)
        {
            PdfUnitConvertor unitCvtr = new PdfUnitConvertor();
            margin = new PdfMargins();
            margin.Top = unitCvtr.ConvertUnits(valueTopBottom, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            margin.Bottom = margin.Top;
            margin.Left = unitCvtr.ConvertUnits(valueLeftRight, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
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


        public void setBrush(PdfBrush color)
        {
            brush = PdfBrushes.Black;
        }

        public void setFontToSourceSansPro(float fontSize)
        {
            font = new PdfTrueTypeFont(new Font("SourceSansPro", fontSize, FontStyle.Regular));
        }

        
        public void setStringFormat(PdfTextAlignment alignment)
        {
            PdfStringFormat format = new PdfStringFormat(alignment);

        }

        public void setPen(float penWidth)
        {
            pen = new PdfPen(Color.Black, penWidth);
        }
        // Abgrenzungen Einzeichnen

        public void drawRectangle(int positionXChange, int positionYChange, int sizeXChange, int sizeYChange)
        {
            PdfGraphicsState state = page.Canvas.Save();


            page.Canvas.DrawRectangle(pen, new Rectangle(new Point(rectangleKoordinateX + positionXChange, rectangleKoordinateY + positionYChange), new Size(intSizeX + sizeXChange, intSizeY + sizeYChange)));
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

        
        public void createCheckbox(string fieldName, float koordinateXChange, float koordianteYChange)
        {
            PdfCheckBoxField checkbox = new PdfCheckBoxField(page, fieldName);
            float checkboxWidth = 10;
            float checkboxHeight = checkboxWidth;
            checkbox.Bounds = new RectangleF(koordinateXChange, koordianteYChange, checkboxWidth, checkboxHeight);
            checkbox.BorderWidth = 1;
            //checkbox.BorderStyle = PdfBorderStyle.Solid;
            checkbox.Style = PdfCheckBoxStyle.Check;
            pdf.Form.Fields.Add(checkbox);
        }

        public void createCheckbox2(string fieldName, float koordinateXChange, float koordianteYChange)
        {
            PdfCheckBoxField checkbox = new PdfCheckBoxField(page, fieldName);
            float checkboxWidth = 50;
            float checkboxHeight = checkboxWidth;
            checkbox.Bounds = new RectangleF(koordinateXChange, koordianteYChange, checkboxWidth, checkboxHeight);
            checkbox.BorderWidth = 1f;
            //checkbox.BorderStyle = PdfBorderStyle.Solid;
            checkbox.Style = PdfCheckBoxStyle.Circle;
           
            pdf.Form.Fields.Add(checkbox);
        }

        public void createTextBox(string fieldName, int koordinateXChange, int koordianteYChange, int textboxWidth)
        {
           
            PdfTextBoxField textField = new PdfTextBoxField(page, fieldName);
            textField.Bounds = new Rectangle(koordinateXChange, koordianteYChange, textboxWidth, textboxHeight);
            textField.BorderWidth = 0f;
            //textField.BorderStyle = PdfBorderStyle.;
            pdf.Form.Fields.Add(textField);
        }

        public void deleteAllFieldsFromPdf()
        {
            PdfFormWidget formWidget = pdf.Form as PdfFormWidget;

            for (int i = formWidget.FieldsWidget.List.Count - 1; i >= 0; i--)
            {
                PdfField field = formWidget.FieldsWidget.List[i] as PdfField;
                formWidget.FieldsWidget.Remove(field);
            }
        }

        public void drawHeader()
        {
            drawRectangle(0, 0, 0, 0);
            drawString("Auftraggeber:", 2, 2);
            createTextBox("Auftraggeber", 2 + 55, 2, 100);
            drawString("Auftragsnummer:", 2, 20);
            drawString("Adresse:", 2, 38);
            drawString("Ansprechpartner:", 2, 38 + 18);
        }

        

    }
}
