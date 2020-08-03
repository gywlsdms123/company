namespace ledger_gst
{
    partial class Register
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spinAnt = new DevExpress.XtraEditors.SpinEdit();
            this.txtContent = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.radExpend = new System.Windows.Forms.RadioButton();
            this.radIncome = new System.Windows.Forms.RadioButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ledgerDBDataSet = new ledger_gst.ledgerDBDataSet();
            this.ledgerDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAnt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.btnNew);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(417, 100);
            this.panelControl2.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(120, 10);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(168, 36);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "수입 지출 등록";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(10, 49);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 49);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnClose);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 485);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(417, 74);
            this.panelControl3.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(313, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.lookUpEdit1);
            this.panelControl4.Controls.Add(this.labelControl5);
            this.panelControl4.Controls.Add(this.labelControl4);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.spinAnt);
            this.panelControl4.Controls.Add(this.txtContent);
            this.panelControl4.Controls.Add(this.dateEdit1);
            this.panelControl4.Controls.Add(this.radExpend);
            this.panelControl4.Controls.Add(this.radIncome);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 102);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(417, 383);
            this.panelControl4.TabIndex = 2;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(160, 137);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.queryBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "Sub_name";
            this.lookUpEdit1.Properties.ValueMember = "Sub_name";
            this.lookUpEdit1.Size = new System.Drawing.Size(228, 24);
            this.lookUpEdit1.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(100, 257);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 18);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "금액";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(100, 196);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 18);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "내용";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(100, 140);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 18);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "항목";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(100, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 18);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "날짜";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 18);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "구분(수입/지출)";
            // 
            // spinAnt
            // 
            this.spinAnt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinAnt.Location = new System.Drawing.Point(160, 252);
            this.spinAnt.Name = "spinAnt";
            this.spinAnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAnt.Size = new System.Drawing.Size(228, 24);
            this.spinAnt.TabIndex = 6;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(160, 193);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(228, 24);
            this.txtContent.TabIndex = 5;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(160, 77);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(228, 24);
            this.dateEdit1.TabIndex = 3;
            // 
            // radExpend
            // 
            this.radExpend.AutoSize = true;
            this.radExpend.Location = new System.Drawing.Point(277, 24);
            this.radExpend.Name = "radExpend";
            this.radExpend.Size = new System.Drawing.Size(55, 22);
            this.radExpend.TabIndex = 2;
            this.radExpend.TabStop = true;
            this.radExpend.Text = "지출";
            this.radExpend.UseVisualStyleBackColor = true;
            // 
            // radIncome
            // 
            this.radIncome.AutoSize = true;
            this.radIncome.Location = new System.Drawing.Point(160, 24);
            this.radIncome.Name = "radIncome";
            this.radIncome.Size = new System.Drawing.Size(55, 22);
            this.radIncome.TabIndex = 1;
            this.radIncome.TabStop = true;
            this.radIncome.Text = "수입";
            this.radIncome.UseVisualStyleBackColor = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(421, 561);
            this.panelControl1.TabIndex = 0;
            // 
            // ledgerDBDataSet
            // 
            this.ledgerDBDataSet.DataSetName = "ledgerDBDataSet";
            this.ledgerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ledgerDBDataSetBindingSource
            // 
            this.ledgerDBDataSetBindingSource.DataSource = this.ledgerDBDataSet;
            this.ledgerDBDataSetBindingSource.Position = 0;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ledgerDBConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = "Select Sub_name FROM ComCodemaster";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IlF1ZXJ5Ij48RmllbGQgTmFtZ" +
    "T0iU3ViX25hbWUiIFR5cGU9IlN0cmluZyIgLz48L1ZpZXc+PC9EYXRhU2V0Pg==";
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataSource1;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 561);
            this.Controls.Add(this.panelControl1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAnt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledgerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledgerDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinAnt;
        private DevExpress.XtraEditors.TextEdit txtContent;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.RadioButton radExpend;
        private System.Windows.Forms.RadioButton radIncome;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private ledgerDBDataSet ledgerDBDataSet;
        private System.Windows.Forms.BindingSource ledgerDBDataSetBindingSource;
    }
}