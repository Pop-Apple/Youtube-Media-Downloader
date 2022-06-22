## How to use [Youtube-Media-Downloader](https://github.com/Pop-Apple/Youtube-Media-Downloader) 🔗

* 1 Enter the Youtube URL in the address
* 2 Select whether Format is (.mp3) or (.mp4).
* 3 Specify the save destination
* Click the 4 button to start the download.

## Build 🏢

[MediaToolKit] and [VideoLibrary] from NugetPackage

Please install

## MenuStrip 🤖

You can save and open the URL as a file * .yturl

It is a function that I added as a trial

Easily go to [Google](https://www.google.com/) & [YouTube](https://www.youtube.com/) using Process.Start as an auxiliary feature

Can be accessed

![0173](https://user-images.githubusercontent.com/101918076/173852565-f095169d-4ef6-4ebd-a71a-6b9654d295ee.jpg)

## Purpose 🚗

You can save videos quickly and easily without having to record Youtube videos

Also, by sending videos to iphone and Android, you can view videos without consuming giga (?).

You can download the tool from [here](https://github.com/Pop-Apple/Youtube-Media-Downloader/releases/tag/v1.0.0.1)

## Example Codes ✔
````csharp
 var youTube = YouTube.Default;
            var video = youTube.GetVideo(txtyoutube.Text.Trim());
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = video.FullName;
 
            try
            {
                System.IO.File.WriteAllBytes(path + sfd.FileName, video.GetBytes());
                logoutput.Info(sfd.FileName);
                MessageBox.Show("Downloaded Successfully", "App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                logoutput.Error(ex, ex.Message);
            }
````

## License & Reference 🌺

* [Example Codes](https://www.engineer-walk.com/programming/videolibrary-youtube-csharp/)
* [Video Library](https://www.nuget.org/packages/VideoLibrary/)
* [Media Tool kit](https://www.nuget.org/packages/MediaToolkit/)

* Visual Studio 2022
* Visual Studio Code
* .NET Framework
