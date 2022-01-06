using System.Windows.Forms;

namespace lab5
{
    internal class ErrorHandling
    {
        static string text;
        static string caption;
        static MessageBoxButtons button;
        static MessageBoxIcon icon;

        public static void EmptyPathError()
        {
            text = "Empty path name is not allowed.";
            caption = "Error";
            button = MessageBoxButtons.OK;
            icon = MessageBoxIcon.Error;

            MessageBox.Show(text, caption, button, icon);
        }
    }
}
