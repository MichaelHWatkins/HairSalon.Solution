# _Eau Claire's Salon_

#### By _**{Mike Watkins}**_

#### _{An app that records Stylists and their Clients.}_

## Technologies Used

* _GitHub repositories_
* _C#_
* _.Net 5_
* _NuGet_
* _MySql_



## Description

_{Tells you which clients which stylists cover.}_

## Setup/Installation Requirements

* _Install .NET Framework_
* _Navigate to https://github.com/MichaelHWatkins/HairSalon.Solution_
* _Click on the green "Code" button and copy the repository URL or click on the copy button_
* _Open the terminal on your desktop_
* _Once in the terminal, use it to navigate to your desktop folder_
* _Once inside your desktop folder, use the command "git clone https://github.com/MichaelHWatkins/HairSalon.Solution"_
* _After cloning the project, navigate into it using the command "cd HairSalon.Solution"_
* _Use the command "git remote -v" to confirm the creation of the new local repository_
* _Open the project with the code editor of your choice_
* _Navigate to HairSalon directory and enter command "dotnet restore"_
* _Create a file in production folder called appsettings.json_
* _Add the following to the .json file, {
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
}
}_
* Download MySQL and MySql Workbench to set up a local database
* Once installed, open MySql Workbench and open a local server
* In the Navigator, select the Administration tab and then select Data Import/Restore
* Under Import Options, select Import From Self-Contained File, and then select the "michael_watkins.sql" file which can be found in the HairSalon.Solution
* In the Default Schema to be imported to option, select new
* Enter a name for your database and select OK
* Click Start Import to begin database import
* _In HairSalon directory enter command "dotnet run"_

_Note: when using the commands listed above, do not include the quotation marks. They are used here for readability._

## Known Bugs

* _No known bugs_

## Contact Information
__

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Michael Watkins_