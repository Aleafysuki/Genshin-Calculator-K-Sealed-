using System;
using System.Windows.Forms;

namespace Genshin_Calc
{
    public partial class NoteAdd : Form
    {
        public NoteAdd()
        {
            InitializeComponent();
            NoteBox.SelectedText = NoteBox.Text;
        }
        string Note;
        public void RecvNote(string str)
        {
            NoteBox.Text = str.TrimEnd();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Note = NoteBox.Text + " ";
            Dispose();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Note = null;
            Dispose();
        }
        public string ReturnedText()
        {
            return Note;
        }
    }
}
