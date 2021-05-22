
namespace IOZugriff
{
    partial class ZugriffForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_OrdnerOeffnen = new System.Windows.Forms.Button();
            this.txt_OrdnerName = new System.Windows.Forms.TextBox();
            this.lbl_Ordner = new System.Windows.Forms.Label();
            this.lbl_Ausgabe = new System.Windows.Forms.Label();
            this.btn_Abbruch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OrdnerOeffnen
            // 
            this.btn_OrdnerOeffnen.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_OrdnerOeffnen.Location = new System.Drawing.Point(38, 30);
            this.btn_OrdnerOeffnen.Name = "btn_OrdnerOeffnen";
            this.btn_OrdnerOeffnen.Size = new System.Drawing.Size(503, 32);
            this.btn_OrdnerOeffnen.TabIndex = 0;
            this.btn_OrdnerOeffnen.Text = "Ordner öffnen";
            this.btn_OrdnerOeffnen.UseVisualStyleBackColor = true;
            this.btn_OrdnerOeffnen.Click += new System.EventHandler(this.Btn_OrdnerOeffnen_Click);
            // 
            // txt_OrdnerName
            // 
            this.txt_OrdnerName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_OrdnerName.Location = new System.Drawing.Point(38, 118);
            this.txt_OrdnerName.Name = "txt_OrdnerName";
            this.txt_OrdnerName.Size = new System.Drawing.Size(502, 25);
            this.txt_OrdnerName.TabIndex = 1;
            // 
            // lbl_Ordner
            // 
            this.lbl_Ordner.AutoSize = true;
            this.lbl_Ordner.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ordner.Location = new System.Drawing.Point(38, 95);
            this.lbl_Ordner.Name = "lbl_Ordner";
            this.lbl_Ordner.Size = new System.Drawing.Size(108, 20);
            this.lbl_Ordner.TabIndex = 2;
            this.lbl_Ordner.Text = "Gewählter Ordner";
            // 
            // lbl_Ausgabe
            // 
            this.lbl_Ausgabe.AutoSize = true;
            this.lbl_Ausgabe.Location = new System.Drawing.Point(43, 169);
            this.lbl_Ausgabe.Name = "lbl_Ausgabe";
            this.lbl_Ausgabe.Size = new System.Drawing.Size(0, 15);
            this.lbl_Ausgabe.TabIndex = 3;
            // 
            // btn_Abbruch
            // 
            this.btn_Abbruch.Location = new System.Drawing.Point(38, 211);
            this.btn_Abbruch.Name = "btn_Abbruch";
            this.btn_Abbruch.Size = new System.Drawing.Size(502, 33);
            this.btn_Abbruch.TabIndex = 4;
            this.btn_Abbruch.Text = "Abbruch";
            this.btn_Abbruch.UseVisualStyleBackColor = true;
            this.btn_Abbruch.Visible = false;
            this.btn_Abbruch.Click += new System.EventHandler(this.btn_Abbruch_Click);
            // 
            // ZugriffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 295);
            this.Controls.Add(this.btn_Abbruch);
            this.Controls.Add(this.lbl_Ausgabe);
            this.Controls.Add(this.lbl_Ordner);
            this.Controls.Add(this.txt_OrdnerName);
            this.Controls.Add(this.btn_OrdnerOeffnen);
            this.Name = "ZugriffForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ZugriffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txt_OrdnerName;
        private System.Windows.Forms.Label lbl_Ordner;
        private System.Windows.Forms.Label lbl_Ausgabe;
        private System.Windows.Forms.Button btn_Abbruch;
        private System.Windows.Forms.Button btn_OrdnerOeffnen;
    }
}

