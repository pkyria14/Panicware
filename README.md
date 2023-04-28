# Panicware Suite

This repository contains C# projects that are designed to work together to provide a full shellcode encryption and deployment system. The three projects are:

1. Encryptions - This project provides a simple way to encrypt any code (not just shellcode) using a XOR encryption algorithm and then encode it using base64. The resulting output can be passed to the Shellcodeloader project for deployment.

2. Shellcodeloader - This project provides a set of functions that can be used to deploy encrypted shellcode in memory. It contains functions such as VirtualAlloc, Marshal.Copy, and Marshal.GetDelegateForFunctionPointer to decrypt and allocate the encrypted code in memory and then execute it.

3. PanicDrop - This project is a reflective loader that can load an assembly from a base64 encoded, XOR-encrypted file via a remote URL. It is designed to be a dropper for payloads.

## Encryptions
The Encryptions project provides a simple way to encrypt any code (not just shellcode) using a XOR encryption algorithm and then encode it using base64. The resulting output can be passed to the Shellcodeloader project for deployment.

### How to Use
- Clone the repository and open the Encryptions.sln solution file in Visual Studio.
- Build the solution to generate the executable.
- Run the executable and enter the path to the file you want to encrypt.
- The encrypted and base64 encoded output will be displayed in the console.

## Shellcodeloader
The Shellcodeloader project provides a set of functions that can be used to deploy encrypted shellcode in memory. It contains functions such as VirtualAlloc, Marshal.Copy, and Marshal.GetDelegateForFunctionPointer to decrypt and allocate the encrypted code in memory and then execute it.

### How to Use
- Clone the repository and open the Shellcodeloader.sln solution file in Visual Studio.
- Build the solution to generate the executable.
- Run the executable and provide the encrypted and base64 encoded shellcode output from the Encryptions project.
- The shellcode will be decrypted and allocated in memory and then executed.

## PanicDrop
The PanicDrop project is a reflective loader that can load an assembly from a base64 encoded, XOR-encrypted file via a remote URL. It is designed to be a dropper for payloads.

### How to Use
- Clone the repository and open the PanicDrop.sln solution file in Visual Studio.
- Build the solution to generate the executable.
- Run the executable and provide the URL of the encrypted and base64 encoded file to load.
- The encrypted file will be downloaded, decrypted, and loaded into memory as an assembly.

## ShellcodeloaderGui (Work in progress)
Graphical User Interface for that will wrap the whole process together in a nice neet way that will be fun and easy to use.

### Note
These projects are for educational purposes only and should not be used for any malicious activities.
