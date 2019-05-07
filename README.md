<h1 align="center">
	<br>
	<img src="https://raw.githubusercontent.com/ProHackTech/Prohack-Security-Lite/master/logo.png" alt="ProHack-Security-Lite Logo">
	<br>
	Prohack Security Lite
</h1>

<h3 align="center">Under Development</h3>

This is a small anti-malware application made in VB.NET. All the hashes are collected from <a href="https://virusshare.com/">Virus Share Website</a>. Currently under development.

## Test It Out

### Requirements

- .NET Framework 4.7.2
- Visual Studio (for source view/testing)
- Python 3x

### For Newbs

> 1. Clone or Download

> 2. Goto: *Prohack-Security-Lite\ProHack Security Lite\bin\Debug* (bin\Debug folder)

> 3. Create empty file named: "FIRST_TIME" (without quotes and extension) - This is to auto start the easy installer for dependencies

> 4. Run: ProHack Security Lite.exe

### For Non-Noobs
Non-Newbs will have Visual Studio, .NET Framework 4.7.2 installed and Python 3x installed. Follow the steps for newbs leaving out the 3rd part.

## Features

### Planned

- Quick Scan           [ Done > Improving ]
- Deep Scan            [ Done > Improving ]
- Custom Scan          [ Done > Completed ]
- Python support       [  Partially Done  ]
- Real Time Scan       [     To Start     ]
- MalwareDB Update     [     To Start     ]
- WebUtils             [     To Start     ]
- Tools                [     To Start     ]


### Completed Features

The following features have been completed. They may need further improvements.

#### Quick Scan

- [+] Gather files based on 100+ common file extensions
- [+] Queriy *Windows Search Indexer* for file list
- [+] Gather MD5 file signature for each file in query results
- [+] Compare with malware signatures

#### Deep Scan

- [+] Gather system file list using Python
- [+] Scan against malware signatures

#### Custom Scan
Choose file(s) and scan. Very simple and no extra features (becuase this is LITE version)

- [+] Choose file(s)
- [+] Scan againt malware signatures

#### Scheduled Indexer Query

- [+] Automatic background *Windows Search Indexer* querying every minute
- [+] Added error management incase a scan is currently taking place

#### Error Reporting & Message

Default messagebox was lacking needed features, so a quick custom form was made for displaying message and errors.

- [+] Generate small report for emailing: To minimize data collection scope, automatic reporting may not planned..
- [+] Refresh application: Starts the updater to download the application again (to be used incase critical application error or files missing/deleted by mistake).

### To-Do

- Webutils, Tools
- Malware Signatures updater
- Create powershell support scripts (last priority)
- Create gui python package installer (last priority)

### FIFO Order

#### Priority Levels

(1) = Urgent
(2) = To complete after urgent tasks
(3) = Not urgent, but last to do in the FIFO list

Items in this section are to be made/fixed before doing anything else, hence *<b>F</b>irst<b>I</b>n<b>F</b>irst<b>O</b>ut* order of development:

- Malware signature updater (1) [core]
- Scheduler for malware signature updater (1) [core]
- Common scan engine for 'VirusShare-DB' and 'ClamAV-DB' support (2) [core]
- Fix python file lister script (3) [bug]
- Let starter.bat start the .NET 4.7.2 installer on first time use, then open Easy Installer (3) [bug]

Once the current to-do items are completed, the project will begin release cycles with version controls starting from v1.0.0.0 for both application and updater. Different branches will be created for each sub-project development.

## License

```

MIT License

Copyright (c) 2019 prohack.tech

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

```

## Contribute

### Code Contributions

#### Direct contributions

> Fork the repository

> Git Clone: *https://github.com/YOUR_GITHUB/Prohack-Security-Lite.git*

> Make Improvements, Fix Bugs, Add Features, Add utilities

> Push changes to your forked repository

> Send a pull request to main project

#### Suggest code changes

> Goto: [Issues](https://github.com/ProHackTech/Prohack-Security-Lite/issues) and create a new issue.


### Reports/Suggestions/Bugs
To submit bug reports/suggestions and other help, goto: [Issues](https://github.com/ProHackTech/Prohack-Security-Lite/issues) and create a new issue.