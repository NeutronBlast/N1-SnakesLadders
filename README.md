# Snakes & Ladders
> Board game with RS232 connection for Networking I subject

## Table of contents
- [Snakes & Ladders](#snakes-&-ladders)
  - [Table of Contents](#table-of-contents)
  - [About The Project](#about-the-project)
  - [Game Rules](#game-rules)
  - [Modes](#modes)
  - [Special Rules](#special-rules)
  - [Built With](#built-with)
  - [Setup](#setup)
  - [Getting Started](#getting-started)
  - [Usage](#usage)

## About The Project

**Main Goal**: Build a board game in a 10x10 board.

**Other goals**:
1. Create a graphic interface that allows the user interact with the game
2. Create an standard data protocol to connect with the players of the game
3. Use RS232 to create a functional and stable game
4. Minimize the quantity of information that will be sent each turn
5. Manage in an efficent way the concept of addressing 

## Game rules

1. Each player starts with a token and takes turns to roll the dice that will indicate the number of boxes that are allowed to advance. 
2. Each player moves according to the numeration of the board, in ascending direction. After the move, if a player goes into a box where a ladder starts he will go up there until the box where it ends. However, if the player goes to the head of a snake he will descend through it until the box where its tail is
3. If the player rolls a 6 he will be able to roll the dice again, if a player rolls three 6s in a row he will return to the initial box and won't be able to move until rolling a 6 again. The player that makes it to the final box will win.

## Modes

1. The player will win only if he makes it to the final box with the exact number.

## Special rules

1. If a player makes it to one of the 3 special boxes that will be specified later the game will reverse, that is to say, if the sense was from player 1 to 4 now it will be from player 4 to 1. The boxes that will make the sense to reverse vary according to the board that the developing team chooses. The board selected for this team will be the following:

![Board](./Assets/Templates/board.jpg)

The special boxes for this board are: 17, 45, 86

### Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)

<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites


### Installation
 
1. 

<!-- USAGE EXAMPLES -->
## Usage
