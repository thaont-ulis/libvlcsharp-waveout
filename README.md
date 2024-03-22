# libvlcsharp-waveout
 Crash error in VLC library with audio output as WaveOut.

# Bug description
On some PCs using Nvidia cards, when I try to play Play Video and then Pause the video and audio output is "WaveOut", the program crashes.

## Summary of conditions leading to crash

 - PC with Nvidia card
 - Lib VLC
    + VideoLAN.LibVLC.Windows (https://www.nuget.org/packages/VideoLAN.LibVLC.Windows)
    + LibVLCSharp (https://www.nuget.org/packages/LibVLCSharp/)
 - Setting audio output: WaveOut

    ![alt text](https://github.com/thaont-ulis/libvlcsharp-waveout/tree/main/images/Setting_WaveOut.png)


## Sample demo crashes

 - Add videos to the textbox (add at least 2 videos)
   ![alt text](https://github.com/thaont-ulis/libvlcsharp-waveout/tree/main/images/Add_Videos.png)
 - Select the output sound as WaveOut and continuously perform LOAD, LOAD, LOAD, etc...
   ![alt text](https://github.com/thaont-ulis/libvlcsharp-waveout/tree/main/images/Run_WaveOut.png)
 - After a few clicks on the LOAD button, the program crashes. The crash location is in the library: libwaveout_plugin.dll
   ![alt text](https://github.com/thaont-ulis/libvlcsharp-waveout/tree/main/images/Run_Crash.png)


## In case there is no crash

 - Select the output sound as Automatic and continuously perform LOAD, LOAD, LOAD, etc...
   ![alt text](https://github.com/thaont-ulis/libvlcsharp-waveout/tree/main/images/Run_Automatic.png)

# Conclude
## I firmly believe this is a bug in the VLC library with the audio output being WaveOut. I tested on multiple PCs with Nvidia cards and the results were similar.