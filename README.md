L-SMASH Muxer GUI 2
===========================

[中文文档](https://github.com/amefs/lsmash-muxer-gui/blob/RC_2_x/README_zh.md)

L-SMASH Muxer GUI 2 is a graphic interface for L-SMASH Muxer/Remuxer, It can support muxing/remuxing of video, audio and chapter.

## Table of Contents
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Famefs%2Flsmash-muxer-gui.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Famefs%2Flsmash-muxer-gui?ref=badge_shield)

- [L-SMASH Muxer GUI 2](#l-smash-muxer-gui-2)
  - [Table of Contents](#table-of-contents)
  - [Introduction of GUI](#introduction-of-gui)
    - [Video](#video)
    - [Audio](#audio)
    - [Chapter](#chapter)
    - [timecode](#timecode)
    - [Output](#output)
    - [Logs](#logs)
    - [Status](#status)
  - [FAQ](#faq)
  - [Tips](#tips)

## Introduction of GUI

This Gui contents Video, Audio, Chapter, timecode, Output, Logs. You can input videos, audios, chapters and timecode file. You can click `...` to brower file or simply drag the file to the textbox.

### Video

+ **Video Input**, video file. Support ***264, h264, avc, 265, hevc, mp4, vc1***, Case insensitive.

+ **FPS**, the Framerate of video(CRF), add autodetect function since v1.2. If auto detection is incorrect, it can be specified in the drop-down menu.

+ **Name**, the alias of video track

+ **PAR**, PAR(pixel aspect ratio) of video, it was added since 1.4beta.

### Audio

+ **Audio Input**, audio file. Support ***aac, amr, ac3, eac3, dts m4a, mp3, mp4*** Case insensitive.

+ **Language**, Language code of audio track, the Language code can be select from drop-down menu.

+ **Name**, the alias of audio track

+ **Encoder Delay**, audio track delay(priming samples, only positive integers are allowed), see [this](https://developer.apple.com/library/archive/documentation/QuickTime/QTFF/QTFFAppenG/QTFFAppenG.html) description.

### Chapter

+ **Chapters File**, chapter file, support ***txt***. The chapter file looks like this

```
CHAPTER01=00:00:00.000
CHAPTER01NAME=Chapter 01
CHAPTER02=00:03:23.036
CHAPTER02NAME=Chapter 02
CHAPTER03=00:04:53.043
CHAPTER03NAME=Chapter 03
CHAPTER04=00:14:24.030
CHAPTER04NAME=Chapter 04
CHAPTER05=00:22:28.055
CHAPTER05NAME=Chapter 05
CHAPTER06=00:23:58.062
CHAPTER06NAME=Chapter 06
CHAPTER07=00:24:29.093
CHAPTER07NAME=Chapter 07

```
### timecode

+ **timecode File**, timecode file，support ***txt***. Used to create vfr clip.

### Output

+ **Muxed Output**, output path. If the video path exist, it will be automatic set to `[video file name]_Muxed.mp4`. You will not be able to mux without this path.

### Logs

+ Redirect messages of l-smash cli.

### Status

+ Processbar add in version v2.1a

## FAQ

+	Q:What kind of the file can be used to mux?

	A:This GUI support muxing with RAW video + RAW audio, RAW video + MP4 audio, MP4 video + RAW audio, MP4 video + audio.
	
+	Q:Why l-smash is slower than mp4box?

	A:l-smash will analyse the input file before muxing, it takes more time. Only remuxing will much faster.
	
+	Q:why not support more input format

	A:This GUI is basically designed for most common file format in VCB-S workflow. For more format, please use the command line directly.

+	Q:how to use timecode?

	A:load your video file and timecode, or add timecode during muxing, the timecode will be fixed according to the tc file in the final output.

## Tips

+ 1.Since all file identification is based on extension, **DO NOT** confuse the GUI with wrong file name, or the software could crash.

+ 2.`X` in the GUI will clean track alias, `Clear` button clean all input.

+ 3.Since the GUI is still under development, there may still be a lot of bugs, please understand.

---

Finally, everyone is welcome to help me improve this GUI.

thanks [Kice](https://github.com/kice) for provide WPF framemwork



## License
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Famefs%2Flsmash-muxer-gui.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Famefs%2Flsmash-muxer-gui?ref=badge_large)