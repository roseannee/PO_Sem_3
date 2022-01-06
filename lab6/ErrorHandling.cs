using System.Windows.Forms;

namespace lab6
{
    internal class ErrorHandling
    {
        private string text;
        private string caption;
        private MessageBoxButtons button;
        private MessageBoxIcon icon;

        public void EmptyPathError()
        {
            text = "Empty path name is not allowed.";
            caption = "Error";
            button = MessageBoxButtons.OK;
            icon = MessageBoxIcon.Error;

            MessageBox.Show(text, caption, button, icon);
        }
    }
}
