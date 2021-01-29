<div align="center">
<img src="https://user-images.githubusercontent.com/49379604/99859318-b8f5c700-2b5d-11eb-9977-056ef61ecdb3.png">
</div>
<br>
<h1 align = "center">
<b> Sebring Shops and Resturants </b>
</h1>

<p align = "center">
This application has a database of local shops and resturants around the local area of Sebring Florida </p>
<p align = "center"> Created January 22, 2021 </p>



--------------------

## 📖  Description

This application has a database of local shops and resturants around the local area of Sebring Florida. The objective of the project is to showcase the usage of API's

This is the Independent Project for Epicodus week 13 as part of the "API" coursework. 

--------------------

## 🛠️ Technologies Used

This project uses the following technologies:

- C# v7.3.0
- .NET Core v2.2.0
- ASP .NET MVC
- ASP .NET Core Razor Pages
- MySQL
- MySQL Workbench
- Entity Framework Core
- Identity
- Postman
- Swagger
- Swashbuckler

-------------------

## 🐛 Known Bugs

-------------------

## 🔧 Setup & Requirements

### 📋 Necessary Specifications

#### To run this project locally you will need:

- **ASP .NET Core :** You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet-core)
- **MySQL :**  You can download MySQL [here](https://dev.mysql.com/downloads/file/?id=484914) and MySQL Workbench [here](https://dev.mysql.com/downloads/file/?id=484391)
- **Prefered Code Editor**


### ⚙️ Open & Use

#### To Download:

Go to my GitHub repository here, [https://github.com/ebezjian/SebringShop.Solution](https://github.com/ebezjian/SebringShop.Solution), and click on the green 'Code' button to clone the repository, Open with GitHub Desktop OR Download the ZIP file

#### To clone (my prefered method):

1. Push the green 'Clone' button and copy the URL.
2. Open Terminal or GitBash and input the command: `git clone https://github.com/ebezjian/SebringShop.Solution.git`
3. To view the code, open the copied directory with Visual Studio Code or your preferred text editor by inputing the command `code .` in your terminal.


#### AppSettings:

After you have the project on your computer you will need to create a `appsettings.json` file within the sub-directory of the project called Bakery.Solution/`SebringShop`. Add the following snippet of code to the appsettings.json file:

```
{
  "AppSettings": {
    "Secret": "epicodus"
  },
  
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=ellie_lambert_sebring_shops;uid=root;pwd=epicodus;"
  }
}
```
*Please note you will need to replace `epicodus` with the password you created for your MySQL server.
## 	📝 API Documentation and endpoints

Feel free to navigate through the API endpoints via Postman or another API Client.

* API List of Shops: `http://localhost:5000/api/shops`
* API List of Restaurants: `http://localhost:5000/api/restaurants`

- These are the following engpoints:

<img src="https://cdn.discordapp.com/attachments/537816642122547212/804669470874402846/endpoints.PNG">
<br>

- these are the perameteres:

<img src="https://cdn.discordapp.com/attachments/537816642122547212/804681366418620447/perams.PNG">

### Accessing SwaggerUI

Launch the project from the `SebringShop` project directory by typing `dotnet run` into the terminal. Input `http://localhost:5000/swagger` to view and interact with the Swashbuckle SwaggerUI.
<br>

### Documentation Referenced for Swashbuckle Integration

* [Microsoft Docs: Swagger Overview](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0)
* [Microsoft Docs: Get Started with Swashbuckle](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio)
* [GitHub Swashbuckle.AspNetCore README.md](https://github.com/domaindrivendev/Swashbuckle.AspNetCore/blob/master/README.md)

#### Import Database using Entity Framework Core (option 1 continued):

 - In the command line run ` cd Desktop/SebringShop.Solution/SebringShop` to navigate to the "SebringShop" folder. 
 - Next, run `dotnet ef database update` to generate the database. You can confirm the database was created by checking MySQL workbench.

*to make changed to the database you can run `dotnet ef migrations add <MigrationName>`

#### Import Database using MySQL Workbench (option 2):

 - Open MySQL workbench and go to the navigation bar and select `Server > Data Import`. 
 - Next, select the option `Import from Self-Contained File` and confirm you have the file `ellie_lambert_shops.sql` set to be imported (this files exists in the root directory of this project). 
 - Then, set the `Defaul Target Schema` or create a new schema and select all the the Schema Objects you want to be imported. 
 - Check that the option `Dump Structure and Data` is selected. Once you confirm you have all of the correct settings click `Start Import`.


#### Running/viewing application:

1. Once you have opened the code in your preferred text editor you will need to navigate to the 'SebringShop' folder (`cd SebringShop) in the command line and run `dotnet run` or `dotnet watch run`.
2. At this point you should be able to click on the link to the local server's url path to view the compiled project. 

--------------------------

## 📫 Support and contact details

If you run into any problems or have any questions please contact me via [email](mailto:ebezjian@gmail.com).

---------------------------

## 📘 License

MIT License

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

Copyright (c) 2021 Ellie Lambert