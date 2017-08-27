# _My Portfolio_

#### _This is an on going project and is my portfolio. Future updates are coming_

#### By _**Kimlan Nguyen**_

## Description

This webpage is my portfolio. You can see information about me. Also, there is a page that shows my most starred projects on github using Github Api.


## Setup/Installation Requirements

+ Open Windows PowerShell and type in the following code to clone this file <code> git clone https://github.com/kimlan1510/Portfolio-with-ASP.NET-MVC</code>
+ You need to obtain an access token from Github. Follow the instructions here https://github.com/blog/1509-personal-api-tokens to get your personal access token.
+ Once you have the access token, in Visual Studio 2017, Create a class called EnvironmentVariable in the root folder. It should look like this:
```
namespace Portfolio
{
    public class EnvironmentVariable
    {
        public static string AccessToken = "{YourAccessToken}";
    }
}
```
+ Run the application in Visual Studio 2017

## Known Bugs

_The content of the page does not align correctly if the nav bar is manually collapsed._



## Support and contact details

Contact me @ kimlan1510@gmail.com if you run into any issues.

## Technologies Used

+ C#
+ ASP.NET MVC5



### License

*MIT*

Copyright (c) 2017 **_Kimlan Nguyen**
