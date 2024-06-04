# Sports Supplements


[![Open Source](https://badges.frapsoft.com/os/v1/open-source.svg?v=103)](https://opensource.org/)


## Description


Sports Supplements is a web platform designed to list all available sports supplements. It is intended for athletes and health-conscious individuals. The application is intuitive and easy to use, providing a smooth experience for users looking for information about sports supplements.


## Features


- Complete list of available sports supplements

- Detailed information about each supplement

- Connection to a SQL Server database for data management


## Installation


Below are the packages and dependencies required to run the project:


```xml

<ItemGroup>

   <PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.0" />

   <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.0" />

   <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0">

     <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>

     <PrivateAssets>all</PrivateAssets>

   </PackageReference>

   <PackageReference Include="Swashbuckle.AspNetCore" Version="6.4.0" />

</ItemGroup>

```


To set up the project, make sure you have a SQL Server database available and configure the connection string in the application configuration file.


## Usage


1. **Clone the Repository**:


  ```bash

  git clone https://github.com/JuanJSalzar/sports-supplements.git

  cd sports-supplements

  ```


2. **Configure the Database**:


  Update the connection string in the `appsettings.json` file with your SQL Server details.


3. **Run the Application**:


  Use the following command to run the application:


  ```bash

  dotnet run

  ```

## Contribution


Contributions are welcome. If you wish to contribute, please follow these steps:


1. Fork the repository.

2. Create a new branch (`git checkout -b feature/new-feature`).

3. Make your changes and commit them (`git commit -am 'Add new feature'`).

4. Push your branch (`git push origin feature/new-feature`).

5. Create a new Pull Request.


## License


This project is open source


## Authors and Credits


- **Juan J Salzar** - *Lead Developer*


## Contact


For questions or comments, please contact via [GitHub](https://github.com/JuanJSalzar).