## 1. Setup dotnet core sdk on linux
```bash
wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo add-apt-repository universe
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install dotnet-sdk-2.2
```

## 2. Install VS Code
```bash
sudo apt update
sudo apt install software-properties-common apt-transport-https wget
wget -q https://packages.microsoft.com/keys/microsoft.asc -O- | sudo apt-key add -
sudo apt install code
```

## 3. Install C# extension from VS Code marketplace

## Initialising new project
`dotnet new web` or for more options [view documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore21)<br>
open project in vs code<br>
C# extension will prompt you, click yes<br>
To run in debugging mode `Ctrl + F5`<br>
