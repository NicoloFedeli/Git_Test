namespace Git_Test
{
    partial class frmMain
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
            this.txtavvio2 = new System.Windows.Forms.TextBox();
            this.txtAvvia100 = new System.Windows.Forms.TextBox();
            this.btnAvvio2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnAvvio100 = new System.Windows.Forms.Button();
            this.btnStop100 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtavvio2
            // 
            this.txtavvio2.Location = new System.Drawing.Point(84, 35);
            this.txtavvio2.Multiline = true;
            this.txtavvio2.Name = "txtavvio2";
            this.txtavvio2.Size = new System.Drawing.Size(212, 186);
            this.txtavvio2.TabIndex = 0;
            // 
            // txtAvvia100
            // 
            this.txtAvvia100.Location = new System.Drawing.Point(493, 35);
            this.txtAvvia100.Multiline = true;
            this.txtAvvia100.Name = "txtAvvia100";
            this.txtAvvia100.Size = new System.Drawing.Size(212, 186);
            this.txtAvvia100.TabIndex = 1;
            // 
            // btnAvvio2
            // 
            this.btnAvvio2.Location = new System.Drawing.Point(93, 277);
            this.btnAvvio2.Name = "btnAvvio2";
            this.btnAvvio2.Size = new System.Drawing.Size(203, 56);
            this.btnAvvio2.TabIndex = 2;
            this.btnAvvio2.Text = "Avvio 2";
            this.btnAvvio2.UseVisualStyleBackColor = true;
            this.btnAvvio2.Click += new System.EventHandler(this.btnAvvio2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(93, 358);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(203, 56);
            this.btnStop2.TabIndex = 3;
            this.btnStop2.Text = "Stop 2";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnAvvio100
            // 
            this.btnAvvio100.Location = new System.Drawing.Point(493, 277);
            this.btnAvvio100.Name = "btnAvvio100";
            this.btnAvvio100.Size = new System.Drawing.Size(212, 56);
            this.btnAvvio100.TabIndex = 4;
            this.btnAvvio100.Text = "Avvio 100";
            this.btnAvvio100.UseVisualStyleBackColor = true;
            this.btnAvvio100.Click += new System.EventHandler(this.btnAvvio100_Click);
            // 
            // btnStop100
            // 
            this.btnStop100.Location = new System.Drawing.Point(493, 358);
            this.btnStop100.Name = "btnStop100";
            this.btnStop100.Size = new System.Drawing.Size(212, 56);
            this.btnStop100.TabIndex = 5;
            this.btnStop100.Text = "Stop 100";
            this.btnStop100.UseVisualStyleBackColor = true;
            this.btnStop100.Click += new System.EventHandler(this.btnStop100_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop100);
            this.Controls.Add(this.btnAvvio100);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnAvvio2);
            this.Controls.Add(this.txtAvvia100);
            this.Controls.Add(this.txtavvio2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtavvio2;
        private System.Windows.Forms.TextBox txtAvvia100;
        private System.Windows.Forms.Button btnAvvio2;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnAvvio100;
        private System.Windows.Forms.Button btnStop100;
    }
}

