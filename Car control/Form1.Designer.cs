namespace Car_control
{
    partial class Form1
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
            this.btOpen = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flControl = new System.Windows.Forms.FlowLayoutPanel();
            this.btUp = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOpen.Location = new System.Drawing.Point(12, 43);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(72, 29);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btClose.Location = new System.Drawing.Point(90, 43);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(72, 29);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(168, 51);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(79, 21);
            this.cmbPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(187, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PORT";
            // 
            // flControl
            // 
            this.flControl.BackColor = System.Drawing.Color.DarkRed;
            this.flControl.Location = new System.Drawing.Point(257, 51);
            this.flControl.Name = "flControl";
            this.flControl.Size = new System.Drawing.Size(23, 21);
            this.flControl.TabIndex = 4;
            // 
            // btUp
            // 
            this.btUp.BackColor = System.Drawing.Color.MediumBlue;
            this.btUp.Location = new System.Drawing.Point(72, 123);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(18, 38);
            this.btUp.TabIndex = 5;
            this.btUp.UseVisualStyleBackColor = false;
            // 
            // btRight
            // 
            this.btRight.BackColor = System.Drawing.Color.MediumBlue;
            this.btRight.Location = new System.Drawing.Point(95, 161);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(38, 18);
            this.btRight.TabIndex = 6;
            this.btRight.UseVisualStyleBackColor = false;
            // 
            // btDown
            // 
            this.btDown.BackColor = System.Drawing.Color.MediumBlue;
            this.btDown.Location = new System.Drawing.Point(72, 184);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(18, 38);
            this.btDown.TabIndex = 7;
            this.btDown.UseVisualStyleBackColor = false;
            // 
            // btLeft
            // 
            this.btLeft.BackColor = System.Drawing.Color.MediumBlue;
            this.btLeft.Location = new System.Drawing.Point(28, 161);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(38, 18);
            this.btLeft.TabIndex = 8;
            this.btLeft.UseVisualStyleBackColor = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(25, 235);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 257);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.flControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btOpen);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.k_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.k_up);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flControl;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Label lbl;

    }
}

