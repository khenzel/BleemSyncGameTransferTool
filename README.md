# BleemSyncGameTransferTool
Transfers games from source to USB to support BleemSync folder structure (Built on BleemSync4.1 requirements)

Usage instructions:
1. Follow one of the many tutorials available to set up BleemSync on your USB device to be used on your playstaion classic system.

2.Set your SOURCE PATH-
Folder containing game folders you wish to transfer to your USB drive. 
Folder contents should be: Game.ini, pcsx.cfg, <DISC SERIAL#>.bin + cue + png (image) files. 
Multible Bin files are not supported at this time. Use an application like IsoBuster to merge multiple bin files to one (which generates a new CUE file). There are guides out there to instruct you on how this is done.

3.Set your DESTINATION PATH-
This MUST be the game folder in the ROOT of your USB device you wish to use with your playstation classic (the one you set up in step 1 above). This folder should be EMPTY, containing no folders/files.
Should you have games left over from the previous transfer, those folders will be skipped (not overwritten)

4.Press GO!. This will begin the transfer:
Transfer process: Runs a folder scan from the Source path and gathers a list of game folders. It alphabetizes them using array.sort, and runs through them one by one:
-creates a folder on the destination path : #\GameData\ where # represents an iterated folder number that automatically increases with each subsequent game folder transfer
-copies the contents of the game folder from SOURCE to DESTINATION\game\#\GameData
If DESTINATION\game\#\GameData already exists, it skipps and moves ot the next SOURCE folder (effectively skipping that game. If the path DESTINATION\game\#\GameData contained Tekken3 for example, and the source folder to be copied to that # slot is Tenchu, it only cares about that current game iteration, so it will be SKIPPED. This is why you want a cleared out Game folder)

All games will be transferred, and notification will be given upon transfer completion.
