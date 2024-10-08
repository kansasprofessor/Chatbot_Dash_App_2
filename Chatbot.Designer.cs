
namespace MIS566_group_project
{
    partial class Chatbot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chatbot));
            this.label1 = new System.Windows.Forms.Label();
            this.chatbottext = new System.Windows.Forms.RichTextBox();
            this.userinput = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the LNB Chatbot";
            // 
            // chatbottext
            // 
            this.chatbottext.Location = new System.Drawing.Point(41, 69);
            this.chatbottext.Name = "chatbottext";
            this.chatbottext.ReadOnly = true;
            this.chatbottext.Size = new System.Drawing.Size(483, 320);
            this.chatbottext.TabIndex = 4;
            this.chatbottext.Text = "Chatbot>   Hello this is the chatbot please type how I can help you, or type exit" +
    " to go back to the dashboard.";
            // 
            // userinput
            // 
            this.userinput.Location = new System.Drawing.Point(41, 415);
            this.userinput.Multiline = false;
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(483, 54);
            this.userinput.TabIndex = 5;
            this.userinput.Text = "";
            this.userinput.TextChanged += new System.EventHandler(this.userinput_TextChanged_1);
            this.userinput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userinput_KeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(542, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(287, 320);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Chatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 505);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.chatbottext);
            this.Controls.Add(this.label1);
            this.Name = "Chatbot";
            this.Text = "Chatbot";
            this.Load += new System.EventHandler(this.Chatbot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox chatbottext;
        private System.Windows.Forms.RichTextBox userinput;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}