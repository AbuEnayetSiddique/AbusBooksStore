2023-03-02
1505
Started Assignment 02 in-class on the lab computer
Set up the ASP.NET MVC w/ core 3.1 
HTTPS enabled, individual account autheutication.. on Razor
Reviewed the Areas folder, Controller, Model and Views.
And..
1505...in startup.cs on the line 33
removed options for default identify
options => options.SignIn.RequireConfirmedAccount = true

1510
Tested the the App.. ran it good...tested links
Action items:
	-Modify the Navigation
	-Update the copyright...from static to dynamic date


1516
Modified the default welcome message...tested.
review the route in Startup.cs

1539
Tried to make Github Repository but did not work
Reboot

1551
The Application ran
The wired thing is got 61 cahanges while commiting to Github

2023-03-03
1516
confirmed the repo is created ... and tested the app

1525
Created the README.md file and pulled that

1626
Modified the welcome page

2023-03-09
1416
pulled project from Github and ran

1425
downloaded Journal theme- bootstrap.css file from bootswatch.com website
added to the wwwroot->lib->bootstrap->dist->css folder
ran the program, nothging changed

1450
modified _Layout.cshtml file
ran the application and changed the outlook.
modified the _LoginPartial.cshtml

2023-03-10
1015
Started working on Adding and Modifing part
ran the application...working

1021
Added three new Projects, named-
	AbusBoos.DataAccess
	AbusBooks.Models
	AbusBooks.Utility

1042
Shift the Data folder to AbusBooks.DataAccess

Installed-
	Microsoft.EntityFrameworkCore.Relational version: 3.1.32
	Microsoft.EntityFrameworkCore.SqlServer version:3.1.32

<<<<<<< HEAD
Deleted the Migration Folder.

Installed Nuget Packege: 
	Identity.EntityFrameworkCore Version: 1.2.7

Modified the namespace in ApplicationDbContext.cs to AbusBookStore.DataAccess.Data
Deleted Startup.cs files from new projects
Moved Model folder to AbusBooks.Moldels folder
Modified ErrorViewModel.cs
Added the Project Reference
Renamed Model folder to ViedModels
Changed the namespace to AbusBookStore.Models.ViewModels
Built the project and got 13 error.
=======
Deleted the Migration Folder.
>>>>>>> 4b275c4 (Revert "Installed Nuget Packege")


-----------------------------------------------------
Assignment 02 Part II
2023-03-24
1551
I added three wrong projects and the application was not working.
So, I started from the begining.
Kept the README.txt file from the previous application and added to this one.

1627
Changed Startup.cs, Added bootstrap.css file, Modified _Layout.cshtml file from the 1st part of Assignment

1646
Added 3 new projects.

2023-03-27
1251
Started doing the last part of the Part1
Installed Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages VERSION: 3.1.31 for both
And Deleted the Migrations folder

Installed Identity.EntityFrameworkCore VERSION: 3.1.31
Modified the namespace and Deleted default Class1.cs file in all projects

1435
Moved Models in to AbusBooks.Models 
Added Project Reference - .DataAccess and .Models

Modify Startup.cs service ‘AddContext’ 

Create a static details class called SD.cs in the Utility project and modified.
Add project reference to the main project, and
In the DataAccess project add project references t o Models and Utility

Added Customers area to Areas and Moved the HomeController.cs
Modified the _ViewStart.cshtml
Added a new Admin area in Areas and deleted the Data and Models folder
Deleted the Controllers folder

2023-03-31
0106
Built the Application and no error was found, the appliction run.
Modified the appsetting.json file

Added Migration
	and got migration named- 20230331051116_AddDefaultIdentityMigration

0131
Added Category.cs file
and modified ApplicationDbContext.cs file

0155
Added Repository and IRepository folder 
and IRepository.cs file and modified to be used on Category class.

0202
Added Repository.cs file and updated with given code
Added CategoryRepository.cs and ICategoryRepository.cs file and updated

0243
Installed Nuget Packeges for Dapper- Version: 1.9.0
Added ISP_Call.cs implemet file and modified
Added SP_Call.cs class file
	after adding the code getting an error in this file -- ExecuteScalar
	tried to add using statement but did not work
	tried with suggestion that shows when alt+enter is pressed but nothing changed.

0410
Added IUnitOfWork.cs implemet file
Added UnitOfWork.cs class file

0442
change the Startup.cs file
and added CategoryController.cs coltroller

0600
having more errors in Category.Controller.cs (2errors) and Startup.cs (2 errors) files

2023-04-06
1438
Tried to solve problems from Category.Controller.cs and Startup.cs files
in CategoryController.cs file I had prboblem. 
In line 30 I cahnged GetAll() to Getall() to solve error.

1529
Added a new folder in the Areas/View with the same name as the Controller
and Added a new ‘Index’ view to the folder and modified the code from the Category Index View.txt file. 


-----------------------------------------------------
Assignment 02 Part III
2023-04-09
1839
Started Project again.
My added 3 new projects are not going with my original project while commiting to Github.
Added README.txt from completed previous part of the assignment part II,
And added README.md file too.

Modified Layout and Startup.cs

1856
Added bootstrap.css file (Theme Journal)
Modified Layout.cshtml and LoginPartial.cshtml

2250
Modified Layout- Dropdown menu added

0004
Added 3 new Projects and moved Data folder

0026
Installed-
	Microsoft.EntityFrameworkCore.Relational version: 3.1.32
	Microsoft.EntityFrameworkCore.SqlServer version:3.1.32
	and Nuget Packege
Moved Model foleder, Edited Error.cshtml, ErrorViewModels.cs

0146
Added static class SD.cs, Added project references, Added Customer Area and modified.
Moved HomeController.cs to Area, Copied and Edited _ViewImport and _ViewStart.cshtml.
PART1 FINISHED...Projects ran properly.

2023-04-11
1453
Started doing Part II
Added Migration- 20230411185002_AddDefaultIdentityMigration.cs

2023-04-13
0056
Added Category.cs file

0132
Added IRepository.cs and Repository.cs file and modified

0148
Added ICategoryRepository.cs and CategoryRepository.cs file and modified

0204
Added ISP.cs and SP.cs file and modified

0204
Added IUnitOfWork.cs and UnitOfWork.cs file and modified
Modified Startup.cs

0259
Added CategoryController.cs and Index.cshtml file
Modified _Layout.cshtml

1526
Modified CategoryController.cs
and Updated Microsoft.AspNetCore.Identity.EntityFrameworkCore version 3.1.0 to 3.1.32
	my database was not updating with version 3.1.0

2023-04-14
0105
Added Index.cshtml and Upsert.cshtml in Views
Added _CreateAndBackToListButton.cshtml and _EditAndBackToListButton.cshtml

Added the API (Application Programming Interface) call for HTTPDelete in the CategoryController.cs
Implemented the HTTPDelete with a delete method in category.js 
Added the delete functionality in category.js 

Added the Delete(url) function code to category.js file for Sweet Alert and Toaster notifications

0126
STARTED WORKING ON PART 3
Created Cover Type CRUD as I created for Category CRUD
Added CoverType.cs in the Model’s folder with ID and Name property
after migration got- 
					20230414054805_AddCoverTypeToDb.cs

0211
Added ICoverTypeRepository interface and CoverTypeRepository class and modified

Added CoverType to UnitOfWork and IUnitofWork
And Updated the Database

0228
Added Cover Type to NavBar in _Layout.cshtml file
Added CoverType Controller with all required Action Methods

0313
Added Cover Type Index View to use DataTables
Added Cover Type Upsert View takes care of creating and updating CoverType
Added covertype.js file

0337
Added Product.cs file in Model Project
Modified ApplicationDbContext.cs file for Product
done add-migration and got-
							20230414073647_AddProductToDb.cs file
and updated database