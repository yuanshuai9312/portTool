namespace 查看本机端口使用工具
{
    partial class FormPort
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c_pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Proto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Foreign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.终止此进程KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_find = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblinfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_pid,
            this.c_Proto,
            this.C_Port,
            this.C_ProcessName,
            this.C_FileName,
            this.C_Local,
            this.C_Foreign,
            this.C_State});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(635, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dataGridView1_CellToolTipTextNeeded);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // c_pid
            // 
            this.c_pid.DataPropertyName = "PID";
            this.c_pid.HeaderText = "PID";
            this.c_pid.Name = "c_pid";
            this.c_pid.ReadOnly = true;
            // 
            // c_Proto
            // 
            this.c_Proto.DataPropertyName = "Proto";
            this.c_Proto.HeaderText = "协议";
            this.c_Proto.Name = "c_Proto";
            this.c_Proto.ReadOnly = true;
            // 
            // C_Port
            // 
            this.C_Port.DataPropertyName = "Port";
            this.C_Port.HeaderText = "端口";
            this.C_Port.Name = "C_Port";
            this.C_Port.ReadOnly = true;
            // 
            // C_ProcessName
            // 
            this.C_ProcessName.DataPropertyName = "ProcessName";
            this.C_ProcessName.HeaderText = "所属进程名";
            this.C_ProcessName.Name = "C_ProcessName";
            this.C_ProcessName.ReadOnly = true;
            // 
            // C_FileName
            // 
            this.C_FileName.DataPropertyName = "FileName";
            this.C_FileName.HeaderText = "进程文件";
            this.C_FileName.Name = "C_FileName";
            this.C_FileName.ReadOnly = true;
            this.C_FileName.Visible = false;
            // 
            // C_Local
            // 
            this.C_Local.DataPropertyName = "Local_Address";
            this.C_Local.HeaderText = "本地绑定地址";
            this.C_Local.Name = "C_Local";
            this.C_Local.ReadOnly = true;
            this.C_Local.Width = 110;
            // 
            // C_Foreign
            // 
            this.C_Foreign.DataPropertyName = "Foreign_Address";
            this.C_Foreign.HeaderText = "远程地址";
            this.C_Foreign.Name = "C_Foreign";
            this.C_Foreign.ReadOnly = true;
            // 
            // C_State
            // 
            this.C_State.DataPropertyName = "State";
            this.C_State.HeaderText = "当前状态";
            this.C_State.Name = "C_State";
            this.C_State.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.终止此进程KToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // 终止此进程KToolStripMenuItem
            // 
            this.终止此进程KToolStripMenuItem.Name = "终止此进程KToolStripMenuItem";
            this.终止此进程KToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.终止此进程KToolStripMenuItem.Text = "终止此进程(&K)";
            this.终止此进程KToolStripMenuItem.Click += new System.EventHandler(this.终止此进程KToolStripMenuItem_Click);
            // 
            // btn_find
            // 
            this.btn_find.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_find.Location = new System.Drawing.Point(265, 455);
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(105, 33);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "查看端口情况";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(12, 401);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(43, 17);
            this.lblinfo.TabIndex = 2;
            this.lblinfo.Text = "label1";
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 504);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPort";
            this.Text = "FormPort";
            this.Load += new System.EventHandler(this.FormPort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem 终止此进程KToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Proto;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Foreign;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_State;
        private System.Windows.Forms.Label lblinfo;
    }
}