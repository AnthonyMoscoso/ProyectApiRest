using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDesktop.UI.Componentes
{
    public partial class pnData : UserControl
    {
        public enum TipeText
        {
            All, ONLY_NUMBERS, ONLY_LETTERS
        }
        public bool IsPassword { get; set; }
        public string Titule { get; set; }
        public string TextoHint { get; set; }
        public bool Multiline { get; set; }

        public Font FontLabel { get; set; }

        public Color ColorTitule { get; set; }

        public string Texto
        {
            get
            {
                return txtData.Text;
            }
            set
            {
                txtData.Text = value;
            }
        }
        public bool IsEntyTxt()
        {
            if (txtData.IsEnty())
            {
                alertData.SetErrorMessage("No puede dejar este campo vacio");
                return true;
            }
            else
            {
                alertData.IsCorrect();
                return false;
            }

        }
        public int MaxCharacters
        {
            set
            {
                txtData.MaxLength = value;
            }
        }
        public Image Imagen { get; set; }
        public void SetErrorMessage(string error)
        {
            alertData.SetErrorMessage(error);
        }
        public void SetCorrect()
        {
            alertData.IsCorrect();

        }

        public TipeText Tipo_De_Texto { get; set; }

        public pnData()
        {
            InitializeComponent();
            txtData.TextChanged += TxtData_TextChanged;
            this.Load += DataBox_Load;
            this.Paint += DataBox_Paint;
        }

        private void DataBox_Paint(object sender, PaintEventArgs e)
        {
            LoadDatas();

        }

        private void TxtData_TextChanged(object sender, EventArgs e)
        {
            if (txtData.Text.Equals(txtData.Hint) && IsPassword)
            {
                txtData.PasswordChar = '\0';
            }
        }

        private void LoadDatas()
        {
            if (Titule != null)
            {
                lbNombreData.Text = Titule;
            }
            if (TextoHint != null)
            {
                txtData.Hint = TextoHint;
            }
            if (Imagen != null)
            {
                ptbxImagenData.Image = Imagen;
                pnImagenData.Visible = true;
            }
            if (Texto != null)
            {
                txtData.Text = Texto;
            }
            if (IsPassword)
            {
                EyeImage.Visible = true;
                txtData.PasswordChar = '*';
            }
            if (Multiline == true)
            {
                txtData.Multiline = true;
                txtData.Dock = DockStyle.Fill;
            }
            else
            {
                txtData.Multiline = false;
                txtData.Dock = DockStyle.Top;
            }
            if (FontLabel != null)
            {
                lbNombreData.Font = FontLabel;
            }
            if (ColorTitule != null)
            {
                lbNombreData.ForeColor = ColorTitule;
            }
            TipeData();
        }

        private void DataBox_Load(object sender, EventArgs e)
        {
            LoadDatas();
        }


        public void TipeData()
        {
            if (Tipo_De_Texto == TipeText.ONLY_LETTERS)
            {
                txtData.Tipo_De_Texto = HintText.TipeText.ONLY_LETTERS;

            }
            else if (Tipo_De_Texto == TipeText.ONLY_NUMBERS)
            {
                txtData.Tipo_De_Texto = HintText.TipeText.ONLY_NUMBERS;

            }
            else
            {
                txtData.Tipo_De_Texto = HintText.TipeText.All;
            }
            this.Load += DataBox_Load;
        }
        private void EyeImage_Click(object sender, EventArgs e)
        {
            if (txtData.PasswordChar.Equals('*'))
            {
                txtData.PasswordChar = '\0';
            }
            else
            {
                txtData.PasswordChar = '*';
            }
        }
    }
}

