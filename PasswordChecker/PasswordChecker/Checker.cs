using System;
using System.Text;
using System.Runtime.InteropServices;

namespace PasswordChecker
{
    class Checker
    {
        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

        public static byte[] ReadBytes(IntPtr Handle, Int64 Address, uint BytesToRead)
        {
            IntPtr ptrBytesRead;
            byte[] buffer = new byte[BytesToRead];
            ReadProcessMemory(Handle, new IntPtr(Address), buffer, BytesToRead, out ptrBytesRead);
            return buffer;
        }

        public static string ReadString(Int64 Address, IntPtr Handle)
        {
            byte[] bytes = ReadBytes(Handle, Address, 16);
            string s = Encoding.ASCII.GetString(bytes);
            return s.Replace("-", "");
        }

        public string ReadString(long Address, IntPtr Handle, uint length = 32)
        {
            return ASCIIEncoding.Default.GetString(ReadBytes(Handle, Address, length)).Split('\0')[0];
        }

        public string findPassword(UInt32 Base, IntPtr Handle)
        {
            return ReadString(Base + 0x6D6024, Handle);
        }

        public string findLogin(UInt32 Base, IntPtr Handle)
        {
            return ReadString(Base + 0x6D600C, Handle);
        }
    }
}
