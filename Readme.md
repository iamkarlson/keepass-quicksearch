#QuickSearch

original version: [profon.wordpress.com](http://profon.wordpress.com/quicksearch/)

QuickSearch is a search plugin for KeePass Password Safe v2 [KeePass.info](http://www.KeePass.info) . It can be used
as a replacement for the built-in QuickFind toolbar control.

##Development

To start developing the pluging, you should place KeePass sources at directory at one level with project. For instance, you have following structure __p:\projects\QuickSearch__, KeePass must be placed in __projects__ folder.


##Installation

Place __QuickSearch.plgx__ in your KeePass Plugins folder.


##Uninstallation

Delete __QuickSearch.plgx__ from your KeePass Plugins folder.

##Changelog
v2.27 - v2.28
Added automatic check for updates

v2.26
CTRL+SHIFT+F - activate search textbox
Knownig issue - doesn't work at linux

v2.17
updated: changed code to support KeePass 2.17

v2.13 b0.0.0.2
fixed: QuickSearch.config will now be saved in application directory if PreferUserConfiguration==false.
added: different mouse cursor for ColorSelectButton

v0.3
 * Settings system changed: QuickSearch.config is no longer used and settings are now stored in the
    KeePass config file
 * Changed redistributable to plgx instead of dll
 * Compatible with KeePass 2.28 (and probably earlier versions, but untested)
