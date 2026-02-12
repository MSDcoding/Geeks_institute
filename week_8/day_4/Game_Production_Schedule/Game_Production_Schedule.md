**------------------- Game Concept -----------------------------------------------------** 



* **Game Type:** 3D First-Person Horror
* **Platform:** PC



* **Concept:**

A short first-person psychological horror game set inside an abandoned hospital at night. The player must explore dark corridors and  solve environmental puzzles avoid a lurking entity and escape the buildin. The game contains 3 progressively intense chapters each introducing new mechanics and tension elements.



---  Scope and High Level Milestones :

---   Milestone 1 — First Playable :



**Goal:**



A fully playable vertical slice demonstrating core horror mechanics.



**Deliverables**:



* First-person movement (walk, sprint, crouch)



* Flashlight system with battery mechanic



* One complete playable hospital floor



* One enemy entity with basic patrol AI



* Basic interaction system (doors, keys)



* Simple UI (Main Menu + Pause + Retry)



* Playable PC build



**Milestone 2 — Alpha Build**



**Goal:**



All main gameplay systems implemented (not fully polished).



**Deliverables:**



* All 3 chapters playable



* Advanced enemy AI (chase \& search behavior)



* Puzzle mechanics (locked doors, fuse boxes)



* Sound design (ambient sounds, jump scares, music)



* Health / sanity system



* Temporary lighting and visual atmosphere



--> Milestone 3 — Beta Build



**Goal:**

Feature-complete and polished experience.



**Deliverables:**



* Bug fixing and balancing difficulty



* Improved UI/UX



* Full lighting polish and post-processing



* Optimized performance



* Playtesting feedback implemented



* Final audio mixing



-->  **Work Breakdown Structure :**



Focused on Milestone 1: First Playable



--> **Epic 1 — Player Core Systems :**



Task ID    =- 	          Description	                =- Est. Time

==============================================================================

PS1	   =-  Create FPS controller setup	        =-   8h

PS2	   =-  Implement sprint and stamina system      =-   10h

PS3	   =-  Add crouch mechanic	                =-   6h

PS4	   =-  Flashlight system with battery drain     =-   12h

PS5	   =-  Interaction system (raycast detection)   =-  10h



Total: 46h



**--> Epic 2 — Environment \& Level Design :**



Task ID	      =-          Description     	                 =-   Est. Time        

=================================================================================

LD1	      =-  Design hospital floor layout (blockout)	 =-   8h

---------------------------------------------------------------------------------

LD2	      =-  Create modular corridor \& room assets	         =-   16h

---------------------------------------------------------------------------------

LD3	      =-  Implement lighting setup (dark horror mood)	 =-   12h

---------------------------------------------------------------------------------

LD4	      =-  Add interactive objects (doors, keys)	         =-   8h

---------------------------------------------------------------------------------

LD5	      =-  Add environmental sound zones	                 =-   8h

---------------------------------------------------------------------------------



Total: 52h



**--> Epic 3 — Enemy AI System :**



Task ID	       =-     Description                 =- Est. Time

=================================================================================

AI1	       =- Create enemy character prefab   =-	  8h

---------------------------------------------------------------------------------

AI2	       =-Implement patrol behavior	  =-     12h

---------------------------------------------------------------------------------

AI3	       =-Implement chase behavior	  =-     12h

---------------------------------------------------------------------------------

AI4	       =-Add player detection system	  =-    10h

---------------------------------------------------------------------------------



Total: 42h



--> **Epic 4 — UI \& Game Flow :**



Task ID	  =-      Description	                   =-   Est. Time

=================================================================================

UI1	  =- Main Menu	                           =-  6h

UI2	  =- Pause Menu	                           =-  6h

UI3	  =- Game Over screen	                   =-  6h

UI4	  =- Scene transitions \& build setup	   =-  6h



Total: 24h



**Dependencies :**



* PS2 depends on PS1
* PS3 depends on PS1
* PS4 depends on PS1
* AI2 depends on AI1
* AI3 depends on AI2
* AI4 depends on PS1
* LD2 depends on LD1
* LD3 depends on LD2
* LD4 depends on PS5
* UI4 depends on all core systems being integrated



--> **Critical Path :**



The Critical Path is the longest sequence of dependent tasks that determines total completion time.



--> **Critical Chain :**



1. PS1 → PS2 → PS4
2. LD1 → LD2 → LD3
3. AI1 → AI2 → AI3
4. Integration → Testing → Build



If any of these tasks are delayed, the First Playable milestone will be delayed.



**-->  Total Estimated Time (First Playable)** 

**:**

Phase	             =  Duration

=====================================

Player Systems	     =  46h

-------------------------------------

Environment \& Level  =	52h

-------------------------------------

Enemy AI	     =  42h

-------------------------------------

UI \& Flow	     =  24h

-------------------------------------

