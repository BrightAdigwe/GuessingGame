# Dice Roll Guessing Game

## Overview
A modular C# console application demonstrating clean architecture and the Single Responsibility Principle (SRP). Players attempt to guess a randomly rolled dice number within 3 tries.

## Project Structure
```
Guessing_Game/
│
├── Program.cs             # Application entry point
├── Game/
│   ├── Die.cs             # Dice rolling mechanism
│   ├── GuessNumberGame.cs # Core game logic
│   └── GameOutcome.cs     # Game result enumeration
├── I_O/
│   └── ConsoleInput.cs    # User input handling
└── Validation/
    └── Validator.cs       # Input validation
```

## Key Design Principles
- **Single Responsibility Principle (SRP)**: Each class has a distinct, focused responsibility
  - `Die`: Generate random dice rolls
  - `GuessNumberGame`: Manage game flow and logic
  - `ConsoleInput`: Handle user input
  - `Validator`: Validate input integrity

## Game Mechanics
- Maximum of 3 guess attempts
- Random number generation between 1-6
- Immediate feedback on each guess
- Clear win/lose conditions

## Features
- Robust input validation
- Separation of concerns
- Clean, modular architecture
- Error-tolerant design

## Technical Highlights
- Uses `Random` for dice roll generation
- Implements out parameter for validation
- Utilizes enums for game outcomes
- Minimal console interaction

## Getting Started

### Prerequisites
- .NET SDK (6.0+)
- C# development environment

### Running the Game
1. Clone the repository
2. Navigate to project directory
3. Run `dotnet run`

## Potential Enhancements
- Add logging
- Implement more sophisticated input validation
- Create unit test coverage
- Add configurable difficulty levels

## Learning Objectives
- Understand modular software design
- Practice implementing SRP
- Learn input validation techniques
- Explore enum usage

