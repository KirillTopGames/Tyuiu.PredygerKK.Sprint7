namespace Tyuiu.PredygerKK.Sprint7.Project.V6
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_PKK = new PictureBox();
            textBoxAbout_PKK = new TextBox();
            buttonAboutClose_PKK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_PKK).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_PKK
            // 
            pictureBoxAvatar_PKK.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxAvatar_PKK.Image = (Image)resources.GetObject("pictureBoxAvatar_PKK.Image");
            pictureBoxAvatar_PKK.Location = new Point(12, 12);
            pictureBoxAvatar_PKK.Name = "pictureBoxAvatar_PKK";
            pictureBoxAvatar_PKK.Size = new Size(187, 249);
            pictureBoxAvatar_PKK.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_PKK.TabIndex = 0;
            pictureBoxAvatar_PKK.TabStop = false;
            // 
            // textBoxAbout_PKK
            // 
            textBoxAbout_PKK.Font = new Font("Segoe UI", 12F);
            textBoxAbout_PKK.Location = new Point(205, 12);
            textBoxAbout_PKK.Multiline = true;
            textBoxAbout_PKK.Name = "textBoxAbout_PKK";
            textBoxAbout_PKK.ReadOnly = true;
            textBoxAbout_PKK.Size = new Size(483, 249);
            textBoxAbout_PKK.TabIndex = 1;
            textBoxAbout_PKK.Text = resources.GetString("textBoxAbout_PKK.Text");
            // 
            // buttonAboutClose_PKK
            // 
            buttonAboutClose_PKK.BackColor = Color.WhiteSmoke;
            buttonAboutClose_PKK.Cursor = Cursors.Hand;
            buttonAboutClose_PKK.Location = new Point(604, 223);
            buttonAboutClose_PKK.Name = "buttonAboutClose_PKK";
            buttonAboutClose_PKK.Size = new Size(75, 28);
            buttonAboutClose_PKK.TabIndex = 2;
            buttonAboutClose_PKK.Text = "Закрыть";
            buttonAboutClose_PKK.UseVisualStyleBackColor = false;
            buttonAboutClose_PKK.Click += buttonAboutClose_PKK_Click;
            buttonAboutClose_PKK.MouseEnter += buttonAboutClose_PKK_MouseEnter;
            buttonAboutClose_PKK.MouseLeave += buttonAboutClose_PKK_MouseLeave;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 273);
            Controls.Add(buttonAboutClose_PKK);
            Controls.Add(textBoxAbout_PKK);
            Controls.Add(pictureBoxAvatar_PKK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_PKK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_PKK;
        private TextBox textBoxAbout_PKK;
        private Button buttonAboutClose_PKK;
    }
}