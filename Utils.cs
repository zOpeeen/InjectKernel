using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Divy
{
    public class Utils
    {

    }

    class IHandle : Utils
    {
        public int NUM;
        public int PID;
        public string IDN;
    }

    class IProcUtils : Utils
    {
        public static UIntPtr GetProcess_ByName(IHandle g_pHandle)
        {
            Process[] m_pProcs = Process.GetProcesses();

            foreach (Process m_pCurProcs in m_pProcs)
            {
                if (m_pCurProcs.ProcessName == g_pHandle.IDN)
                {
                    g_pHandle.PID = m_pCurProcs.Id;
                    return (UIntPtr)m_pCurProcs.Id;
                }
            }

            return UIntPtr.Zero;
        }
    }
}
