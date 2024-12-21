# Simple-Inventory-System-
Simple Inventory System
This repository contains a Simple Inventory System implemented in C#. The system provides basic functionality to manage an inventory, including adding, removing, displaying, and using items. It is designed for educational purposes and serves as a foundation for more complex inventory systems in applications such as games or other software projects.

Features

Add items to the inventory (with a maximum capacity).

Remove items by name.

Use items, triggering their associated functionality.

Display the current contents of the inventory.

How to Run

Clone the repository or download the source code.

git clone <repository-url>

Open the project in an IDE that supports C#, such as Visual Studio.

Build and run the program.

Interact with the inventory system via the console output.

Code Overview

Classes

Item

Represents an individual item in the inventory.

Properties:

Name: The name of the item.

Description: A brief description of the item.

Methods:

Use(): Prints the item's use description to the console.

Inventory

Manages a collection of items.

Features:

Add items (with capacity checks).

Remove items by name.

Use items by name, removing them after use.

Display the current inventory.
