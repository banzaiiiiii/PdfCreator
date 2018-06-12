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
            Creator creator = new Creator();


            //creator.loadPdf(@"C:\Users\pc\source\repos\Hyp.Protokoll\Hyp.Api.Protokoll\Protokolle\Schwaebisch_Hall_AussenInnen.pdf");


            //layout settings
            creator.setMarginForA4Document();
            creator.setFontToSourceSansPro();
            creator.setPen(0.8f);
            creator.setBrush();


            //page settings
            creator.addNewPage();
            //creator.setPageToEdit(1);


            // drawing stuff
            creator.drawRectangle(18, 450, 269, 60);
            //creator.drawString("Die Bausparkasse Schwäbisch Hall ist kacke",20, 100 );

            // felder Operationen

            //creator.getFieldsFromPdf();


            creator.saveAndOpenPdf(@"C:/users/pc/desktop/SpirePdfCreation/testPdf.pdf");


        }

    }
}
