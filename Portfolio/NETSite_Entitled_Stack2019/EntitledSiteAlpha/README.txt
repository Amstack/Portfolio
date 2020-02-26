<Entitled> Website - ASP.NET MVC5 Project for Systems Analyis CSC 481
Alex Stack 2019

The point of this project is to demonstrate the ability to create a CRUD database and a user management systems within Microsoft's ASP.NET core.
The site uses the MVC5 (model-view-controller) paradigm and integrates with an SQL relational database. Using the MVC paradigm splits the site into three major components
	1. Models - data models, basically object code, used only to create objects which are used to pass data between controllers
	2. Views - statically or auto-generated HTML scaffolding. Used to render HTML, can contain embedded C# code
	3. Controllers - C# logic and traffic control. Used to control the passage of objects and data between views
My project also has additional C# code which contains helper functions to interact with my SQL database (Repository)
To interact with the database, a series of SQL stored procedures are used for better reusability.

The required packages to make this project work are the ASP.NET core and a SQL server. Included are the sql commands to reproduce my database structure and
stored procedures (SQLBackup.sql). In order to change the database settings, select the connection strings (located at top of the Repository classes).

The Manage User page has seperate Views located in the Areas/Identity/Pages/Account section, this is due to the way .NET handles the built-in code.

You can edit the overall view and layout of the site using the /shared/_Layout.cshtml (_xxx.cshtml views are not visibile to the public), where the theme and 
navigation bar can be edited.