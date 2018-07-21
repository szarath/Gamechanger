namespace Gamechanger
{
    partial class GameChanger
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
            this.Cmbgames = new System.Windows.Forms.ComboBox();
            this.tblGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamechangerDataSet = new Gamechanger.gamechangerDataSet();
            this.tblGameTableAdapter = new Gamechanger.gamechangerDataSetTableAdapters.tblGameTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtdeath = new System.Windows.Forms.TextBox();
            this.txtkill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntimer = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.txttime = new System.Windows.Forms.TextBox();
            this.txtign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtsnews = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamechangerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmbgames
            // 
            this.Cmbgames.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblGameBindingSource, "gNAME", true));
            this.Cmbgames.FormattingEnabled = true;
            this.Cmbgames.Location = new System.Drawing.Point(336, 12);
            this.Cmbgames.Name = "Cmbgames";
            this.Cmbgames.Size = new System.Drawing.Size(222, 21);
            this.Cmbgames.TabIndex = 1;
            this.Cmbgames.Text = "Choose a game";
            // 
            // tblGameBindingSource
            // 
            this.tblGameBindingSource.DataMember = "tblGame";
            this.tblGameBindingSource.DataSource = this.gamechangerDataSet;
            // 
            // gamechangerDataSet
            // 
            this.gamechangerDataSet.DataSetName = "gamechangerDataSet";
            this.gamechangerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGameTableAdapter
            // 
            this.tblGameTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(335, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(222, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(303, 249);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // txtdeath
            // 
            this.txtdeath.Location = new System.Drawing.Point(457, 133);
            this.txtdeath.Name = "txtdeath";
            this.txtdeath.Size = new System.Drawing.Size(100, 20);
            this.txtdeath.TabIndex = 4;
            // 
            // txtkill
            // 
            this.txtkill.Location = new System.Drawing.Point(336, 133);
            this.txtkill.Name = "txtkill";
            this.txtkill.Size = new System.Drawing.Size(99, 20);
            this.txtkill.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kills";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deaths ";
            // 
            // btntimer
            // 
            this.btntimer.Location = new System.Drawing.Point(457, 238);
            this.btntimer.Name = "btntimer";
            this.btntimer.Size = new System.Drawing.Size(100, 21);
            this.btntimer.TabIndex = 8;
            this.btntimer.Text = "Start Timer";
            this.btntimer.UseVisualStyleBackColor = true;
            this.btntimer.Click += new System.EventHandler(this.btntimer_Click);
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(336, 49);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(222, 37);
            this.btncheck.TabIndex = 10;
            this.btncheck.Text = "Check Data";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(336, 238);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(100, 20);
            this.txttime.TabIndex = 11;
            // 
            // txtign
            // 
            this.txtign.Location = new System.Drawing.Point(12, 299);
            this.txtign.Multiline = true;
            this.txtign.Name = "txtign";
            this.txtign.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtign.Size = new System.Drawing.Size(546, 245);
            this.txtign.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.3F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "IGN News";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Timer";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(336, 265);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 13);
            this.lbltime.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtsnews
            // 
            this.txtsnews.Location = new System.Drawing.Point(574, 36);
            this.txtsnews.Multiline = true;
            this.txtsnews.Name = "txtsnews";
            this.txtsnews.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsnews.Size = new System.Drawing.Size(644, 508);
            this.txtsnews.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.3F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Game News";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // GameChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsnews);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtign);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.btntimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkill);
            this.Controls.Add(this.txtdeath);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Cmbgames);
            this.Name = "GameChanger";
            this.Text = "GameChanger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamechangerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmbgames;
        private gamechangerDataSet gamechangerDataSet;
        private System.Windows.Forms.BindingSource tblGameBindingSource;
        private gamechangerDataSetTableAdapters.tblGameTableAdapter tblGameTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtdeath;
        private System.Windows.Forms.TextBox txtkill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btntimer;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.TextBox txtign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtsnews;
        private System.Windows.Forms.Label label5;
    }
}

