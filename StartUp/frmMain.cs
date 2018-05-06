using System;
using System.Linq;
using System.Windows.Forms;
using Numerical.Common.Algebra;

namespace StartUp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            var r1 = new Real(3.6);
            var r2 = new Real(2.5);
            var r3 = r1 + r2;
            var r5 = r1*r2;
            var r4 = r1 - r2;
            var r6 = r1/r2;

            var s = string.Format("{0}, {1}, {2}, {3}", r3.Val, r4.Val, r5.Val, r6.Val);

            label1.Text = s;

            var t = typeof (ChildClass);
            var a = t.GetCustomAttributes(true);

            if (a.Any(m => m is MyAttr && ((MyAttr)m).AttrParam == "asdfg"))
            {
                MessageBox.Show(@"Class ChildClass contains attribute MyAttr");
            }
            else
            {
                MessageBox.Show(@"Class ChildClass does NOT contain attribute MyAttr");
            }
        }

        [MyAttr(AttrParam = "asdf")]
        public class ParentClass
        {

        }

        public class ChildClass : ParentClass
        {

        }

        public class MyAttr : Attribute
        {
            public string AttrParam;
        }
    }

}
