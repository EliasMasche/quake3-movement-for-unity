Implementation of Quake III "vanilla" and Challenge ProMode Arena (CPMA) strafe jumping mechanics in the Unity engine.

This is a fork that replace UnityEngine.Input to UnityEngine.InputSystem, The Input System package implements a system to use any kind of Input Device to control your Unity content and Camera to Cinemachine suite of tools for creative camera that becoming the standard of Camera Management in Unity, tools that i am using on my project, original scripts created by [WiggleWizard](https://github.com/WiggleWizard). So most of the credit goes to him for porting it over and the port/fork is from the updated version from [IsaiahKelly](https://github.com/IsaiahKelly/quake3-movement-for-unity).

So far is already usable on projects, can be look messy or disorganized as i am developing, learning as it goes with InputSystem, so if you have proper feedback you can open issues or request PR. i will gladly read them.


## Requirements:

- Cinemachine: [2.7.x](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.7/manual/index.html)
- InputSystem [1.1.0-preview.3](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/QuickStartGuide.html)

### Why Preview for InputSystem.
I am using new features that are only available in 1.1.x that replace Input.GetMouseButton/.GetMouseButtonDown/.GetMouseButtonUp to InputSystem ButtonControl.isPressed / ButtonControl.wasPressedThisFrame / ButtonControl.wasReleasedThisFrame

## Notes:

### Coordinate System
Quake uses a right-handed coordinate system while Unity uses a left-handed one. So coordinate values (X,Y,Z) have been swapped to reflect this difference.

### World Scale
UPS (units per second) is measured in Unity units (meters) and not idTech units.

### Configuration
Default script values emulate Quake III Arena movement with CPM(A) physics.

### Demo Assets
Demo scene meshes were built with ProBuilder 4.4 so this package must be installed in your project for demo scene to function.
