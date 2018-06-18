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


            creator.loadPdf(@"D:\repos\Hyp.Protokoll\Hyp.Api.Protokoll\Protokolle\Schwaebisch_Hall_AussenInnen.pdf");
            //creator.loadPdf(@"C:\Users\robin\Desktop\Schwäbisch Hall Protokolle\Neu\Schwaebisch_Hall_AussenInnen.pdf");
            //creator.loadPdf(@"D:/repos/Hyp.Protokoll/Hyp.Api.Protokoll.Pdf.Aareal/aareal.pdf");


            ////layout settings
            //            creator.setMarginForA4Document(0.5f,0.5f);
            creator.setStringFormat(PdfTextAlignment.Center);
            creator.setFontToSourceSansPro(8.7f);
            creator.setPen(0.8f);
            creator.setBrush(PdfBrushes.BlueViolet);


            ////page settings
            //            // creator.addNewPage();
                            creator.setPageToEdit(0);
            //            //creator.removePageFromPdf(2);

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
            //1.8

            creator.createCheckbox("LageZentrum", 385.5f, 305);
            creator.createCheckbox("LageZentrum", 385.5f, 317);
            creator.createCheckbox("LageZentrum", 385.5f, 328.5f);
            creator.createCheckbox("LageZentrum", 385.5f, 340);
            creator.createCheckbox("LageZentrum", 385.5f, 351.5f);
            creator.createCheckbox("LageZentrum", 385.5f, 363);
            creator.createCheckbox("LageZentrum", 385.5f, 375);

            // Lage gesamt
            creator.createCheckbox("LageZentrum", 110.5f, 387.4f);
            creator.createCheckbox("LageZentrum", 202.3f, 387.4f);
            creator.createCheckbox("LageZentrum", 293.7f, 387.4f);
            creator.createCheckbox("LageZentrum", 385.5f, 387.4f);
            creator.createCheckbox("LageZentrum", 476.6f, 387.4f);

            //2.1
            creator.createCheckbox("LageZentrum", 19.2f, 422.5f);
            creator.createCheckbox("LageZentrum", 19.2f, 434);
            creator.createCheckbox("LageZentrum", 19.2f, 446);
            creator.createCheckbox("LageZentrum", 19.2f, 458);
            creator.createCheckbox("LageZentrum", 19.2f, 470);
            creator.createCheckbox("LageZentrum", 19.2f, 481.5f);

            //2.2
            creator.createCheckbox("LageZentrum", 111, 422.5f);
            creator.createCheckbox("LageZentrum", 111, 434);
            creator.createCheckbox("LageZentrum", 111, 446);
            creator.createCheckbox("LageZentrum", 111, 458);
            creator.createCheckbox("LageZentrum", 111, 470);

            //2.3
            creator.createCheckbox("LageZentrum", 202.5f, 422.5f);
            creator.createCheckbox("LageZentrum", 202.5f, 434);
            creator.createCheckbox("LageZentrum", 202.5f, 446);
            creator.createCheckbox("LageZentrum", 202.5f, 458);
            creator.createCheckbox("LageZentrum", 202.5f, 470);
            creator.createCheckbox("LageZentrum", 202.5f, 481.5f);

            creator.createCheckbox("LageZentrum", 383f, 422.5f);
            creator.createCheckbox("LageZentrum", 383f, 434);
            creator.createCheckbox("LageZentrum", 383f, 446);
            creator.createCheckbox("LageZentrum", 383f, 458);
            creator.createCheckbox("LageZentrum", 383f, 470);
            creator.createCheckbox("LageZentrum", 383f, 481.5f);

            creator.createCheckbox("LageZentrum", 410.5f, 422.5f);
            creator.createCheckbox("LageZentrum", 410.5f, 434);
            creator.createCheckbox("LageZentrum", 410.5f, 446);
            creator.createCheckbox("LageZentrum", 410.5f, 458);
            creator.createCheckbox("LageZentrum", 410.5f, 470);
            creator.createCheckbox("LageZentrum", 410.5f, 481.5f);

            // 2.4
            creator.createCheckbox("LageZentrum", 19.2f, 506);
            creator.createCheckbox("LageZentrum", 19.2f, 518);
            creator.createCheckbox("LageZentrum", 19.2f, 529);
            creator.createCheckbox("LageZentrum", 19.2f, 540);
            creator.createCheckbox("LageZentrum", 19.2f, 552);
            creator.createCheckbox("LageZentrum", 19.2f, 564);
            //2.5
            creator.createCheckbox("LageZentrum", 111, 506);
            creator.createCheckbox("LageZentrum", 111, 518);
            creator.createCheckbox("LageZentrum", 111, 529);
            creator.createCheckbox("LageZentrum", 111, 540);
            creator.createCheckbox("LageZentrum", 111, 552);
            creator.createCheckbox("LageZentrum", 111, 564);
            //2.6
            creator.createCheckbox("LageZentrum", 202.5f, 506);
            creator.createCheckbox("LageZentrum", 202.5f, 518);
            creator.createCheckbox("LageZentrum", 202.5f, 529);
            creator.createCheckbox("LageZentrum", 202.5f, 540);
            creator.createCheckbox("LageZentrum", 202.5f, 552);
            creator.createCheckbox("LageZentrum", 202.5f, 564);
            //2.7
            creator.createCheckbox("LageZentrum", 294, 518);
            creator.createCheckbox("LageZentrum", 294, 529);
            creator.createCheckbox("LageZentrum", 294, 540);
            creator.createCheckbox("LageZentrum", 294, 552);
            creator.createCheckbox("LageZentrum", 294, 564);
            creator.createCheckbox("LageZentrum", 294, 575);
            creator.createCheckbox("LageZentrum", 294, 587);
            creator.createCheckbox("LageZentrum", 294, 599);
            //2.8
            creator.createCheckbox("LageZentrum", 476.8f, 506);
            creator.createCheckbox("LageZentrum", 476.8f, 518);
            creator.createCheckbox("LageZentrum", 476.8f, 529);
            //Grundstück gesamt
            creator.createCheckbox("LageZentrum", 110.5f, 610);
            creator.createCheckbox("LageZentrum", 202.3f, 610);
            creator.createCheckbox("LageZentrum", 293.7f, 610);
            creator.createCheckbox("LageZentrum", 385.5f, 610);
            creator.createCheckbox("LageZentrum", 476.6f, 610);
            //3.1
            creator.createCheckbox("LageZentrum", 19.2f, 646);
            creator.createCheckbox("LageZentrum", 19.2f, 658);
            creator.createCheckbox("LageZentrum", 19.2f, 670);
            creator.createCheckbox("LageZentrum", 19.2f, 706);
            creator.createCheckbox("LageZentrum", 19.2f, 718);
            creator.createCheckbox("LageZentrum", 19.2f, 742);

            creator.createCheckbox("LageZentrum", 111, 646);
            creator.createCheckbox("LageZentrum", 111, 658);
            creator.createCheckbox("LageZentrum", 111, 670);
            creator.createCheckbox("LageZentrum", 111, 682);
            creator.createCheckbox("LageZentrum", 111, 694);
            creator.createCheckbox("LageZentrum", 111, 706);
            creator.createCheckbox("LageZentrum", 111, 718);
            creator.createCheckbox("LageZentrum", 111, 730);
            creator.createCheckbox("LageZentrum", 111, 742);
            creator.createCheckbox("LageZentrum", 111, 754);

            creator.createCheckbox("LageZentrum", 294, 646);
            creator.createCheckbox("LageZentrum", 294, 658);
            creator.createCheckbox("LageZentrum", 294, 670);
            creator.createCheckbox("LageZentrum", 294, 682);
            creator.createCheckbox("LageZentrum", 294, 706);
            creator.createCheckbox("LageZentrum", 294, 718);
            creator.createCheckbox("LageZentrum", 294, 742);
            //3.2
            creator.createCheckbox("LageZentrum", 385.5f, 646);
            creator.createCheckbox("LageZentrum", 385.5f, 658);
            creator.createCheckbox("LageZentrum", 385.5f, 670);
            creator.createCheckbox("LageZentrum", 385.5f, 682);
            creator.createCheckbox("LageZentrum", 385.5f, 694);
            creator.createCheckbox("LageZentrum", 449, 706);
            creator.createCheckbox("LageZentrum", 449, 718);
            creator.createCheckbox("LageZentrum", 385.5f, 730);

            creator.setPageToEdit(1);
            //3.3
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 81);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 93);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 105);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 117);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 129);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 141);

            creator.createCheckbox("LageGrossstadtGross", 111, 81);
            creator.createCheckbox("LageGrossstadtGross", 111, 93);
            creator.createCheckbox("LageGrossstadtGross", 111, 105);
            creator.createCheckbox("LageGrossstadtGross", 111, 117);
            creator.createCheckbox("LageGrossstadtGross", 111, 129);
            creator.createCheckbox("LageGrossstadtGross", 111, 176);
            creator.createCheckbox("LageGrossstadtGross", 111, 187.5f);

       
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 81);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 93);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 105);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 117);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 141);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 153);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 165);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 176);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 187.5f);

            creator.createCheckbox("LageGrossstadtGross", 294, 81);
            creator.createCheckbox("LageGrossstadtGross", 294, 93);
            creator.createCheckbox("LageGrossstadtGross", 294, 105);
            creator.createCheckbox("LageGrossstadtGross", 294, 117);
            creator.createCheckbox("LageGrossstadtGross", 294, 141);
            creator.createCheckbox("LageGrossstadtGross", 294, 153);
            creator.createCheckbox("LageGrossstadtGross", 294, 165);
            creator.createCheckbox("LageGrossstadtGross", 294, 176);
            //3.4
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 81);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 93);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 105);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 129);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 141);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 153);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 176);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 188);
            //3.5
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 211);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 223);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 235);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 247);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 259);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 271);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 283);

            creator.createCheckbox("LageGrossstadtGross", 111, 235);
            creator.createCheckbox("LageGrossstadtGross", 111, 247);
            creator.createCheckbox("LageGrossstadtGross", 111, 259);
            creator.createCheckbox("LageGrossstadtGross", 111, 271);
            
           
            //3.6
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 211);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 223);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 235);
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 247); 
            creator.createCheckbox("LageGrossstadtGross", 202.5f, 258);
            //3.7
            creator.createCheckbox("LageGrossstadtGross", 294, 211);
            creator.createCheckbox("LageGrossstadtGross", 294, 223);
            creator.createCheckbox("LageGrossstadtGross", 294, 235);
            creator.createCheckbox("LageGrossstadtGross", 294, 247);
            creator.createCheckbox("LageGrossstadtGross", 294, 258);
            
            //3.8
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 223);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 235);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 247);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 258);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 270);
            creator.createCheckbox("LageGrossstadtGross", 385.5f, 282);
            //Objekt gesamt
            creator.createCheckbox("LageZentrum", 110.5f, 422);
            creator.createCheckbox("LageZentrum", 202.3f, 422);
            creator.createCheckbox("LageZentrum", 293.7f, 422);
            creator.createCheckbox("LageZentrum", 385.5f, 422);
            creator.createCheckbox("LageZentrum", 476.6f, 422);

            creator.setPageToEdit(2);
            //4.1
           
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 152);
            creator.createCheckbox("LageGrossstadtKlein", 19.5f, 164);
            creator.createCheckbox("LageMittelstadtGross", 19.5f, 176);
            
            creator.createCheckbox("LageZentrum", 111, 152);
            creator.createCheckbox("LageZentrum", 111, 164);
            creator.createCheckbox("LageZentrum", 111, 176);
            creator.createCheckbox("LageZentrum", 111, 187);
            //4.2
            creator.createCheckbox("LageZentrum", 202.5f, 152);
            creator.createCheckbox("LageZentrum", 202.5f, 164);
            creator.createCheckbox("LageZentrum", 202.5f, 176);
            creator.createCheckbox("LageZentrum", 202.5f, 187);
            //
            creator.createCheckbox("LageGrossstadtGross", 294, 152);
            creator.createCheckbox("LageGrossstadtKlein", 294, 164);
            creator.createCheckbox("LageMittelstadtGross", 294, 176);
            creator.createCheckbox("LageMittelstadtKlein", 294, 187);
            //
            creator.createCheckbox("Lage", 385.5f, 152);
            creator.createCheckbox("LageGrossstadtKlein", 385.5f, 164);
            creator.createCheckbox("LageMittelstadtGross", 385.5f, 176);
            creator.createCheckbox("LageMittelstadtKlein", 385.5f, 187);
            creator.createCheckbox("Lage", 476.6f, 152);
            //4.3
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 211);
            creator.createCheckbox("LageGrossstadtKlein", 19.5f, 223);
            creator.createCheckbox("LageMittelstadtGross", 19.5f, 235);
            creator.createCheckbox("LageGrossstadtKlein", 19.5f, 246);
            creator.createCheckbox("LageMittelstadtGross", 19.5f, 258);

            creator.createCheckbox("LageZentrum", 111, 211);
            creator.createCheckbox("LageZentrum", 111, 223);
            creator.createCheckbox("LageZentrum", 111, 235);
            creator.createCheckbox("LageZentrum", 111, 246);
            creator.createCheckbox("LageZentrum", 111, 258);
            creator.createCheckbox("LageZentrum", 111, 270);
            creator.createCheckbox("LageZentrum", 111, 281);
            creator.createCheckbox("LageZentrum", 111, 293);
            creator.createCheckbox("LageZentrum", 111, 305);

            creator.createCheckbox("LageZentrum", 202.5f, 211);
            creator.createCheckbox("LageZentrum", 202.5f, 223);
            creator.createCheckbox("LageZentrum", 202.5f, 235);
            creator.createCheckbox("LageZentrum", 202.5f, 246);
            creator.createCheckbox("LageZentrum", 202.5f, 258);
            //4.4
            creator.createCheckbox("LageGrossstadtGross", 294, 211);
            creator.createCheckbox("LageGrossstadtKlein", 294, 223);
            creator.createCheckbox("LageMittelstadtGross", 294, 235);
            creator.createCheckbox("LageMittelstadtKlein", 294, 246);
            //4.5
            creator.createCheckbox("Lage", 385.5f, 223);
            creator.createCheckbox("LageGrossstadtKlein", 385.5f, 235);
            creator.createCheckbox("LageMittelstadtGross", 385.5f, 246);
            creator.createCheckbox("LageMittelstadtKlein", 385.5f, 258);
            creator.createCheckbox("LageMittelstadtKlein", 385.5f, 270);
            //4.6
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 328);
            creator.createCheckbox("LageGrossstadtKlein", 19.5f, 340);
            creator.createCheckbox("LageMittelstadtGross", 19.5f, 352);
            creator.createCheckbox("LageGrossstadtKlein", 19.5f, 364);
            creator.createCheckbox("LageMittelstadtGross", 19.5f, 375);
            //4.7
            creator.createCheckbox("LageZentrum", 111, 328);
            creator.createCheckbox("LageZentrum", 111, 340);
            creator.createCheckbox("LageZentrum", 111, 352);
            creator.createCheckbox("LageZentrum", 111, 364);
            creator.createCheckbox("LageZentrum", 111, 375);
            //4.8
            creator.createCheckbox("LageZentrum", 202.5f, 328);
            creator.createCheckbox("LageZentrum", 202.5f, 340);
            creator.createCheckbox("LageZentrum", 202.5f, 352);
            creator.createCheckbox("LageZentrum", 202.5f, 364);
            creator.createCheckbox("LageZentrum", 202.5f, 375);
            creator.createCheckbox("LageZentrum", 202.5f, 386);

            creator.createCheckbox("LageZentrum", 294, 328);
            creator.createCheckbox("LageZentrum", 294, 340);
            creator.createCheckbox("LageZentrum", 294, 352);
            creator.createCheckbox("LageZentrum", 294, 364);
            creator.createCheckbox("LageZentrum", 294, 375);
            creator.createCheckbox("LageZentrum", 294, 387);
            //4.9
            creator.createCheckbox("LageZentrum", 416, 328);
            creator.createCheckbox("LageZentrum", 416, 340);
            creator.createCheckbox("LageZentrum", 416, 352);
            creator.createCheckbox("LageZentrum", 416, 364);
            creator.createCheckbox("LageZentrum", 416, 375);
            creator.createCheckbox("LageZentrum", 416, 387);
            //Ausstattung gesamt
            creator.createCheckbox("LageZentrum", 110.5f, 399);
            creator.createCheckbox("LageZentrum", 202.3f, 399);
            creator.createCheckbox("LageZentrum", 293.7f, 399);
            creator.createCheckbox("LageZentrum", 385.5f, 399);
            creator.createCheckbox("LageZentrum", 476.6f, 399);
            //OBjekt ist fertiggestellt 
            creator.createCheckbox("LageZentrum", 193, 423);
            creator.createCheckbox("LageZentrum", 220, 423);
            //5.5
            creator.createCheckbox("LageZentrum", 111, 483);
            creator.createCheckbox("LageZentrum", 111, 506);
            creator.createCheckbox("LageZentrum", 111, 529);
            creator.createCheckbox("LageZentrum", 111, 553);
            creator.createCheckbox("LageZentrum", 111, 576);
            creator.createCheckbox("LageZentrum", 111, 600);
            creator.createCheckbox("LageZentrum", 111, 622);
            creator.createCheckbox("LageZentrum", 111, 646);

            creator.createCheckbox("LageZentrum", 201f, 483);
            creator.createCheckbox("LageZentrum", 201f, 506);
            creator.createCheckbox("LageZentrum", 201f, 529);
            creator.createCheckbox("LageZentrum", 201f, 553);
            creator.createCheckbox("LageZentrum", 201f, 576);
            creator.createCheckbox("LageZentrum", 201f, 600);
            creator.createCheckbox("LageZentrum", 201f, 622);
            creator.createCheckbox("LageZentrum", 201, 646);

            creator.createCheckbox("LageZentrum", 292, 483);
            creator.createCheckbox("LageZentrum", 292, 506);
            creator.createCheckbox("LageZentrum", 292, 529);
            creator.createCheckbox("LageZentrum", 292, 553);
            creator.createCheckbox("LageZentrum", 292, 576);
            creator.createCheckbox("LageZentrum", 292, 600);
            creator.createCheckbox("LageZentrum", 292, 622);
            creator.createCheckbox("LageZentrum", 292, 646);

            creator.createCheckbox("LageZentrum", 384f, 483);
            creator.createCheckbox("LageZentrum", 384f, 506);
            creator.createCheckbox("LageZentrum", 384f, 529);
            creator.createCheckbox("LageZentrum", 384f, 553);
            creator.createCheckbox("LageZentrum", 384f, 576);
            creator.createCheckbox("LageZentrum", 384f, 600);
            creator.createCheckbox("LageZentrum", 384f, 622);
            creator.createCheckbox("LageZentrum", 384f, 646);

            creator.createCheckbox("LageZentrum", 471f, 483);
            creator.createCheckbox("LageZentrum", 471f, 506);
            creator.createCheckbox("LageZentrum", 471f, 529);
            creator.createCheckbox("LageZentrum", 471f, 553);
            creator.createCheckbox("LageZentrum", 471f, 576);
            creator.createCheckbox("LageZentrum", 471f, 600);
            creator.createCheckbox("LageZentrum", 471f, 622);
            creator.createCheckbox("LageZentrum", 471f, 646);
            //6.
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 693);
            creator.createCheckbox("LageGrossstadtKlein", 19.5f, 704);
            creator.createCheckbox("LageMittelstadtGross", 19.5f, 716);
            creator.createCheckbox("LageGrossstadtKlein", 19.5f, 728);

            creator.createCheckbox("LageMittelstadtGross", 111, 693);
            creator.createCheckbox("LageGrossstadtKlein", 111, 704);
            creator.createCheckbox("LageMittelstadtGross", 137, 693);
            creator.createCheckbox("LageGrossstadtKlein", 137, 704);
            creator.createCheckbox("LageGrossstadtKlein", 137, 716);

            creator.createCheckbox("LageGrossstadtGross", 201.5f, 693);
            creator.createCheckbox("LageGrossstadtKlein", 201.5f, 704);
            creator.createCheckbox("LageMittelstadtGross", 201.5f, 716);

            creator.createCheckbox("LageGrossstadtGross", 293, 693);
            creator.createCheckbox("LageGrossstadtKlein", 293, 704);
            creator.createCheckbox("LageMittelstadtGross", 293, 716);

            creator.createCheckbox("LageGrossstadtGross", 386f, 693);
            creator.createCheckbox("LageGrossstadtKlein", 386f, 704);

            creator.createCheckbox("LageGrossstadtGross", 477f, 693);
            creator.createCheckbox("LageGrossstadtKlein", 477f, 704);

            creator.setPageToEdit(3);

            //7.
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 81);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 93);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 105);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 117);
            creator.createCheckbox("LageGrossstadtGross", 19.5f, 129);

            creator.createCheckbox("LageGrossstadtGross", 158, 81);
            creator.createCheckbox("LageGrossstadtGross", 158, 93);
            creator.createCheckbox("LageGrossstadtGross", 158, 105);
            creator.createCheckbox("LageGrossstadtGross", 158, 117);
            creator.createCheckbox("LageGrossstadtGross", 158, 129);

            creator.createCheckbox("LageGrossstadtGross", 294, 81);
            creator.createCheckbox("LageGrossstadtGross", 294, 93);
            creator.createCheckbox("LageGrossstadtGross", 294, 105);
            creator.createCheckbox("LageGrossstadtGross", 294, 117);
            creator.createCheckbox("LageGrossstadtGross", 294, 129);

            creator.createCheckbox("LageGrossstadtGross", 477, 81);
            creator.createCheckbox("LageGrossstadtGross", 477, 93);
            creator.createCheckbox("LageGrossstadtGross", 477, 105);
            creator.createCheckbox("LageGrossstadtGross", 477, 117);
            creator.createCheckbox("LageGrossstadtGross", 477, 129);

            // felder Operationen

            //creator.getFieldsFromPdf();

            //creator.deleteAllFieldsFromPdf();f
            creator.saveAndOpenPdf(@"C:/users/robin/desktop/Schwäbisch Hall Protokolle/dffff.pdf");
            

        }

    }
}
