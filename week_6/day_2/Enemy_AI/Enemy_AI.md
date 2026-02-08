**Exercise 4 — Stealth Enemy AI Design**



***--> Scenario :***



This exercise presents the design of a stealth enemy AI for a stealth-based game.

The enemy guard is designed to feel intelligent, reactive, and fair, while allowing the player to use stealth and strategy.



***1. High-Level FSM (Finite State Machine)***



---> The AI uses a High-Level FSM to control its global behavior modes.



++ **FSM States :**

* **Patrol Mode :**



The guard moves between predefined waypoints and monitors the environment.



* **Alert Mode**



The guard becomes suspicious after hearing a sound or detecting unusual activity.



* **Combat Mode**



The guard confirms the player presence and actively engages 



**++ FSM Transitions :**



Patrol → Alert: Triggered when a sound is detected or suspicious activity occurs



Alert → Combat: Triggered when the player is clearly seen



Combat → Alert: Triggered when the player is lost for a short time



Alert → Patrol: Triggered when no threat is found after searching.



-----------------------------------------------------------------------------------------------------------------------



**2. Behavior Tree Logic**



Each FSM mode contains its own Behavior Tree (BT) to handle detailed decision-making.



***++ Patrol Mode — Behavior Tree (Sequence) :***



**--> Sequence Flow :**



1. Move to waypoint
   
2. Look around
   
3. Listen for noise
   
4. Repeat



This creates a predictable but believable patrol behavior.



***++ Alert Mode — Behavior Tree (Selector) :***



**--> Selector Priority :**



1. Investigate sound source
   
2. Search last known player position
   
3. Call backup you can add it if you want 



The AI uses memory to store the last known player position 



***++ Combat Mode — Behavior Tree (Selector) :***



***--> Selector Priority :***



1. Retreat if health is low
   
2. Attack if player is close
   
3. Chase player



This ensures survival-based and tactical decisions.

----------------------------------------------------------------

**3. Pathfinding (NavMesh)**



++ The guard uses NavMeshAgent for movement



***--> Capabilities:***



* Navigates around static and dynamic obstacles



* Recalculates paths when blocked



* Moves to last known player position when the player hides behind walls

-----------------------------------------------------------------------------------------------------------

**4. Advanced AI Features :**



**++ Vision System :**



* Vision cone using angle limits (not 360°)



**++ Hearing System :**



* Sound detection based on radius and intensity



**++ Memory System :**



* Stores last known player position.



* Forgets the player after a time delay.



**++ Search Behavior :**



* Searches nearby areas using random or spiral patterns

-------------------------------------------------------------------------------------------------------------

**5. AI Fairness Rules**



To ensure fair gameplay:



* &nbsp;	Reaction delays of 0.3–0.5 seconds are applied.
* &nbsp;	Detection angles are limited.
* &nbsp;	The AI never instantly snaps to the player.
* &nbsp;		Players can recover from small mistakes.

-------------------------------------------------------------------------------------------------------------------

**6. Expected Gameplay Feel**



* The player feels tension and suspense
* The player can outsmart the AI using stealth
* The AI feels intelligent but fair
* Behavior is predictable but not boring



