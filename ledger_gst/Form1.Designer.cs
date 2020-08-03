namespace ledger_gst
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btn_resigter = new System.Windows.Forms.Button();
            this.btn_Look = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(421, 80);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(157, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Menu";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Close);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 497);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(421, 64);
            this.panelControl2.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Location = new System.Drawing.Point(262, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(113, 40);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "닫기";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btnItem
            // 
            this.btnItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItem.Location = new System.Drawing.Point(25, 26);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(370, 59);
            this.btnItem.TabIndex = 0;
            this.btnItem.Text = "항목관리";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btn_resigter
            // 
            this.btn_resigter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resigter.Location = new System.Drawing.Point(25, 120);
            this.btn_resigter.Name = "btn_resigter";
            this.btn_resigter.Size = new System.Drawing.Size(370, 59);
            this.btn_resigter.TabIndex = 1;
            this.btn_resigter.Text = "수입, 지출 등록";
            this.btn_resigter.UseVisualStyleBackColor = true;
            this.btn_resigter.Click += new System.EventHandler(this.btn_resigter_Click);
            // 
            // btn_Look
            // 
            this.btn_Look.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Look.Location = new System.Drawing.Point(25, 217);
            this.btn_Look.Name = "btn_Look";
            this.btn_Look.Size = new System.Drawing.Size(370, 59);
            this.btn_Look.TabIndex = 2;
            this.btn_Look.Text = "가계부 조회";
            this.btn_Look.UseVisualStyleBackColor = true;
            this.btn_Look.Click += new System.EventHandler(this.btn_Look_Click);
            // 
            // btn_total
            // 
            this.btn_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_total.Location = new System.Drawing.Point(25, 310);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(370, 59);
            this.btn_total.TabIndex = 3;
            this.btn_total.Text = "항목별 집계";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_total);
            this.panelControl3.Controls.Add(this.btn_Look);
            this.panelControl3.Controls.Add(this.btn_resigter);
            this.panelControl3.Controls.Add(this.btnItem);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 80);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(421, 417);
            this.panelControl3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 561);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btn_resigter;
        private System.Windows.Forms.Button btn_Look;
        private System.Windows.Forms.Button btn_total;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}

