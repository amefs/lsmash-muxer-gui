L-SMASH Muxer GUI 2
===========================

L-SMASH Muxer GUI 2 是一个为L-SMASH Muxer/Remuxer封装工具适配的图形化操作界面, 现在支持视频、音频、章节文件的封装, 同时可以设定视频轨的帧率, 音频轨的语言等参数。

## 目录
- [目录](#目录)
- [界面简介](#界面简介)
	- [Video](#video)
	- [Audio](#audio)
	- [Chapter](#chapter)
	- [timecode](#timecode)
	- [Output](#output)
	- [Logs](#logs)
- [FAQ](#faq)
- [Tips](#tips)
	
## 界面简介

GUI的界面主要分为Video、Audio、Chapter、timecode、Output、Logs部分。分别提供视频、音频、章节、时间码文件的输入, 输出文件目录选择以及状态显示。视频、音频以及章节文件目录既可以点击 `...` 选择, 也可以使用拖拽功能。

### Video

+ **Video Input**, Video文件输入。输入支持 ***264, h264, avc, 265, hevc, mp4*** 后缀, 不区分大小写。

+ **FPS**, Video的帧率设定(CRF)。在1.2版本中加入了自动帧率识别。如果无法正常显示帧率, 或者需要手动指定, 那么可以在下拉菜单中指定。

+ **Name**, Video轨道的别名。

+ **PAR**, Video的PAR参数(pixel aspect ratio), PAR的参数可选, 留空则不改变。此功能在1.4beta版中加入。

### Audio

+ **Audio Input**, Audio文件输入。输入支持 ***aac, m4a, mp3, mp4*** 后缀, 不区分大小写。

+ **Language**, Audio语言。可以在下拉菜单中选择。

+ **Name**, Audio轨道别名。

+ **Delay**, 音频轨道的延迟长度。单位为ms

### Chapter

+ **Chapters File**, 章节文件, 默认 ***txt*** 后缀输入, 章节文件示例如下：

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

+ **timecode File**, 时间码文件，默认 ***txt*** 后缀输入，可以依据此文件制作vfr视频

### Output

+ **Muxed Output**, 选择输出位置。当视频轨被正确指定时, 此处output会默认在同文件夹中生成`[视屏轨文件名]_Muxed.mp4`否则需要手动指定。若不指定输出文件位置则无法继续混流。

### Logs

+ 现在仅有 `Processing...` 和 `Finished` 两种状态显示。

## FAQ

+	Q:GUI可以提供哪几种混流方案？

	A:GUI可以为RAW视频+RAW音频, RAW视频+MP4音频，MP4视频+RAW音频, MP4视频+MP4音频提供混流。
	
+	Q:为什么感觉l-smash混流比mp4box更慢？

	A:l-smash在混流RAW视频轨的情况下会首先分析轨道信息, 因此相比GPAC(mp4box)会更慢。如果混流两个MP4文件则速度会快很多。
	
+	Q:为什么GUI不提供更多格式的混流支持？

	A:由于软件最早设计是参照VCB-S常用规格, 因此只添加了一些比较常用的混流格式, 更多的格式支持请直接使用命令行。

+	Q:timecode如何使用？

	A:载入需要进行timecode修修复的视频与timecode文件，或者在正常的混流操作中加上timecode，则在最终输出时会根据timecode文件对视频进行修复。

## Tips

+ 1.由于所有的文件识别都基于文件后缀, 请不要故意使用错误的文件名混淆GUI, 这将可能引起软件崩溃。

+ 2.GUI中出现的`X`按钮功能为清除当前区块已填写的信息, `Clear`为清除所有区块已填写的信息。

+ 3.由于GUI尚在开发, 仍可能存在大量bug, 请耐心对待。

---

最后欢迎各位dalao继续帮助我改进此GUI。

感谢[Kice](https://github.com/kice)提供WPF界面框架

