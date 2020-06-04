using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 查看本机端口使用工具
{
    public partial class FormPort : Form
    {
        public FormPort()
        {
            InitializeComponent();
        }
        List<PortInfo> curinfo = new List<PortInfo>();
        DataTable dt = new DataTable();
        ShellPort sp = new ShellPort();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = getPortDT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormPort_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
           PropertyInfo[] pis= typeof(PortInfo).GetProperties();
           foreach (PropertyInfo p in pis)
           {
               dt.Columns.Add(p.Name);
           }
           dt.Columns.Add("ProcessName");
           dt.Columns.Add("FileName");
        }

        private DataTable getPortDT()
        {
            dt.Rows.Clear();
            curinfo = sp.getAllPort();
            foreach (PortInfo p in curinfo)
            {
                DataRow dr = dt.NewRow();
                dr["Foreign_Address"] = p.Foreign_Address;
                dr["Local_Address"] = p.Local_Address;
                dr["PID"] = p.PID;
                dr["Port"] = p.Port;
                dr["Proto"] = p.Proto;
                dr["State"] = p.State;
                dr["ProcessName"] = p.BindProcess.ProcessName;
                try
                {
                    dr["FileName"] = p.BindProcess.MainModule.FileName;
                }
                catch
                {
                    dr["FileName"] = "";
                }
                dt.Rows.Add(dr);
            }
          return dt;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;                
            }
        }
       
        private void 终止此进程KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null && MessageBox.Show("确定要关闭此进程？","警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string curpid = dataGridView1.CurrentRow.Cells["c_pid"].Value.ToString();
                    PortInfo p = curinfo.Find(delegate(PortInfo cp)
                    {
                        return cp.PID.Equals(curpid);
                    });
                    p.BindProcess.Kill();
                    System.Threading.Thread.Sleep(10);
                    button1_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            try
            {

                string curpid = dataGridView1.Rows[e.RowIndex].Cells["c_pid"].Value.ToString();
                PortInfo p = curinfo.Find(delegate(PortInfo cp)
                                            {
                                                return cp.PID.Equals(curpid); 
                                            });
                e.ToolTipText = (string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["C_FileName"].Value.ToString()) ? "" : "关联文件:" + dataGridView1.Rows[e.RowIndex].Cells["C_FileName"].Value.ToString() + "\r\n") +
                                 "启动时间:" + p.BindProcess.StartTime.ToLongTimeString() + "\r\n" +
                                 "占用时间:" + p.BindProcess.UserProcessorTime.TotalMinutes + "秒\r\n" +
                                 "专用内存大小:" + p.BindProcess.PrivateMemorySize64 / 1024 + "KB";
            }
            catch
            { }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string curpid = dataGridView1.CurrentRow.Cells["c_pid"].Value.ToString();
                PortInfo p = curinfo.Find(delegate(PortInfo cp)
                {
                    return cp.PID.Equals(curpid);
                });
                lblinfo.Text = (string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["C_FileName"].Value.ToString()) ? "" : "关联文件:" + dataGridView1.CurrentRow.Cells["C_FileName"].Value.ToString() + "\r\n") +
                                 "启动时间:" + p.BindProcess.StartTime.ToLongTimeString() + "\r\n" +
                                 "占用时间:" + p.BindProcess.UserProcessorTime.TotalMinutes + "秒\r\n" +
                                 "专用内存大小:" + p.BindProcess.PrivateMemorySize64 / 1024 + "KB";
            }
            catch { }
        }
    }
}