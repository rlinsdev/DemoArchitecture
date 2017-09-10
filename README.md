# Demo Celtrino Project

This project is a skeletal of a project

##technologies
I created one solution in 3 layers: 
•	UI (User Interface): This is the part exposal of my system (part that the user see)
•	Infrastructure: Responsable for the external connection (In this case, contains DAL)
•	Domain: This is the Heart of the solution. In Domain contains e BLL, with business roles

The solution have 5 projects:
•	Demo.UI.Mvc: Apresentation layer. 
I create one project in:
o	Web.API: I prefer use Web.API because I decide to use SPA and with WebAPI I have an organized and clear code
o	Angular.JS: Angular.JS: A great javascript framework. This is a powerful framework that provides great experience to users
o	Single Page Application (SPA): This provide a better experience to users
o	Bootstrap: This provide a better experience to users
o	Responsible web site: With bootstrap I can defefine how the page will render in diferent sizes/devices
o	UI-rote: Solution to flexible routing with nested views in AngularJS. Working between 'home' and 'maps' page
o	RequiredJS: Carry the javascript under demand. With this, the system becomes lighter. Essential to big systems
o	dirMap: Directives about google maps. The both js files responsible to carry google maps was put in the project, but the map doesn't work because I don’t have an API Key to put in the system. In my previous job, we have problem with expense and google API

•	Demo.UI.Mvc.Test: Unit tests to controllers from WebAPI
•	Domain.Business: Business layer of the system. Logic and rule business stay here. Methods that call the DataBase here. Interfaces here
•	Domain.Business.Test: Unit tests to Business part
•	Infrastructure
o	DAL: Data Access layer. Responsible to Access to SQL DataBase. 
o	Inheritance was applied to access the database.
o	Dapper: ORM to access dataBase. I used Dapper because is faster than EntityFramework and I used in previous systems. I left another class with a simple access to Vehicle data too.

•	SQL DataBase: I created a small database with two tables too. I left the query to generate the database and the tables in the project
•	Login Control: The login control, I just left the layout ready. All the code require time to be done, because:
o	I need put in DataBase the users and control your access putting password and hash control (to encrypt the password)
o	I thought about put facedbook login API to consume and received the OK about the login control, but how I never did this before, probably I'll not able to put it work in a small time


## Getting Started

Download the application
Rotate the project to a compatible IDE

### Prerequisites

Have IIS installed on the machine
Visual studio to be able to run the project and test it

## Authors

Rodrigo Lins e Freitas
