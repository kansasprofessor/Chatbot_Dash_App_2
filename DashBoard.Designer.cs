
namespace MIS566_group_project
{
    partial class DashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.full_Schedule_LNB_AirlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lNBAirlinesDataSet = new MIS566_group_project.LNBAirlinesDataSet();
            this.full_Schedule_LNB_AirlinesTableAdapter = new MIS566_group_project.LNBAirlinesDataSetTableAdapters.Full_Schedule_LNB_AirlinesTableAdapter();
            this.tableAdapterManager = new MIS566_group_project.LNBAirlinesDataSetTableAdapters.TableAdapterManager();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSet1 = new MIS566_group_project.DataSet1();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.full_Schedule_LNB_AirlinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBAirlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Go to chatbot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to the Dashboard";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // full_Schedule_LNB_AirlinesBindingSource
            // 
            this.full_Schedule_LNB_AirlinesBindingSource.DataSource = this.lNBAirlinesDataSet;
            this.full_Schedule_LNB_AirlinesBindingSource.Position = 0;
            // 
            // lNBAirlinesDataSet
            // 
            this.lNBAirlinesDataSet.DataSetName = "LNBAirlinesDataSet";
            this.lNBAirlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // full_Schedule_LNB_AirlinesTableAdapter
            // 
            this.full_Schedule_LNB_AirlinesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Full_Schedule_LNB_AirlinesTableAdapter = this.full_Schedule_LNB_AirlinesTableAdapter;
            this.tableAdapterManager.LNBAirlines_EmployeesTableAdapter = null;
            this.tableAdapterManager.LNBAirlines_LocationTableAdapter = null;
            this.tableAdapterManager.LNBAirlines_LoginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MIS566_group_project.LNBAirlinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(17, 87);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 62;
            this.dgvSchedule.RowTemplate.Height = 28;
            this.dgvSchedule.Size = new System.Drawing.Size(737, 414);
            this.dgvSchedule.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please select a Location";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(792, 87);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "LocationName";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(468, 414);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1272, 638);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.full_Schedule_LNB_AirlinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNBAirlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private LNBAirlinesDataSet lNBAirlinesDataSet;
        private System.Windows.Forms.BindingSource full_Schedule_LNB_AirlinesBindingSource;
        private LNBAirlinesDataSetTableAdapters.Full_Schedule_LNB_AirlinesTableAdapter full_Schedule_LNB_AirlinesTableAdapter;
        private LNBAirlinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}