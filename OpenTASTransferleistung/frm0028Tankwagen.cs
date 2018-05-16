using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferleistungFSharp;

namespace OpenTASTransferleistung
{
    public partial class frm0028Tankwagen : Form
    {
        public Dictionary<string, string> beladearten = new Dictionary<string, string>(3);
        public Dictionary<string, string> transportEinheitsTypen = new Dictionary<string, string>(6);
        public frm0028Tankwagen()
        {
            InitializeComponent();
            tbADAT.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm");
            tabControl.SelectedTab = Beladedaten;
            beladearten.Add("B", "BottomLoading");
            beladearten.Add("T", "TopLoading");
            beladearten.Add("X", "TopAndBottomLoading");
            transportEinheitsTypen.Add("RDHT", "Heavy Trailer");
            transportEinheitsTypen.Add("RDMC", "Motor Car");
            transportEinheitsTypen.Add("RDMT", "Motor Trailer");
            transportEinheitsTypen.Add("RDMV", "Motor Vehicle");
            transportEinheitsTypen.Add("RDST", "Semitrailer");
            transportEinheitsTypen.Add("RDTR", "Trailer");
            transportEinheitsTypen.Add("RDTU", "Truck");
        }

        private void neuePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add("", "", "", DateTime.Now.ToString("dd.MM.yyyy hh:mm"), "Implico", "0");
        }


        // Validierung per F#
        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool[] val = new bool[] {
            ValidierungFS.validateTwoFieldsFromPseudoDB(tbTransporteinheitstypShort, tbTransporteinheitstypLong, transportEinheitsTypen),
            ValidierungFS.validateTwoFieldsFromPseudoDB(tbBeladeartShort, tbBeladeartLong, beladearten),
            ValidierungFS.containsNumber(tbLeergewicht),
            ValidierungFS.containsNumber(tbMaxGesGewicht),
            ValidierungFS.containsNumber(tbPrüfdruck),
            ValidierungFS.validateColumNumbersOptionalSum(dataGridView, 0),
            ValidierungFS.validateColumNumbersOptionalSum(dataGridView, 1, tbRauminhalt),
            ValidierungFS.validateColumNumbersOptionalSum(dataGridView, 2),
            ValidierungFS.alwaysOk(tbFahrzeugkennzeichen),
            ValidierungFS.alwaysOk(tbProduktartShort) };
            if (val.Contains(false))
            {
                MessageBox.Show("Validierung ist auf Fehler gestoßen.", "Tankwagen");
            }
            else
            {
                MessageBox.Show("Validierung erfolgreich verlaufen.", "Tankwagen");
            }
        }

        // Validierung per C#
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool[] val = new bool[] {
            ValidierungCS.ValidateTwoFieldsFromPseudoDB(tbTransporteinheitstypShort, tbTransporteinheitstypLong, transportEinheitsTypen),
            ValidierungCS.ValidateTwoFieldsFromPseudoDB(tbBeladeartShort, tbBeladeartLong, beladearten),
            ValidierungCS.ContainsNumber(tbLeergewicht),
            ValidierungCS.ContainsNumber(tbMaxGesGewicht),
            ValidierungCS.ContainsNumber(tbPrüfdruck),
            ValidierungCS.NumbersInColumnAndOptionalSum(dataGridView, 0),
            ValidierungCS.NumbersInColumnAndOptionalSum(dataGridView, 1, tbRauminhalt),
            ValidierungCS.NumbersInColumnAndOptionalSum(dataGridView, 2),
            ValidierungCS.AlwaysOk(tbFahrzeugkennzeichen),
            ValidierungCS.AlwaysOk(tbProduktartShort) };
            if (val.Contains(false))
            {
                MessageBox.Show("Validierung ist auf Fehler gestoßen.", "Tankwagen");
            }
            else
            {
                MessageBox.Show("Validierung erfolgreich verlaufen.", "Tankwagen");
            }
        }



        private void zurücksetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TextBox t in new TextBox[] {tbPrüfdruck, tbLeergewicht, tbRauminhalt, tbMaxGesGewicht,
                tbBeladeartShort, tbProduktartShort, tbTransporteinheitstypShort, tbFahrzeugkennzeichen})
            {
                t.ForeColor = SystemColors.WindowText;
            }
            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    c.Style.ForeColor = SystemColors.WindowText;
                }
            }

            tbBeladeartLong.Text = "";
            tbTransporteinheitstypLong.Text = "";
            tbRauminhalt.Text = "";
        }

        private void dataGridView_Leave(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
        }
    }
}
