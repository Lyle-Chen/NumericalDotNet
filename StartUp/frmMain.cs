using System.Windows.Forms;
using Calc.Numerical.DataTypes.Naive;

namespace StartUp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            var r1 = 3.2 - NComplex.J;
            var r2 = 5.74 + NComplex.J;

            var r3 = r1 + r2;
            var r4 = r1 - r2;
            var r5 = r1*r2;
            var r6 = r1/r2;

            var r7 = r1.Re > r2.Re;
            var r8 = r1.Re == r2.Re;
            var r9 = r1.Re < r2.Re;

            label1.Text = string.Format("{0}, {1}, {2}, {3}\n{4}, {5}, {6}", r3.Re, r4, r5, r6.Im, r7, r8, r9);
        }
    }
}
