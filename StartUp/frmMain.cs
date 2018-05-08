using System.Windows.Forms;
using Numerical.Common.Algebra.Numerical;

namespace StartUp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            NReal.Precision = 4;
            NComplex.Precision = 2;

            var r1 = 3.2 - NComplex.J;
            var r2 = 5.74 + NComplex.J;

            var r3 = r1 + r2;
            var r4 = r1 - r2;
            var r5 = r1*r2;
            var r6 = r1/r2;

            label1.Text = string.Format("{0}, {1}, {2}, {3}", r3.Re, r4, r5, r6.Im);

        }
    }
}
