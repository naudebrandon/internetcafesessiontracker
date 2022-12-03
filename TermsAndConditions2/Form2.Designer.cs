namespace TermsAndConditions2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnEndSession = new System.Windows.Forms.Button();
            this.lblHour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrST = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnEndSession
            // 
            this.btnEndSession.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEndSession.Location = new System.Drawing.Point(0, 25);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(110, 28);
            this.btnEndSession.TabIndex = 0;
            this.btnEndSession.Text = "End Session";
            this.btnEndSession.UseVisualStyleBackColor = true;
            this.btnEndSession.Click += new System.EventHandler(this.btnEndSession_Click);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(7, 9);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(19, 13);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(47, 9);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(19, 13);
            this.lblmin.TabIndex = 4;
            this.lblmin.Text = "00";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Location = new System.Drawing.Point(88, 9);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(19, 13);
            this.lblsecond.TabIndex = 5;
            this.lblsecond.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // tmrST
            // 
            this.tmrST.Tick += new System.EventHandler(this.tmrST_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(110, 53);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsecond);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.btnEndSession);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Time Used";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndSession;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrST;
    }
}