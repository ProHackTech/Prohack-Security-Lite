<h1 align="center">
	<br>
	<img src="https://raw.githubusercontent.com/ProHackTech/Prohack-Security-Lite/master/logo.png" alt="ProHack-Security-Lite Logo">
	<br>
	Prohack Security Lite
</h1>

<h3 align="center">Under Development</h3>

This is a small anti-malware application made in VB.NET. All the hashes are collected from <a href="https://virusshare.com/">Virus Share Website</a>. Currently under development.

## Features

### Planning (Unordered)

- Basic signature based scanning
- Simple web protection: using host file modifying. Blocking IP's
- Task blocker and active task blocker: add tasks to block list and allow force blocking
- Create Quick, Deep & Custom scan options
- Plan WebUtils, Tools
- Create logging
- Add python scripts support
- Add CLI version for non-gui scanning (python)
- Create scalable settings menu, replace current
- Create small GUI python package manager (package list from pypi)
- Add support for ClamAV signature database

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
- Replace 'Easy Install' with better app installer
- Create powershell support scripts (later)
- Create gui python package installer

### FIFO Order

Items in this section are to be made/fixed before doing anything else, hence *<b>F</b>irst<b>I</b>n<b>F</b>irst<b>O</b>ut* order of development:

- WebUtil:Website Blocker (add items to hosts file) (1)
- Tool:File encypter/decrypter (UI = VB | Core = Python) (2)
- Merge scanner code into seperate class for malware_scanner, custom_scanner (3) [optimization]

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

> Make Improvements, Fix Bugs, Add Features

> Push changes to your forked repository

> Send a pull request to main project

#### Suggest code changes

> Goto: [Issues](https://github.com/ProHackTech/Prohack-Security-Lite/issues) and create a new issue.


### Reports/Suggestions/Bugs
To submit bug reports/suggestions and other help, goto: [Issues](https://github.com/ProHackTech/Prohack-Security-Lite/issues) and create a new issue.