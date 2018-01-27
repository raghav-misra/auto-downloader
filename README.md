# *Splix Auto Downloader*
Auto downloader/updater for C#/VB.NET Windows Forms Applications
___
## Prerequisites:
* An online file host that can create direct links
  * Website builders often do the trick
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
## The Code Version - C#:
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
* DownloadFileName is the name of the file that will be downloaded.
___
## The Code - VB.NET:
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
* DownloadFileName is the name of the file that will be downloaded.
___
## Using the Button Control:
1. Drag the DownloadButton into the toolbox: <br/>
![alt text](https://cdn.discordapp.com/attachments/277558215506526209/406641916260909068/unknown.png "Drag Button Onto Form")
2. Set the Button Properties: <br/>
![alt text](https://cdn.discordapp.com/attachments/277558215506526209/406639950826700822/unknown.png "Set Properties")


