namespace TranslateApp
{
    partial class TranslateApp
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
            this.textInput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.cmbSourceLang = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cmbTargetLang = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.translateButton = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.TextOutput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Animated = true;
            this.textInput.BackColor = System.Drawing.Color.Transparent;
            this.textInput.BorderRadius = 45;
            this.textInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textInput.DefaultText = "";
            this.textInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F);
            this.textInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInput.Location = new System.Drawing.Point(73, 99);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.PasswordChar = '\0';
            this.textInput.PlaceholderText = "Metin girin...";
            this.textInput.SelectedText = "";
            this.textInput.Size = new System.Drawing.Size(327, 278);
            this.textInput.TabIndex = 0;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // cmbSourceLang
            // 
            this.cmbSourceLang.BackColor = System.Drawing.Color.Transparent;
            this.cmbSourceLang.BorderRadius = 15;
            this.cmbSourceLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSourceLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceLang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.cmbSourceLang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSourceLang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSourceLang.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F);
            this.cmbSourceLang.ForeColor = System.Drawing.Color.White;
            this.cmbSourceLang.ItemHeight = 30;
            this.cmbSourceLang.Location = new System.Drawing.Point(157, 425);
            this.cmbSourceLang.Name = "cmbSourceLang";
            this.cmbSourceLang.Size = new System.Drawing.Size(140, 36);
            this.cmbSourceLang.TabIndex = 2;
            // 
            // cmbTargetLang
            // 
            this.cmbTargetLang.BackColor = System.Drawing.Color.Transparent;
            this.cmbTargetLang.BorderRadius = 15;
            this.cmbTargetLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTargetLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetLang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.cmbTargetLang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetLang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetLang.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F);
            this.cmbTargetLang.ForeColor = System.Drawing.Color.White;
            this.cmbTargetLang.ItemHeight = 30;
            this.cmbTargetLang.Location = new System.Drawing.Point(690, 425);
            this.cmbTargetLang.Name = "cmbTargetLang";
            this.cmbTargetLang.Size = new System.Drawing.Size(140, 36);
            this.cmbTargetLang.TabIndex = 3;
            // 
            // translateButton
            // 
            this.translateButton.Animated = true;
            this.translateButton.BorderRadius = 15;
            this.translateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.translateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.translateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.translateButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.translateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.translateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.translateButton.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.translateButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F);
            this.translateButton.ForeColor = System.Drawing.Color.White;
            this.translateButton.Location = new System.Drawing.Point(412, 486);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(165, 45);
            this.translateButton.TabIndex = 5;
            this.translateButton.Text = "Translate";
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.Animated = true;
            this.TextOutput.BackColor = System.Drawing.Color.Transparent;
            this.TextOutput.BorderRadius = 45;
            this.TextOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextOutput.DefaultText = "";
            this.TextOutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextOutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextOutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextOutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextOutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.TextOutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextOutput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F);
            this.TextOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextOutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextOutput.Location = new System.Drawing.Point(590, 99);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.PasswordChar = '\0';
            this.TextOutput.PlaceholderText = "Çeviri";
            this.TextOutput.SelectedText = "";
            this.TextOutput.Size = new System.Drawing.Size(327, 278);
            this.TextOutput.TabIndex = 1;
            this.TextOutput.TextChanged += new System.EventHandler(this.TextOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "ÇEVİRİ UYGULAMASI";
            // 
            // TranslateApp
            // 
            this.AcceptButton = this.translateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1017, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.cmbTargetLang);
            this.Controls.Add(this.cmbSourceLang);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.textInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TranslateApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranslateApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textInput;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbSourceLang;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbTargetLang;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton translateButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextOutput;
        private System.Windows.Forms.Label label1;
    }
}

