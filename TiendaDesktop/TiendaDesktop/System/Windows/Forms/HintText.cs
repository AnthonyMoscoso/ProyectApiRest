using System.Drawing;
using WindowsFormsUI.Eventos;

namespace System.Windows.Forms
{
    internal class HintText : TextBox
    {
        public string Hint { get; set; }
        public enum TipeText
        {
            All, ONLY_NUMBERS, ONLY_LETTERS
        }
        public TipeText Tipo_De_Texto { get; set; }

        public bool IsEnty()
        {
            if (Text.Trim().Length > 0 && !Text.Equals(Hint))
            {

                return false;
            }
            return true;
        }
        public HintText()
        {

            Text = Hint;
            this.LostFocus += Add_Hint;
            this.HandleCreated += Add_Hint;
            this.MouseLeave += Add_Hint;
            this.MouseClick += Vaciar_hint;
            this.KeyDown += Vaciar_hint;
            this.ControlAdded += Vaciar_hint;
            this.KeyPress += HintText_KeyPress;
            this.TextChanged += HintText_TextChanged;

        }

        private void HintText_TextChanged(object sender, EventArgs e)
        {
            if (!Text.Equals(Hint))
            {
                ForeColor = Color.Black;
            }
        }

        private void HintText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tipo_De_Texto == TipeText.ONLY_LETTERS)
            {
                ValidarTxt.OnlyText(e);
            }
            else if (Tipo_De_Texto == TipeText.ONLY_NUMBERS)
            {
                ValidarTxt.NumerosDecimales(e);
            }
        }

        public void Vaciar()
        {
            Text = Hint;
            ForeColor = Color.Gray;
        }
        public void Add_Hint(Object sender, EventArgs e)
        {

            if (Text.Equals(""))
            {
                Vaciar();
            }
        }
        private void Vaciar_hint(Object sender, EventArgs e)
        {
            if (Text.Equals(Hint))
            {
                Text = "";
                ForeColor = Color.Black;
            }

        }
    }
}
