# Auto Web Shop

This is example of an online shopping site for selling and buying cars.

## Running

### Requirements

- IIS Express
- .NET Core 2.0
- Visual Studio 2017+

### Instructions

1. Clone this repository
    ```sh
    https://github.com/MSH63ack/Ecommerce_website.git
    ```
2. Delete the 'Migrations' folder.
3. Open the project with Visual Studio.
4. Open Package Manager Console.
5. Enter the command
	```sh
    add-migration <name of your migration>
    ```
6. Enter the command
	```sh
    Update-Database
    ```
7. Run the project.

**Note:** The initial build can take a little longer as it needs to restore NuGet packages. 
If necessary, you can change the connection strings for your database or login information in the 'appsettings.json' file as an administrator

## Authors

* **Marta Shuiak**

