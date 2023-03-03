﻿using SteganographyCodec.Front.Forms;

namespace SteganographyCodec.Front
{
    public partial class StartWindowForm : Form
    {
        public StartWindowForm()
        {
            InitializeComponent();
        }

        private void IncodeFileButton_Click(object sender, EventArgs e)
        {
            IncodeFileForm incodeFileForm = new IncodeFileForm();
            incodeFileForm.Show();
        }

        private void DecodeFileButton_Click(object sender, EventArgs e)
        {
            DecodeFileForm decodeFileForm = new DecodeFileForm();
            decodeFileForm.Show();
        }
    }
}