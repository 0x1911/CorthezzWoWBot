using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace BotTemplate.Helper
{
    public static class MachineInfo
    {
        public static Version GetAssemblyVersion()
        {
            Version versionString = Assembly.GetEntryAssembly().GetName().Version;
            return versionString;
        }


        /// <summary>
        /// Return machine current uptime in seconds
        /// </summary>
        /// <returns>427809</returns>
        public static TimeSpan GetSystemUpTime()
        {
            var ticks = Stopwatch.GetTimestamp();
            var uptime = ((double)ticks) / Stopwatch.Frequency;
            var uptimeSpan = TimeSpan.FromSeconds(uptime);

            return uptimeSpan;
        }

        /// <summary>
        /// Returns a human readable time string
        /// </summary>
        /// <returns>01d, 12h, 30m, 26s</returns>
        public static string GetSystemUpTimeString()
        {
            TimeSpan t = TimeSpan.FromSeconds(GetSystemUpTime().TotalSeconds);

            string answer = string.Format("{0:D2}d, {1:D2}h, {2:D2}m, {3:D2}s",
                            t.Days,
                            t.Hours,
                            t.Minutes,
                            t.Seconds);

            return answer;
        }

        #region get machine RAM/memory info
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);
        // use to get memory available
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;

            public MEMORYSTATUSEX()
            {
                this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            }
        }

        /// <summary>
        /// Return the total amount of memory on the machine in Mb
        /// </summary>
        /// <returns>example 1024</returns>
        public static ulong GetTotalMemory()
        {
            MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
            if (GlobalMemoryStatusEx(memStatus))
            {
                return (memStatus.ullTotalPhys / (1024 * 1024));
            }

            return 1; //something went wrong..
        }

        /// <summary>
        /// Return the available amount of memory on the machine in Mb
        /// </summary>
        /// <returns>exampe 515</returns>
        public static ulong GetAvailableMemory()
        {
            MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
            if (GlobalMemoryStatusEx(memStatus))
            {
                return (memStatus.ullAvailPhys / (1024 * 1024));
            }

            return 1; //something went wrong..
        }
        #endregion
    }
}