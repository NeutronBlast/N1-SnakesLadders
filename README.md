# Snakes & Ladders
> Board game with RS232 connection for Networking I subject

## Table of contents
- [Snakes & Ladders](#snakes-&-ladders)
  - [Table of Contents](#table-of-contents)
  - [About The Project](#about-the-project)
  - [Game Rules](#game-rules)
  - [Modes](#modes)
  - [Special Rules](#special-rules)
  - [Boards](#boards)
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

1. Each player starts with a token and takes turns to roll the dice that will indicate the number of slots that are allowed to advance. 
2. Each player moves according to the numeration of the board, in ascending direction. After the move, if a player goes into a slot where a ladder starts he will go up there until the slot where it ends. However, if the player goes to the head of a snake he will descend through it until the box where its tail is
3. If the player rolls a 6 he will be able to roll the dice again, if a player rolls three 6s in a row he will return to the initial box and won't be able to move until rolling a 6 again. The player that makes it to the final box will win.

## Modes

1. The player will win only if he makes it to the final slot with the exact number.

## Special rules

1. If a player makes it to one of the 3 special slots that will be specified later the game will reverse, that is to say, if the sense was from player 1 to 4 now it will be from player 4 to 1. The slots that will make the sense to reverse vary according to the board that is choosen at the start of the game.

|**Board**|**Special slots**|
|---------|-----------------|
|    1    |  18, 46, 85     |
|    2    |  17, 45, 86     |
|    3    |  23, 54, 88     |
|    4    |  13, 41, 94     |
|    5    |  12, 48, 94     |
|    6    |  17, 41, 81     |

## Boards
[Board 1](./Assets/Game/board_1.jpg)
[Board 2](./Assets/Game/board_2.jpg)
[Board 3](./Assets/Game/board_3.jpg)
[Board 4](./Assets/Game/board_4.jpg)
[Board 5](./Assets/Game/board_5.jpg)
[Board 6](./Assets/Game/board_6.jpg)

### Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)

<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites


### Installation
 
1. Clone the repo 

```sh
https://github.com/metalsonic21/N1-SnakesLadders.git
```

2. Locate the `.exe` file in `/bin/Debug`

<!-- USAGE EXAMPLES -->
## Usage
