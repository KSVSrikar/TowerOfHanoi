# TowerOfHanoi

Play the classic puzzle game of Tower of Hanoi.

---
# Setup  
The contents of this repository needs to be run on a Unity3D application.
Once Unity3D is installed, simply goto `TowerOfHanoi/TowerOfHanoi/Assets/Scenes` and click on Scene1.unity file.

---
# Controls
* A KEY to select top disk from or place held disk on ROD1.
* S KEY to select top disk from or place held disk on ROD2.
* D KEY to select top disk from or place held disk on ROD3.
* Tab KEY to toggle menu(simple toggle will not reset status of current level), level change will remove previous level's progress.

---
# Goal
The goal of the puzzle is to move all the disks from the leftmost Rod to the rightmost Rod, adhering to the following rules:
1. Move only one disk at a time. 
2. A larger disk may not be placed on top of a smaller disk.

---
# Built with 
1. UnityEngine.
2. Monodevelop.
3. Adobe Photoshop.

All assests and scripts are self-constructed using above software.

---
# Screenshots

GameMenu:
![1](https://user-images.githubusercontent.com/35230083/38263522-f2feb41e-378d-11e8-8669-a9b5be2bf383.png)

Initial state of Level1:
![2](https://user-images.githubusercontent.com/35230083/38263523-f33217fa-378d-11e8-8b65-6cc9d77a26c1.png)

Valid Move(ROD1 to ROD3):
![3](https://user-images.githubusercontent.com/35230083/38263547-fc6ca178-378d-11e8-9a3c-392ce82768fb.png)

Emptyrod error when accessing ROD2:
![4](https://user-images.githubusercontent.com/35230083/38263548-fc9b8bc8-378d-11e8-81ba-a15ed7759d79.png)

Invalid Move error when trying to place disk from ROD1 to ROD3:
![5](https://user-images.githubusercontent.com/35230083/38263549-fccc4b14-378d-11e8-8542-4a9f000d6d6d.png)

WinCondition:
![6](https://user-images.githubusercontent.com/35230083/38263550-fcfafde2-378d-11e8-967d-7f52c0f1e480.png)

---
# References

https://en.wikipedia.org/wiki/Tower_of_Hanoi.

---
