using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace 查看本机端口使用工具
{
    public class PortInfo
    {
        string _PID;

        public string PID
        {
            get { return _PID; }
            set { _PID = value; }
        }

        Process _Process;

        public Process BindProcess
        {
            get { return _Process; }
            set { _Process = value; }
        }

        string _Proto;

        public string Proto
        {
            get { return _Proto; }
            set { _Proto = value; }
        }

        string _Local_Address;

        public string Local_Address
        {
            get { return _Local_Address; }
            set { _Local_Address = value; }
        }

        string _Foreign_Address;

        public string Foreign_Address
        {
            get { return _Foreign_Address; }
            set { _Foreign_Address = value; }
        }

        int _Port;

        public int Port
        {
            get { return _Port; }
            set { _Port = value; }
        }
        string _State;

        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
    }
}
