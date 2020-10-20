# YouAreAnIdiotCS
A C# remake of the youareanidiot trojan
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
I am not responisble if something happens to your PC while executing this.
I can help you fix it though
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
This malware will disable task manager and if it is in your downloads folder it will move it to startup
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
Fix on Windows 10 Pro
Press Windows + R and the run box will open. In the run box type "shell:startup" and enter. verify that YouAreAnIdiot.exe is not in there then restart.
Once your computer is done restarting press Windows + R in the run box type "Gpedit.msc" and enter. 
Once in the Local Group Policy Editor go to "User Configuration" -> "Administrative Templates" -> "System" -> "Ctrl+Alt+Del Options"
On the right side of the screen double click "Remove Task Manager" and verify that it is set to "Disable" or "Not Configured".
Once you've done that close the editor and press Windows + R and in the run box type "gpupdate /force" and press enter. after that task manager should be reenabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
Fix on Windows 10 Home
Press Windows + R and the run box will open. In the run box type "shell:startup" and enter. verify that YouAreAnIdiot.exe is not in there then restart.
Once your computer is done restarting press Windows + R in the run box type "regedit" and enter. Then it will ask for administrator privileges click "Yes".
Once in the Registry Editor go to HKEY_CURRENT_USER -> Software -> Microsoft -> Windows -> CurrentVersion -> Policies -> System
Once in there on the right side of your screen if you see DisableTaskMgr right click and delete it
If you still have a problem there is a more detailed guide here https://www.wikihow.com/Enable-Task-Manager-in-Windows#:~:text=Opening%20the%20Task%20Manager,-%7B%22smallUrl%22%3A&text=Press%20Ctrl%20%2B%20Alt%20%2B%20Del%20on,pressing%20Ctrl%20%2B%20Alt%20%2B%20Esc%20.
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
Alternatively, you can scan your PC with AdwCleaner this didn't work for me on Windows 10 Home though.
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
Always remember to be careful when testing malware. This remake of youareanidiot will not cause any permanant harm to your PC unless for some reason you cant enable task manager
