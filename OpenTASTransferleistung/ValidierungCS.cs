using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTASTransferleistung
{
    public static class ValidierungCS
    {

        public static bool ValidateTwoFieldsFromPseudoDB(TextBox input, TextBox output, Dictionary<string, string> pseudoDataBase)
        {
            if (pseudoDataBase.ContainsKey(input.Text))
            {
                input.ForeColor = System.Drawing.Color.Green;
                output.Text = pseudoDataBase[input.Text];
                return true;
            }
            else
            {
                input.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }

        public static bool ContainsNumber(TextBox t)
        {
            if (Double.TryParse(t.Text, out double x) && x >= 0)
            {
                t.ForeColor = System.Drawing.Color.Green;
                return true;
            }
            else
            {
                t.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }


        public static bool NumbersInColumnAndOptionalSum(DataGridView d, int columnIndex, TextBox tbSum = null)
        {
            double sum = 0;
            bool isOk = true;
            foreach (DataGridViewRow r in d.Rows)
            {
                DataGridViewCell c = r.Cells[columnIndex];
                try
                {
                    double val = Convert.ToDouble(c.Value);
                    if (val >= 0)
                    {
                        c.Style.ForeColor = System.Drawing.Color.Green;
                        sum += val;
                    }
                    else
                        throw new Exception("Wert ist negativ");
                }
                catch
                {
                    isOk = false;
                    c.Style.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (isOk)
                if (tbSum != null)
                    tbSum.Text = sum.ToString("N2");
            return isOk;
        }

        public static bool AlwaysOk(TextBox t)
        {
            t.ForeColor = System.Drawing.Color.Green;
            return true;
        }
    }
}
