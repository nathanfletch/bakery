# Bakery


#### Hungry? Come inside and grab a bite!

#### _By Nathan Fletcher_

* This program provides a console interface for users to add and remove items from their order at a bakery. Prices are based off of a dynamic pricing algorithm.

## Technologies Used

* C#
* MSTest
* Test Driven Development
* Object Oriented Programming


## Setup

<details>
<summary>Setup & Installation Instructions</summary>

* Clone this repository to your local machine
* Install C# and .NET using the [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-5.0.100-macos-x64-installer) if necessary
* Navigate to the Bakery.Tests folder in your terminal
* Type `dotnet restore`
* Navigate to the Bakery folder
* Type `dotnet run`
</details>

## Known Bugs
* The static BakeryItem variable should be refactored to be private
## Future Plans
* Add additional classes and options
* Make the pricing algorithm more dynamic
* Convert the program to a web app
## License

_[MIT](https://opensource.org/licenses/MIT)_  

Copyright (c) 2021 Nathan Fletcher 

## Contact Information

_Nathan Fletcher @ github.com/nathanfletch_  

    /*
    MVP:
    Test and implement Bread CalculateCost(int n) static fn
    Test and implement Pastry CalculateCost(int n) static fn
    
    Add abstract class BakeryItem
    test/imp constructors
    static list: order 

    calc/disp order cost GetOrderCost
      use GetType and call each classes' method.
    UI!

    Completed Extras:
    -update Readme
    -ui cycle to keep adding
    -abstract Name prop
    -remove from order
    -Add teardown function with IDisposable interface

    Extra: 
    extra props 
    -freshness/daysOld: change price function
    -names (Bob's Murderer Bread, Focaccia)
    -privatize the static for BakeryItem
    */