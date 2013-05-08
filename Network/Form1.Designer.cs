namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_adapter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.ipTextBox1 = new DeltaCat.Net.Controls.IPTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipTextBox2 = new DeltaCat.Net.Controls.IPTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipTextBox3 = new DeltaCat.Net.Controls.IPTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_adapter,
            this.MenuItem_setting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(305, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem_adapter
            // 
            this.MenuItem_adapter.Name = "MenuItem_adapter";
            this.MenuItem_adapter.Size = new System.Drawing.Size(80, 20);
            this.MenuItem_adapter.Text = "網路介面卡";
            // 
            // MenuItem_setting
            // 
            this.MenuItem_setting.Name = "MenuItem_setting";
            this.MenuItem_setting.Size = new System.Drawing.Size(56, 20);
            this.MenuItem_setting.Text = "設定檔";
            // 
            // ipTextBox1
            // 
            this.ipTextBox1.Location = new System.Drawing.Point(130, 54);
            this.ipTextBox1.MaximumSize = new System.Drawing.Size(150, 24);
            this.ipTextBox1.MinimumSize = new System.Drawing.Size(140, 21);
            this.ipTextBox1.Name = "ipTextBox1";
            this.ipTextBox1.Padding = new System.Windows.Forms.Padding(1);
            this.ipTextBox1.ShowErrorFlag = true;
            this.ipTextBox1.Size = new System.Drawing.Size(140, 21);
            this.ipTextBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP位址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10F);
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "子網路遮罩：";
            // 
            // ipTextBox2
            // 
            this.ipTextBox2.Location = new System.Drawing.Point(130, 81);
            this.ipTextBox2.MaximumSize = new System.Drawing.Size(150, 24);
            this.ipTextBox2.MinimumSize = new System.Drawing.Size(140, 21);
            this.ipTextBox2.Name = "ipTextBox2";
            this.ipTextBox2.Padding = new System.Windows.Forms.Padding(1);
            this.ipTextBox2.ShowErrorFlag = true;
            this.ipTextBox2.Size = new System.Drawing.Size(140, 21);
            this.ipTextBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F);
            this.label3.Location = new System.Drawing.Point(42, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "預設閘道：";
            // 
            // ipTextBox3
            // 
            this.ipTextBox3.Location = new System.Drawing.Point(130, 108);
            this.ipTextBox3.MaximumSize = new System.Drawing.Size(150, 24);
            this.ipTextBox3.MinimumSize = new System.Drawing.Size(140, 21);
            this.ipTextBox3.Name = "ipTextBox3";
            this.ipTextBox3.Padding = new System.Windows.Forms.Padding(1);
            this.ipTextBox3.ShowErrorFlag = true;
            this.ipTextBox3.Size = new System.Drawing.Size(140, 21);
            this.ipTextBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipTextBox1);
            this.Controls.Add(this.ipTextBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ipTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_adapter;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_setting;
        private DeltaCat.Net.Controls.IPTextBox ipTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DeltaCat.Net.Controls.IPTextBox ipTextBox2;
        private System.Windows.Forms.Label label3;
        private DeltaCat.Net.Controls.IPTextBox ipTextBox3;


    }
}

