# ProceduralAnimation
This is a **"workspace**" for understanding **Inverse Kinematiks** and move the entity without animation. 
## Spider Procedural Animation
![ProceduralAnimation - SampleScene - Windows, Mac, Linux - Unity 2021 3 8f1 Personal_ _DX11_ 2024-02-07 03-09-26](https://github.com/Erces/ProceduralAnimation/assets/51009171/f9deffef-98b3-4830-bc82-61c598b8bc16)
#### SpiderAnimator Script
![image](https://github.com/Erces/ProceduralAnimation/assets/51009171/bbac9e6d-afe1-4588-9c1c-4e59b004158c)


**HOW TO USE:**
- Targets are individual leg targets, targets are directly effect the IK system acording to their positions
- Legs are just the same in a List
- Trackers are attached to entity's body and move with it, when the distance between tracker and its target below the track range, target leg moves to tracker position,
- Leg height difference is for non-flat surfaces, when some leg higher then others, in this case system takes the difference and sets which side (right/left) is higher then rotate the body this way.
- Track range is a step range, how much meters should wait till new step
