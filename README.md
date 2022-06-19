## How to use [Youtube-Media-Downloader](https://github.com/Pop-Apple/Youtube-Media-Downloader)🔊

* 1 アドレスにYoutubeのURLを記入します
* 2 Formatを(.mp3)か(.mp4)か選択します
* 3 保存先を指定します
* 4 ボタンをクリックするとダウンロードが開始されます

## MenuStrip🙄
URLをファイル *.yturl として保存し開くことがができます

試しに追加してみた機能です

補助機能として Process.Start を使用して簡単に[Google](https://www.google.com/) & [YouTube](https://www.youtube.com/)に

アクセスすることができます

![0173](https://user-images.githubusercontent.com/101918076/173852565-f095169d-4ef6-4ebd-a71a-6b9654d295ee.jpg)

## Purpose 🚗

Youtubeの動画を録画する必要がなく速くかつ簡単に動画を保存することができます

また、iphone , Android に動画を送ることでギガを消費せず動画の閲覧が可能になります(?)

## Screenshots 🎨
![Main App 2](https://user-images.githubusercontent.com/101918076/173849837-3bd48277-ff6d-4fce-9d5f-5e6a9dee65dc.jpg)

[ここ]()からツールをダウンロードできます

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
