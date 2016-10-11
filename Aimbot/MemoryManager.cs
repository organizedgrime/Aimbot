using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace MemoryManagerLib
{
    public class MemoryManager
    {
        // Access flags for processes
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }

        // Other used variables
        Process process;
        IntPtr processHandle;

        public MemoryManager(int processID)
        {
            process = Process.GetProcessById(processID);
            processHandle = OpenProcess(ProcessAccessFlags.All, false, process.Id);
        }

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        public byte[] ReadMemory(int address, int processSize, out int bytesRead)
        {
            byte[] buffer = new byte[processSize];
            ReadProcessMemory(processHandle, new IntPtr(address), buffer, processSize, out bytesRead);
            return buffer;
        }

        public void WriteMemory(int address, byte[] processBytes, out int bytesWritten)
        {
            WriteProcessMemory(processHandle, new IntPtr(address), processBytes, processBytes.Length, out bytesWritten);
        }

        // Methods based on the previous that will simplify actually reading the data, ie. read float directly

        /* Simple read */
        public int ReadInt(int MemoryAddress)
        {
            int read;
            byte[] buffer = ReadMemory(MemoryAddress, 4, out read);

            if (read == 0)
                return 0;
            else
                return BitConverter.ToInt32(buffer, 0);
        }

        public float ReadFloat(int MemoryAddress)
        {
            int read;
            byte[] buffer = ReadMemory(MemoryAddress, 4, out read);

            if (read == 0)
                return 0;
            else
                return BitConverter.ToSingle(buffer, 0);
        }

        /* Simple write */
        public Boolean WriteInt(int MemoryAddress, int value)
        {
            int bytesWritten;
            WriteMemory(MemoryAddress, BitConverter.GetBytes(value), out bytesWritten);

            return bytesWritten != 0;
        }

        public Boolean WriteFloat(int MemoryAddress, float value)
        {
            int bytesWritten;
            WriteMemory(MemoryAddress, BitConverter.GetBytes(value), out bytesWritten);

            return bytesWritten != 0;
        }

        // End methods

        public int GetObjectSize(object TestObject)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            byte[] Array;
            bf.Serialize(ms, TestObject);
            Array = ms.ToArray();
            return Array.Length;
        }
    }
}
