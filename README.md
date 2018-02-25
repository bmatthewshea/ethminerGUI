ethminerGUI - Graphical User Interface for "ethminer" (Windows)
==================

[![Build status][appveyor-icon]][appveyor-link]
[![Build Status][travis-icon]][travis-link]

<!-- [![Slack Status][slack-icon]][slack-link] -->

  - [Installation](#installation)
  - [Features](#features)
  - [TO DO](#to-do)
  - [License](#license)


## Installation

- The EXE can be placed anywhere. Optionally, you can place it with the exe.config and your custom settings.
- The 'profiles.xml' holds the profiles you have created. This can be copied to other machines.
- %appdata%\ethminerGUI\user.config should only created if you "save settings on exit".
- Note: the free 'win tee' (wtee.exe) is required to use the log feature. [(Google archive/source here)](https://code.google.com/archive/p/wintee/downloads)
- Ethminer needs a newer release that support newer flags. [Release Version "0.13.0"](https://github.com/ethereum-mining/ethminer/releases) works well for this.

## Features

- Covers most of the basic options for ethminer
- Allows to save all your pools as profiles (profiles.xml)
- No need for multiple cmd/batch files laying around
- 'profiles.xml' can also be moved to other machines to share the profiles

## TO-DO

- Fix Save/Remove/Add profiles to use the deserializer/serializer using obj in memory (works now but uses XmlDoc)
- Add "modify profile" to code. Right now you can delete and re-add (only).
- Fix the 'Stop Mining' button to interact with the Process() and actually kill miner (Use CTRL-C on console for now)
- basic code clean up/streamlining - this is a 'first draft' and is a mess (though works) -> you were warned.


     Contact: https://discord.gg/MFzuyNs


## License

ethminerGUI is released under the [GNU GPLv3](https://opensource.org/licenses/GPL-3.0).
ethminer is released under the [GNU GPLv3](https://opensource.org/licenses/GPL-3.0).
wintee/wtee.exe is released under the [Mozilla] https://www.mozilla.org/en-US/MPL/).

<!-- <p><img src="http://i.imgur.com/u1G0wvD.png" width="475"></p> -->

<p><img src="https://assets-cdn.github.com/images/modules/logos_page/Octocat.png" width="175"></p>

[appveyor-icon]: https://ci.appveyor.com/api/projects/status/

[appveyor-link]: https://ci.appveyor.com/project/bmatthewshea/ethminerGUI

[travis-icon]: https://travis-ci.org/bmatthewshea/ethminerGUI.svg?branch=master

[travis-link]: https://travis-ci.org/bmatthewshea/ethminerGUI
