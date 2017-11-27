namespace _21_1_pasibandymai
{
    partial class IvestiDuomenisForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVardas = new System.Windows.Forms.MaskedTextBox();
            this.textBoxAmzius = new System.Windows.Forms.MaskedTextBox();
            this.buttonGerai = new System.Windows.Forms.Button();
            this.buttonAtsaukti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amzius";
            // 
            // textBoxVardas
            // 
            this.textBoxVardas.Location = new System.Drawing.Point(123, 52);
            this.textBoxVardas.Name = "textBoxVardas";
            this.textBoxVardas.Size = new System.Drawing.Size(148, 22);
            this.textBoxVardas.TabIndex = 2;
            this.textBoxVardas.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textBoxAmzius
            // 
            this.textBoxAmzius.Location = new System.Drawing.Point(123, 92);
            this.textBoxAmzius.Name = "textBoxAmzius";
            this.textBoxAmzius.Size = new System.Drawing.Size(148, 22);
            this.textBoxAmzius.TabIndex = 3;
            // 
            // buttonGerai
            // 
            this.buttonGerai.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonGerai.Location = new System.Drawing.Point(50, 138);
            this.buttonGerai.Name = "buttonGerai";
            this.buttonGerai.Size = new System.Drawing.Size(96, 56);
            this.buttonGerai.TabIndex = 4;
            this.buttonGerai.Text = "Gerai";
            this.buttonGerai.UseVisualStyleBackColor = true;
            this.buttonGerai.Click += new System.EventHandler(this.buttonGerai_Click);
            // 
            // buttonAtsaukti
            // 
            this.buttonAtsaukti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAtsaukti.Location = new System.Drawing.Point(175, 138);
            this.buttonAtsaukti.Name = "buttonAtsaukti";
            this.buttonAtsaukti.Size = new System.Drawing.Size(96, 56);
            this.buttonAtsaukti.TabIndex = 5;
            this.buttonAtsaukti.Text = "Atsaukti";
            this.buttonAtsaukti.UseVisualStyleBackColor = true;
            // 
            // IvestiDuomenisForma
            // 
            this.AcceptButton = this.buttonGerai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAtsaukti;
            this.ClientSize = new System.Drawing.Size(335, 253);
            this.Controls.Add(this.buttonAtsaukti);
            this.Controls.Add(this.buttonGerai);
            this.Controls.Add(this.textBoxAmzius);
            this.Controls.Add(this.textBoxVardas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IvestiDuomenisForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ivesti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textBoxVardas;
        private System.Windows.Forms.MaskedTextBox textBoxAmzius;
        private System.Windows.Forms.Button buttonGerai;
        private System.Windows.Forms.Button buttonAtsaukti;
    }
}