
namespace MIS566_group_project
{
    partial class schedulePickUp
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
            this.PUSchudChatbot = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lNBAirlinesDataSet = new MIS566_group_project.LNBAirlinesDataSet();
            this.fullScheduleLNBAirlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.full_Schedule_LNB_AirlinesTableAdapter = new MIS566_group_project.LNBAirlinesDataSetTableAdapters.Full_Schedule_LNB_AirlinesTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lNBAirlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullScheduleLNBAirlinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PUSchudChatbot
            // 
            this.PUSchudChatbot.Location = new System.Drawing.Point(12, 12);
            this.PUSchudChatbot.Name = "PUSchudChatbot";
            this.PUSchudChatbot.ReadOnly = true;
            this.PUSchudChatbot.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.PUSchudChatbot.Size = new System.Drawing.Size(370, 392);
            this.PUSchudChatbot.TabIndex = 1;
            this.PUSchudChatbot.Text = "Chatbot>  Please type in your work location (Manhattan, Kansas City, Wichita) or " +
    "type exit to go back.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User type below";
            // 
            // lNBAirlinesDataSet
            // 
            this.lNBAirlinesDataSet.DataSetName = "LNBAirlinesDataSet";
            this.lNBAirlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fullScheduleLNBAirlinesBindingSource
            // 
            this.fullScheduleLNBAirlinesBindingSource.DataMember = "Full_Schedule_LNB_Airlines";
            this.fullScheduleLNBAirlinesBindingSource.DataSource = this.lNBAirlinesDataSet;
            // 
            // full_Schedule_LNB_AirlinesTableAdapter
            // 
            this.full_Schedule_LNB_AirlinesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(412, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(769, 392);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 467);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 44);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // schedulePickUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 550);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PUSchudChatbot);
            this.Name = "schedulePickUp";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.schedulePickUp_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.lNBAirlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullScheduleLNBAirlinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SchudChatbot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox PUSchuserin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox PUSchudChatbot;
        private System.Windows.Forms.Label label2;
        private LNBAirlinesDataSet lNBAirlinesDataSet;
        private System.Windows.Forms.BindingSource fullScheduleLNBAirlinesBindingSource;
        private LNBAirlinesDataSetTableAdapters.Full_Schedule_LNB_AirlinesTableAdapter full_Schedule_LNB_AirlinesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}