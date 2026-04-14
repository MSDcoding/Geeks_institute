-------------**--  Practical Exercises — Enemy AI** ------------------------------------------------------------------------------------



**--------------- Exercise 1: Enemy AI Design (FSM) ----------------------------------------------------------------------------------**





--> **FSM State**s :



1. Patrol :

Enemy walks between waypoints 



2\. Alert :

Enemy stops and looks around when a sound or movement is detected to observe what  is happening 



3.Chase :

Enemy runs toward the player when detected to attack him or to do somthing to him 



4.Search :

Enemy searches last known player position 

&nbsp;	

**--> Transitions (Conditions) :**



Patrol → Alert (player noise detected)



Alert → Chase (player seen)



Chase → Search (player lost)



Search → Patrol (search time finished)



**--> NavMesh Usage :**



Enemy uses NavMesh during Patrol, Chase, and Search to move correctly around obstacles 



**--> Player Escape :**

&nbsp;

Player can escape by breaking line of sight or running far enough that make the ai lose his ability of searching about the player 



**-------------- Exercise 2: Behavior Tree Logic  ------------------------------------------------------------------------------**



**Behavior Tree Flow :**



 **--> Selector :**



1. Sequence: Player visible and in attack range → Attack



2\. Sequence: Player visible AND far → Chase



3\. Sequence: Player seen recently → Search



4\. Action: Patrol



**Node Labels :**



* Selector 



* Sequence 



* Condition Nodes 



* Action Nodes 



**---------------- Exercise 3: Unity Enemy AI (FSM + NavMesh)  -----------------------------------------------------------------------------**



**look unity scene it has everything this exercise required ..** 



