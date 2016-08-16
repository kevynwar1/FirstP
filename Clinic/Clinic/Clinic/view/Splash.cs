using System.Windows.Forms;

namespace Clinic.view {
    public partial class Splash : Form {
        public Splash() {
            InitializeComponent();
        }

        public void infoMessage(string message) {
            lbInfo.Text = message;
        }
    }
}
