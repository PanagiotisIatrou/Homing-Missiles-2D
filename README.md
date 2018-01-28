# Homing-Missiles-2D
Small project with homing missiles that automatically follow the nearest target

# How to use:

1) Import the HomingMissiles2D.unitypackage in your Unity project
2) Add the HomingMissile.cs script to every object you want to act as a homing missile.
3) Add the Target.cs script to every object you want the missiles to follow.
4) Done!

# Notes:
- When a missile object is created it automatically finds the nearest Target using the updateTarget() method located at HomingMissile.cs. You will have to call it manually to find the nearest Target again (Maybe call it a few times in Update())
- There are example prefabs. 1 for a target and one for a missile. Just drag them on your scene
