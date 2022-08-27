using System.Windows.Forms;
using Library;

namespace BaseControlLibrary
{
    public partial class Panel: UserControl
    {

        private readonly Lib lib;
        public Panel()
        {
            InitializeComponent();
            lib = new Lib();
        }

        protected void DoSomething()
        {
            string results = lib.String("string1", 10);
        }
    }
}
