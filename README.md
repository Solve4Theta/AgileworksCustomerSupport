# Simple Customer Support MVC Web Application

The application enables the user to submit customer support requests and their respective deadlines. Additionally the user can view all submitted requests and mark them as "done", which will remove the request from the submitted requests. If the deadline for a request has passed, or it is in less than an hour, the request will be displayed in red color.

To run this project, it is necessary to have a suitable .NET SDK installed depending on your OS. Additionally, JetBrains Rider or MS Visual Studio are good IDE-s for running the project.

## Installing the .NET SDK

### Mac

Easiest way is to use Homebrew:
~~~
brew install --cask dotnet-sdk
dotnet --version
~~~

Alternative is through browser and GUI:

1. **Download the .NET SDK Installer:**
   - Go to the [.NET download page](https://dotnet.microsoft.com/download).
   - Choose the latest .NET SDK version.
   - Download the .NET SDK installer for macOS (typically a `.pkg` file).

2. **Install the SDK:**
   - Double-click the `.pkg` file to start the installation.
   - Follow the on-screen instructions to complete the installation.

3. **Verify Installation:**
   - Open a Terminal window and run:
     ```
     dotnet --version
     ```
   - This command should output the version of the .NET SDK that you installed.

### Linux

Here I will include the commands for Ubuntu. For other distributions, please visit the [.NET download page](https://dotnet.microsoft.com/download) and select your distribution for specific instructions.

1. **Install the .NET SDK:**
   - Open a Terminal window.
   - Update your packages:
     ```
     sudo apt-get update
     ```
   - Install the .NET SDK:
     ```
     sudo apt-get install -y dotnet-sdk-5.0
     ```
     Replace `5.0` with the version number you wish to install.

2. **Verify Installation:**
   - In the Terminal, run:
     ```
     dotnet --version
     ```
   - This should display the installed .NET SDK version.

### Windows

1. **Download the .NET SDK Installer:**
   - Navigate to the [.NET download page](https://dotnet.microsoft.com/download).
   - Select the latest .NET SDK version.
   - Download the .NET SDK installer for Windows (typically `.exe` file).

2. **Run the Installer:**
   - Double-click the downloaded `.exe` file to start the installation.
   - Follow the installer prompts to complete the installation.

3. **Verify Installation:**
   - Open a Command Prompt and run the following command:
     ```
     dotnet --version
     ```
   - This should display the installed .NET SDK version.


## Support

If you encounter any issues during the installation process, you can visit the [.NET documentation](https://docs.microsoft.com/en-us/dotnet/) for troubleshooting tips or reach out to the community forums for help.

