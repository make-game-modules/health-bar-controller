# Health Bar Controller

[中文](https://github.com/make-game-modules/health-bar-controller/blob/main/README.zh-cn.md)

This project provides a Unity script for managing the health bar of game characters. The class should be attached to game objects that have a CharacterHealthController component. The health bar and health slot prefabs need to be specified in the Unity Editor. This class dynamically adjusts the size of the health bar to reflect the character's current health.

## How to Install

In your Unity project, clone this repository at any location using Git.

## How to Use

1. In the Unity Editor, attach this script to game objects that have a CharacterHealthController component.
2. Specify the health bar and health slot prefabs.

## Parameter Settings

1. `healthBar`: The health bar prefab. This prefab will dynamically change its size according to the character's health.
2. `healthSlot`: The health slot prefab.

## Operating Principle

During each frame update, this script gets the current health percentage of the character and dynamically changes the size of the health bar.

## Others

If you have any questions or suggestions, feel free to provide feedback via issues or pull requests.

## Copyright Information

This project uses the MIT open source license. Everyone is welcome to improve and use the project.
