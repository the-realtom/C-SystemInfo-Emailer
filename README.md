# C-SystemInfo-Emailer
This program relies on the EASendMail SMTP components available here :
https://www.emailarchitect.net/webapp/download/easendmail.exe

Depnding on the .Net Framework build you would like to support you need to include the following .dll as a reference.

EASendMail.dll - Built with .NET Framework 1.1. It requires .NET Framework 1.1, 2.0, 3.5 or later version.<br />
EASendMail20.dll - Built with .NET Framework 2.0. It requires .NET Framework 2.0, 3.5 or later version.<br />
EASendMail35.dll - Built with .NET Framework 3.5. It requires .NET Framework 3.5 or later version.<br />
EASendMaill40.dll - Built with .NET Framework 4.0. It requires .NET Framework 4.0 or later version.<br />
EASendMaill45.dll - Built with .NET Framework 4.5. It requires .NET Framework 4.5 or later version.<br />
EASendMailCF20.dll - Built with .NET Compact Framework 2.0. It requires .NET Compact Framework 2.0, 3.5 or later version.<br />
EASendMailCF35.dll - Built with .NET Compact Framework 3.5. It requires .NET Compact Framework 3.5 or later version.<br />

I would recommend using the Visual Stuido extension NuGet to install Costura.Fody through the package manager. 
This is for embedding references as resources allowing the program to work on any computer without the EASendMail SMTP components.
