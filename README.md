# Homing-Missiles-2D
Small project with homing missiles that automatically follow the nearest target

# How to use:

1) Add the HomingMissile.cs script to every object you want to act as a homing missile.
2) Add the Target.cs script to every object you want the missiles to follow.
3) Done!

# Note:
When a missile object is created it automatically finds the nearest Target using the updateTarget() method located at HomingMissile.cs. You will have to call it manually to find the nearest Target again (Maybe call it a few times in Update())