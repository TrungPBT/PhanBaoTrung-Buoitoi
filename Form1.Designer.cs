namespace PhanBaoTrung_Buoitoi
{
    partial class Form1
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
            btn_Nhấp = new Button();
            btn_bienhinh = new Button();
            SuspendLayout();
            // 
            // btn_Nhấp
            // 
            btn_Nhấp.Location = new Point(105, 174);
            btn_Nhấp.Name = "btn_Nhấp";
            btn_Nhấp.Size = new Size(75, 37);
            btn_Nhấp.TabIndex = 0;
            btn_Nhấp.Text = "Nhấp";
            btn_Nhấp.UseVisualStyleBackColor = true;
            btn_Nhấp.Click += btn_Nhấp_Click;
            // 
            // btn_bienhinh
            // 
            btn_bienhinh.Location = new Point(500, 184);
            btn_bienhinh.Name = "btn_bienhinh";
            btn_bienhinh.Size = new Size(75, 53);
            btn_bienhinh.TabIndex = 1;
            btn_bienhinh.Text = "Siêu Nhân Gao";
            btn_bienhinh.UseVisualStyleBackColor = true;
            btn_bienhinh.Click += btn_bienhinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_bienhinh);
            Controls.Add(btn_Nhấp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Nhấp;
        private Button btn_bienhinh;
    }
}
