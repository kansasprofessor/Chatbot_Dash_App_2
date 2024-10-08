
namespace MIS566_group_project
{
    partial class scheduleTakeOff
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
            this.SchudChatbot = new System.Windows.Forms.RichTextBox();
            this.Schuserin = new System.Windows.Forms.RichTextBox();
            this.lNBAirlines_EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lNBAirlinesDataSet = new MIS566_group_project.LNBAirlinesDataSet();
            this.lNBAirlines_EmployeesTableAdapter = new MIS566_group_project.LNBAirlinesDataSetTableAdapters.LNBAirlines_EmployeesTableAdapter();
            this.tableAdapterManager = new MIS566_group_project.LNBAirlinesDataSetTableAdapters.TableAdapterManager();
            this.full_Schedule_LNB_AirlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.full_Schedule_LNB_AirlinesTableAdapter = new MIS566_group_project.LNBAirlinesDataSetTableAdapters.Full_Schedule_LNB_AirlinesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lNBAirlines_EmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBAirlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.full_Schedule_LNB_AirlinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SchudChatbot
            // 
            this.SchudChatbot.Location = new System.Drawing.Point(12, 12);
            this.SchudChatbot.Name = "SchudChatbot";
            this.SchudChatbot.ReadOnly = true;
            this.SchudChatbot.Size = new System.Drawing.Size(370, 392);
            this.SchudChatbot.TabIndex = 3;
            this.SchudChatbot.Text = "Chatbot>  Please type in your work location (Manhattan, Kansas City, Wichita) or " +
    "type exit to go back.";
            // 
            // Schuserin
            // 
            this.Schuserin.Location = new System.Drawing.Point(12, 458);
            this.Schuserin.Multiline = false;
            this.Schuserin.Name = "Schuserin";
            this.Schuserin.Size = new System.Drawing.Size(370, 44);
            this.Schuserin.TabIndex = 4;
            this.Schuserin.Text = "";
            this.Schuserin.TextChanged += new System.EventHandler(this.Schuserin_TextChanged);
            this.Schuserin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Schuserin_KeyDown);
            // 
            // lNBAirlines_EmployeesBindingSource
            // 
            this.lNBAirlines_EmployeesBindingSource.DataMember = "LNBAirlines_Employees";
            this.lNBAirlines_EmployeesBindingSource.DataSource = this.lNBAirlinesDataSet;
            // 
            // lNBAirlinesDataSet
            // 
            this.lNBAirlinesDataSet.DataSetName = "LNBAirlinesDataSet";
            this.lNBAirlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lNBAirlines_EmployeesTableAdapter
            // 
            this.lNBAirlines_EmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Full_Schedule_LNB_AirlinesTableAdapter = null;
            this.tableAdapterManager.LNBAirlines_EmployeesTableAdapter = this.lNBAirlines_EmployeesTableAdapter;
            this.tableAdapterManager.LNBAirlines_LocationTableAdapter = null;
            this.tableAdapterManager.LNBAirlines_LoginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MIS566_group_project.LNBAirlinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // full_Schedule_LNB_AirlinesBindingSource
            // 
            this.full_Schedule_LNB_AirlinesBindingSource.DataMember = "Full_Schedule_LNB_Airlines";
            this.full_Schedule_LNB_AirlinesBindingSource.DataSource = this.lNBAirlinesDataSet;
            // 
            // full_Schedule_LNB_AirlinesTableAdapter
            // 
            this.full_Schedule_LNB_AirlinesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(750, 392);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "User type below\r\n";
            // 
            // scheduleTakeOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Schuserin);
            this.Controls.Add(this.SchudChatbot);
            this.Name = "scheduleTakeOff";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.monthschedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lNBAirlines_EmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBAirlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.full_Schedule_LNB_AirlinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox SchudChatbot;
        private System.Windows.Forms.RichTextBox Schuserin;
        private LNBAirlinesDataSet lNBAirlinesDataSet;
        private System.Windows.Forms.BindingSource lNBAirlines_EmployeesBindingSource;
        private LNBAirlinesDataSetTableAdapters.LNBAirlines_EmployeesTableAdapter lNBAirlines_EmployeesTableAdapter;
        private LNBAirlinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource full_Schedule_LNB_AirlinesBindingSource;
        private LNBAirlinesDataSetTableAdapters.Full_Schedule_LNB_AirlinesTableAdapter full_Schedule_LNB_AirlinesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}