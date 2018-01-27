# *Splix Auto Downloader*
Auto downloader/updater for C#/VB.NET Windows Forms Applications
___
## Prerequisites:
* An online file host that can create direct links
  * Website builders often do the trick.
  * *GitHub* works too!
* An empty file (any file format)
* The file you want to download
___
## Setting Up:
1. Host the file you want to download online and copy the direct link.
2. In the empty file you created, type the following:
> (DownloadFileURL): [DIRECT-LINK] <br/>
> (Version): [NEW-VERSION]

In your file, replace [DIRECT-LINK] with the link you copied. <br/>
Then, replace [NEW-VERSION] with the latest version. <br/>
Lastly, host your text file online as well. <br/>
___
## Using The Code Version - C#:
> At The Top:
```csharp
using AutoDownloader;
```
> In your code:
```csharp
AutoUpdate.Update(Uri InfoFileURL, Decimal CurrentVersion, String DownloadFileName);
```
* InfoFileURL is the download link to the text file with all the information about the app.
* CurrentVersion is the version of the current assembly on the computer.
* DownloadFileName is the name of the file that will be downloaded (make sure to add the file type).
___
## Using The Code - VB.NET:
> At The Top:
```vb.net
Imports AutoDownloader
```
> In your code:
```vb.net
AutoUpdate.Update(Uri InfoFileURL, Decimal CurrentVersion, String DownloadFileName)
```
* InfoFileURL is the download link to the text file with all the information about the app.
* CurrentVersion is the version of the current assembly on the computer.
* DownloadFileName is the name of the file that will be downloaded (make sure to add the file type).
___
## Using the Button Control:
1. Drag the DownloadButton into the toolbox: <br/>
![alt text](https://cdn.discordapp.com/attachments/277558215506526209/406641916260909068/unknown.png "Drag Button Onto Form")
2. Set the Button Properties: <br/>
![alt text](https://cdn.discordapp.com/attachments/277558215506526209/406642495015878687/unknown.png "Set Properties")
* Set AssemblyVersion to the current version.
* Set FileInfoURL to the direct link to the text file.
* Set SaveFileName to the name of the final downloaded file (make sure to add the file type).
___
## How to Configure Downloader:
After you make a new version, to configure the auto-downloader, do the following:
1. Create a direct link for the new version of the assembly
2. Replace it with the current one (DownloadFileURL) in the text file
3. Change the version number (Version) on the text file
___
## You're All Set!
