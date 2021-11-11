
namespace test
{
    partial class Form5
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
            this.panelBorder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUser2 = new System.Windows.Forms.Panel();
            this.textBoxUser2Chat = new System.Windows.Forms.TextBox();
            this.labelUser2Name = new System.Windows.Forms.Label();
            this.roundPictureBoxUser2Pic = new test.RoundPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelBorder.SuspendLayout();
            this.panelUser2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxUser2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelBorder.Controls.Add(this.pictureBox1);
            this.panelBorder.Controls.Add(this.label1);
            this.panelBorder.Controls.Add(this.pictureBoxClose);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(365, 20);
            this.panelBorder.TabIndex = 5;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(24, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insert";
            // 
            // panelUser2
            // 
            this.panelUser2.Controls.Add(this.roundPictureBoxUser2Pic);
            this.panelUser2.Controls.Add(this.textBoxUser2Chat);
            this.panelUser2.Controls.Add(this.labelUser2Name);
            this.panelUser2.Location = new System.Drawing.Point(12, 42);
            this.panelUser2.Name = "panelUser2";
            this.panelUser2.Size = new System.Drawing.Size(341, 65);
            this.panelUser2.TabIndex = 13;
            // 
            // textBoxUser2Chat
            // 
            this.textBoxUser2Chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.textBoxUser2Chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser2Chat.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser2Chat.Location = new System.Drawing.Point(59, 37);
            this.textBoxUser2Chat.Multiline = true;
            this.textBoxUser2Chat.Name = "textBoxUser2Chat";
            this.textBoxUser2Chat.Size = new System.Drawing.Size(266, 21);
            this.textBoxUser2Chat.TabIndex = 9;
            // 
            // labelUser2Name
            // 
            this.labelUser2Name.AutoSize = true;
            this.labelUser2Name.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser2Name.Location = new System.Drawing.Point(56, 11);
            this.labelUser2Name.Name = "labelUser2Name";
            this.labelUser2Name.Size = new System.Drawing.Size(44, 16);
            this.labelUser2Name.TabIndex = 8;
            this.labelUser2Name.Text = "길동홍";
            // 
            // roundPictureBoxUser2Pic
            // 
            this.roundPictureBoxUser2Pic.Image = global::test.Properties.Resources.프로필;
            this.roundPictureBoxUser2Pic.Location = new System.Drawing.Point(3, 11);
            this.roundPictureBoxUser2Pic.Name = "roundPictureBoxUser2Pic";
            this.roundPictureBoxUser2Pic.Size = new System.Drawing.Size(47, 42);
            this.roundPictureBoxUser2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.roundPictureBoxUser2Pic.TabIndex = 7;
            this.roundPictureBoxUser2Pic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::test.Properties.Resources.message;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::test.Properties.Resources.window_close_icon_135015;
            this.pictureBoxClose.Location = new System.Drawing.Point(347, 2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 4;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(365, 121);
            this.Controls.Add(this.panelUser2);
            this.Controls.Add(this.panelBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            this.panelUser2.ResumeLayout(false);
            this.panelUser2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxUser2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Panel panelUser2;
        private RoundPictureBox roundPictureBoxUser2Pic;
        private System.Windows.Forms.TextBox textBoxUser2Chat;
        private System.Windows.Forms.Label labelUser2Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}