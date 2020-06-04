using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace 查看本机端口使用工具
{
    class ShellPort
    {
        Process CmdProcess = new Process();
        ProcessStartInfo CmdProcessinfo = new ProcessStartInfo();

        public ShellPort()
        {
            CmdProcessinfo.WindowStyle = ProcessWindowStyle.Hidden;
            CmdProcessinfo.UseShellExecute = false;
            CmdProcessinfo.RedirectStandardOutput = true;
            CmdProcessinfo.RedirectStandardInput = true;
            CmdProcessinfo.CreateNoWindow = true;
            CmdProcessinfo.FileName = "netstat";
            CmdProcessinfo.Arguments = "-an -o";
            CmdProcess.StartInfo = CmdProcessinfo;
        }

        public List<string> getAllPortInfo()
        {
            CmdProcess.Start();
          
            //获取端口使用信息
            string strResult = CmdProcess.StandardOutput.ReadToEnd();
            CmdProcess.WaitForExit();

            
            StringReader sr = new StringReader(strResult);

            List<string> lines = new List<string>();
            for(string l = sr.ReadLine();l != null;l=sr.ReadLine())
            {
                if (string.IsNullOrEmpty(l) || l.Split(' ').Length < 5) continue;
                lines.Add(l);
            }
           
            return lines;
        }

        public List<PortInfo> getAllPort()
        {
            List<PortInfo> allports = new List<PortInfo>();
            List<string> ports = getAllPortInfo();
            expandStringToList(ports,allports);
            return allports;
        }

        private void expandStringToList(List<string> source, List<PortInfo> p)
        {
            //记录表头信息
            List<string> listindex = new List<string>();
            foreach (string line in source)
            {
                try
                {
                    if (string.IsNullOrEmpty(line)) continue;
                    //获取第一行表头信息
                    if (listindex.Count <= 0)
                    {
                        if ((!line.ToLower().Contains("proto") && !line.ToLower().Contains("协议")) || !line.ToLower().Contains("pid")) continue;
                        string[] strs = line.Split(' ');
                        foreach (string str in strs)
                        {
                            if (string.IsNullOrEmpty(str) || str.ToLower().Trim()=="address" || listindex.Contains(str)) continue;
                            listindex.Add(str);
                        }
                    }
                    else
                    {
                        PortInfo pi = new PortInfo();
                        string[] infos = line.Split(' ');
                        int index = 0;
                        foreach (string v in infos)
                        {
                            if (string.IsNullOrEmpty(v)) continue;
                            string key = listindex[index];
                         
                            if (key.ToLower().Contains("proto") || key.ToLower().Contains("协议"))
                            {
                                pi.Proto = v;
                            }
                            else if (key.ToLower().Contains("pid"))
                            {
                                pi.PID = v;
                                pi.BindProcess = getProcessByPID(v);
                            }
                            else if (key.ToLower().Contains("local") || key.ToLower().Contains("本地地址"))
                            {
                                string[] vs = v.Split(':');
                                pi.Local_Address = vs[0];
                                pi.Port = int.Parse(vs[1]);
                            }
                            else if (key.ToLower().Contains("foreign") || key.ToLower().Contains("外部地址"))
                            {
                                pi.Foreign_Address = v;
                            }
                            else if (key.ToLower().Contains("state") || key.ToLower().Contains("状态"))
                            {
                                int ptmp = 0;
                                if (int.TryParse(v, out ptmp))
                                {
                                    pi.PID = v;
                                    pi.BindProcess = getProcessByPID(v);
                                }
                                else
                                {
                                    pi.State = v;
                                }
                            }
                            index++;
                        }

                        p.Add(pi);
                    }
                }
                catch
                { }
                
            }

        }

        public Process getProcessByPID(string pid)
        {
           return Process.GetProcessById(int.Parse(pid));
        }
    }
}
