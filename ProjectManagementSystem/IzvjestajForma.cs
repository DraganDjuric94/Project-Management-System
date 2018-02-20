using iTextSharp.text;
using iTextSharp.text.pdf;
using ProjectManagementSystem.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem {
    public partial class IzvjestajForma : Form {
        private Projekat projekat;
        private List<Transakcija> transakcije = new List<Transakcija>();
        public IzvjestajForma(Projekat pr) {
            InitializeComponent();

            projekat = pr;
            nazivProjektaLBL.Text = pr.Naziv;
            datumKreiranjaLBL.Text = pr.DatumKreiranja.Value.ToString("dd/MM/yyyy");

            string sef = "";
            foreach (Ucesnik uc in pr.UcesniciNaProjektu.Keys) {
                if (pr.UcesniciNaProjektu[uc].Naziv.Equals("sef")) {
                    sef = uc.Ime + " " + uc.Prezime + " \"" + uc.KorisnickoIme + "\"";
                }
            }

            int procenatIzvrsenosti = 0, ukupnoPotrebnoCC = 0;
            foreach (Cjelina c in pr.Cjeline) {
                if (c.CjelinaRoditeljID == null) {
                    procenatIzvrsenosti += (int)(((double)c.ProcenatIzvrsenosti / 100.0) * c.BrojPotrebnihCovjekCasova);
                    ukupnoPotrebnoCC += (int)c.BrojPotrebnihCovjekCasova;
                    Console.WriteLine("PI: " + procenatIzvrsenosti + " UK:" + ukupnoPotrebnoCC);
                }
            }
            int procenat = 0;
            if (ukupnoPotrebnoCC != 0) {
                procenat = (int)(((double)procenatIzvrsenosti / ukupnoPotrebnoCC) * 100);
            }

            procenatIzvrsenostiLBL.Text = procenat + "%";
            sefProjektaLBL.Text = sef;

            foreach (Cjelina c in pr.Cjeline) {
                if (c.CjelinaRoditeljID == null) {
                    zadaciProcenatLVW.Items.Add(c.Naziv + " " + c.ProcenatIzvrsenosti + "%");
                }
            }

            foreach (Ucesnik uc in pr.UcesniciNaProjektu.Keys) {
                if (!pr.UcesniciNaProjektu[uc].Naziv.Equals("sef")) {
                    string uloga = "";
                    if (pr.UcesniciNaProjektu[uc].Naziv.Equals("nadzor")) {
                        uloga = "Nadzor: ";
                    } else {
                        uloga = "Učesnik: ";
                    }
                    ucesniciLVW.Items.Add(uloga + uc.Ime + " " + uc.Prezime + " \"" + uc.KorisnickoIme + "\"");
                }
            }
            List<Aktivnost> aktivnosti = new List<Aktivnost>();
            foreach(Cjelina c in pr.Cjeline) {
                aktivnosti.AddRange(c.Aktivnosti);
            }

            double prihodi = 0;
            double rashodi = 0;

            foreach(Aktivnost a in aktivnosti) {
                foreach(Transakcija t in a.Transakcije) {
                    transakcije.Add(t);
                    string prihod_rashod = "";
                    if (t.PrihodRashod == true) {
                        prihod_rashod = "Pridhod: ";
                        prihodi += Convert.ToDouble(t.Iznos);
                    } else {
                        prihod_rashod = "Rashod: ";
                        rashodi += Convert.ToDouble(t.Iznos);
                    }
                    prihodiRashodiLVW.Items.Add(t.DatumVrijeme.Value.ToString("dd/MM/yyyy") + " " + prihod_rashod + t.Iznos);
                }
            }

            razlikaFinansijskaLBL.Text = Convert.ToString(prihodi - rashodi);

        }

        private void sacuvajKaoPdfBTN_Click(object sender, EventArgs e) {

            //This is the absolute path to the PDF that we will create
            string putanja = "Izvjestaj-" + projekat.Naziv + DateTime.Now.ToString("yyMMddHHmmssff") + ".pdf";
            string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) , putanja);

            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None)) {
                //Create a new PDF document setting the size to A4
                using (Document doc = new Document(PageSize.A4)) {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs)) {
                        //Open the document for writing
                        doc.Open();

                        //Create a table with two columns

                        string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");

                        //Create a base font object making sure to specify IDENTITY-H
                        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA ,BaseFont.CP1257, BaseFont.EMBEDDED);

                        //Create a specific font object
                        iTextSharp.text.Font f1 = new iTextSharp.text.Font(bf, 17, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                        doc.Add(new Paragraph("Naziv projekta: " + nazivProjektaLBL.Text, f1));
                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("Izvještaj generisan: " + DateTime.Now.ToString("dd/MM/yyyy"), f2));
                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("Šef projekta: " + sefProjektaLBL.Text, f2));
                        doc.Add(new Paragraph("Datum kreiranja projekta: " + datumKreiranjaLBL.Text, f2));
                        doc.Add(new Paragraph("Procenat završenosti: " + procenatIzvrsenostiLBL.Text, f2));
                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("Učesnici:", f2));
                        doc.Add(new Paragraph("\n"));

                        PdfPTable ucesnici = new PdfPTable(5);

                        ucesnici.AddCell(new PdfPCell(new Phrase("Rbr.", f2)));
                        ucesnici.AddCell(new PdfPCell(new Phrase("Ime", f2)));
                        ucesnici.AddCell(new PdfPCell(new Phrase("Prezime", f2)));
                        ucesnici.AddCell(new PdfPCell(new Phrase("Kor. ime", f2)));
                        ucesnici.AddCell(new PdfPCell(new Phrase("Uloga", f2)));
                        int i = 1;
                        foreach(Ucesnik uc in projekat.UcesniciNaProjektu.Keys) {
                            if (!projekat.UcesniciNaProjektu[uc].Naziv.Equals("sef")) {
                                i++;
                                string uloga = "";
                                if (projekat.UcesniciNaProjektu[uc].Naziv.Equals("nadzor")) {
                                    uloga = "Nadzor";
                                } else {
                                    uloga = "Učesnik";
                                }
                                ucesnici.AddCell(new PdfPCell(new Phrase(Convert.ToString(i-1) + ".", f2)));
                                ucesnici.AddCell(new PdfPCell(new Phrase(uc.Ime, f2)));
                                ucesnici.AddCell(new PdfPCell(new Phrase(uc.Prezime, f2)));
                                ucesnici.AddCell(new PdfPCell(new Phrase(uc.KorisnickoIme, f2)));
                                ucesnici.AddCell(new PdfPCell(new Phrase(uloga, f2)));
                            }
                        }
                        doc.Add(ucesnici);

                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("Procenat završenosti zadataka:", f2));
                        doc.Add(new Paragraph("\n"));

                        PdfPTable zadaci = new PdfPTable(3);

                        zadaci.AddCell(new PdfPCell(new Phrase("Rbr.", f2)));
                        zadaci.AddCell(new PdfPCell(new Phrase("Naziv", f2)));
                        zadaci.AddCell(new PdfPCell(new Phrase("Procenat", f2)));
                        i = 1;
                        foreach (Cjelina uc in projekat.Cjeline) {
                            if (uc.CjelinaRoditeljID == null) {
                                i++;
                                zadaci.AddCell(new PdfPCell(new Phrase(Convert.ToString(i-1) + ".", f2)));
                                zadaci.AddCell(new PdfPCell(new Phrase(uc.Naziv, f2)));
                                zadaci.AddCell(new PdfPCell(new Phrase(Convert.ToString(uc.ProcenatIzvrsenosti) + "%", f2)));
                            }
                        }
                        doc.Add(zadaci);

                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("Prihodi/rashodi:", f2));
                        doc.Add(new Paragraph("\n"));

                        PdfPTable trans = new PdfPTable(4);

                        trans.AddCell(new PdfPCell(new Phrase("Rbr.", f2)));
                        trans.AddCell(new PdfPCell(new Phrase("Prihod/rashod", f2)));
                        trans.AddCell(new PdfPCell(new Phrase("Datum", f2)));
                        trans.AddCell(new PdfPCell(new Phrase("Iznos", f2)));
                        i = 1;
                        foreach (Transakcija uc in transakcije) {
                            i++;
                            string vrsta = "";
                            if (uc.PrihodRashod == true) {
                                vrsta = "Prihod";
                            } else {
                                vrsta = "Rashod";
                            }
                            trans.AddCell(new PdfPCell(new Phrase(Convert.ToString(i-1) + ".", f2)));
                            trans.AddCell(new PdfPCell(new Phrase(vrsta, f2)));
                            trans.AddCell(new PdfPCell(new Phrase(uc.DatumVrijeme.Value.ToString("dd/MM/yyyy"), f2)));
                            trans.AddCell(new PdfPCell(new Phrase(Convert.ToString(uc.Iznos), f2)));
                        }

                        doc.Add(trans);

                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("Razlika u finansijama: " + razlikaFinansijskaLBL.Text, f2));
                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("\n"));
                        doc.Add(new Paragraph("\n"));
                        

                        doc.Close();
                    }
                }
            }
            MessageBox.Show("Traženi izvještaj je sačuvan na Vaš Desktop pod nazivom: " + putanja, "Izvještaj sačuvan", MessageBoxButtons.OK);
        }

        private void zatvoriBTN_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
