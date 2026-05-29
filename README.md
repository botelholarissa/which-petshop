# which-petshop

C# application that selects the most cost-effective pet shop based on pet size, bathing prices, day of the week, and distance.
> Legacy academic/technical challenge project originally developed in Portuguese.

## Problem

Given three pet shops with different pricing rules, the application calculates the cheapest option for bathing small and large dogs.  
If there is a tie in price, the closest pet shop is selected.

## Tech Stack

- C#
- .NET
- Object-Oriented Programming
- Native libraries only

## Project Structure

### `Petshop.cs`

Responsible for:
- Storing pet shop data
- Calculating total service cost

### `Pedido.cs`

Responsible for:
- Handling user input
- Creating orders
- Processing business rules

## Features

- Weekday and weekend pricing rules
- Small and large dog support
- Tie-breaking by distance
- Console-based interaction

## How to Run

```bash
git clone https://github.com/botelholarissa/which-petshop.git
cd which-petshop
```

Open `EscolhaPetshop.sln` using Visual Studio and run the project.

## Example

```text
Enter the date (dd/mm/yyyy):
12/06/2026

Enter the number of small dogs:
2

Enter the number of large dogs:
1
```

Output:

```text
The best option is Vai Rex with a total cost of R$85.00
```
