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

// EIne PdfSeite ist ca 538 int werte breit 

namespace PdfCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Creator creator = new Creator();


            //creator.loadPdf(@"D:\repos\Hyp.Protokoll\Hyp.Api.Protokoll\Protokolle\Schwaebisch_Hall_AussenInnen.pdf");
            creator.loadPdf(@"C:\Users\robin\Desktop\Schwäbisch Hall Protokolle\Neu\Schwaebisch_Hall_AussenInnen.pdf");


//layout settings
            creator.setMarginForA4Document(0.5f,0.5f);
            creator.setStringFormat(PdfTextAlignment.Center);
            creator.setFontToSourceSansPro(8.7f);
            creator.setPen(0.8f);
            creator.setBrush(PdfBrushes.BlueViolet);


//page settings
            // creator.addNewPage();
            creator.setPageToEdit(0);
            //creator.removePageFromPdf(2);

            creator.createCheckbox2("LageGrossstadtGross", 1, 1);
            // drawing stuff
            //1.1
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 152);
            creator.createCheckbox("LageGrossstadtKlein", 19.5f, 164);
            creator.createCheckbox("LageMittelstadtGross", 19.5f, 176);
            creator.createCheckbox("LageMittelstadtKlein", 19.5f, 188);
            creator.createCheckbox("LageMittelstadtGross", 19.5f, 199);
            creator.createCheckbox("LageLandgemeinde", 19.5f, 211);
            //1.2
            creator.createCheckbox("LageZentrum", 111, 152);
            creator.createCheckbox("LageZentrum", 111, 164);
            creator.createCheckbox("LageZentrum", 111, 176);
            creator.createCheckbox("LageZentrum", 111, 188);
            creator.createCheckbox("LageZentrum", 111, 199);
            //1.3
            creator.createCheckbox("LageZentrum", 202.5f, 152);
            creator.createCheckbox("LageZentrum", 202.5f, 164);
            creator.createCheckbox("LageZentrum", 202.5f, 176);
            creator.createCheckbox("LageZentrum", 202.5f, 188);
            //1.4
            creator.createCheckbox("LageGrossstadtGross", 294, 152);
            creator.createCheckbox("LageGrossstadtKlein", 294, 164);
            creator.createCheckbox("LageMittelstadtGross", 294, 176);
            creator.createCheckbox("LageMittelstadtKlein", 294, 188);
            creator.createCheckbox("LageMittelstadtGross", 294, 199);
            creator.createCheckbox("LageLandgemeinde", 294, 211);
            //1.5 art
            creator.createCheckbox("LageGrossstadtKlein", 385.5f, 164);
            creator.createCheckbox("LageMittelstadtGross", 385.5f, 176);
            creator.createCheckbox("LageMittelstadtKlein", 385.5f, 188);
            creator.createCheckbox("LageMittelstadtGross", 385.5f, 199);
            creator.createCheckbox("LageLandgemeinde", 385.5f, 211);
            //1.5 ausbau
            creator.createCheckbox("LageGrossstadtKlein", 476.8f, 164);
            creator.createCheckbox("LageMittelstadtGross", 476.8f, 176);
            creator.createCheckbox("LageMittelstadtKlein", 476.8f, 188);
            creator.createCheckbox("LageMittelstadtGross", 476.8f, 199);
            //1.6
            creator.createCheckbox("LageZentrum", 19.5f, 234);
            creator.createCheckbox("LageZentrum", 19.5f, 246);
            creator.createCheckbox("LageZentrum", 19.5f, 258);
            creator.createCheckbox("LageZentrum", 19.5f, 270);
            creator.createCheckbox("LageZentrum", 19.5f, 281);

            creator.createCheckbox("LageZentrum", 111, 234);
            creator.createCheckbox("LageZentrum", 111, 246);
            creator.createCheckbox("LageZentrum", 111, 258);
            creator.createCheckbox("LageZentrum", 111, 270);
            creator.createCheckbox("LageZentrum", 111, 281);

            creator.createCheckbox("LageZentrum", 202.5f, 234);
            creator.createCheckbox("LageZentrum", 202.5f, 246);
            creator.createCheckbox("LageZentrum", 202.5f, 258);
            creator.createCheckbox("LageZentrum", 202.5f, 270);
            creator.createCheckbox("LageZentrum", 202.5f, 281);

            creator.createCheckbox("LageZentrum", 294, 234);
            creator.createCheckbox("LageZentrum", 294, 246);
            creator.createCheckbox("LageZentrum", 294, 258);
            creator.createCheckbox("LageZentrum", 294, 270);

            creator.createCheckbox("LageZentrum", 385.5f, 234);
            creator.createCheckbox("LageZentrum", 385.5f, 246);
            creator.createCheckbox("LageZentrum", 385.5f, 258);
            creator.createCheckbox("LageZentrum", 385.5f, 270);
            creator.createCheckbox("LageZentrum", 385.5f, 281);

            //1.7
            creator.createCheckbox("LageZentrum", 19.5f, 305);
            creator.createCheckbox("LageZentrum", 19.5f, 317);
            creator.createCheckbox("LageZentrum", 19.5f, 328.5f);

            creator.createCheckbox("LageZentrum", 111, 305);
            creator.createCheckbox("LageZentrum", 111, 317);
            creator.createCheckbox("LageZentrum", 111, 328.5f);

            creator.createCheckbox("LageZentrum", 202.5f, 305);
            creator.createCheckbox("LageZentrum", 202.5f, 317);
            creator.createCheckbox("LageZentrum", 202.5f, 328.5f);

            creator.createCheckbox("LageZentrum", 294, 305);
            creator.createCheckbox("LageZentrum", 294, 317);
            creator.createCheckbox("LageZentrum", 294, 328.5f);




            // felder Operationen

            //creator.getFieldsFromPdf();

            //creator.deleteAllFieldsFromPdf();
            creator.saveAndOpenPdf(@"C:/users/robin/desktop/tesdtff1ffffdffdffff3.pdf");


        }

    }
}
