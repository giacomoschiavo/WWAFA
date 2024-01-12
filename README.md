# Overview - When We All Fall Asleep

## Authors
Giacomo Sanguin, Giacomo Schiavo

## "When We All Fall Asleep" Overview
"When We All Fall Asleep" is a single-player horror game in first-person view. The player wakes up in a dark cave, trapped and desperate to escape. The cave is populated by monsters named Akumu, whose only goals are to kill everyone they encounter in their path. To find a way out, the player must collect five different items scattered throughout the cave. These items hold the key to unlocking the exit and surviving the terrifying ordeal.

### The Story
"When We All Fall Asleep" is a horror game set in a dark cave, where the player, waking up with amnesia, must collect items to survive and escape. As the player retrieves the items, an intricate plot unfolds. The protagonist, a mafia member named Tom, murdered a debt-ridden family, later falling into a coma after a car accident.

- **Father's Room:** The opening letter reveals the father's debt to the mafia, leading the family to separate for protection. The father expresses remorse for his actions, mentioning a "monster" that will be revealed to be Tom.

- **Daughter's Room:** The daughter's diary reveals happy memories and hints at a "monster" now present in the cave.

- **Wife's Room:** The wife wishes to return to her husband for safety, emphasizing their lack of security. At this point, the player should think that the monster everyone refers to is Akumu.

- **Boss's Room:** The boss's diary reveals that the family, monitored by Tom, was destined to die after the father repaid the debt. Tom becomes the killer tasked with this terrible mission.

- **Tom's Room:** Tom's letter reveals that after killing the family, he was hit by a car and fell into a coma. The cave represents his subconscious, where he must decide whether he deserves life after the atrocities committed.

### The Ambient
The game is set in a labyrinthine and dark cave where the tunnels are very narrow. Various assets, including the cave, house, diary, arrow, and hospital bed, were utilized to create the environment. The map was designed to disorient the player deliberately, with strategically placed boulders and lanterns. Rooms in the cave represent different characters in the story, adding a more oniric experience.

### The Player
The player's perspective is in the first person, and the player has a limited visibility in the dark, requiring a lantern to see a short distance ahead. Running too much extinguishes the candle, and unintentional noises can be made. The player's running speed is slightly greater than that of the monster. To win, the player must collect five items related to the story.

### The Monster
The monster, Akumu, is a blind creature relying on senses. It transitions between states like idle, wandering, and chasing based on the player's actions. The monster's AI is modeled using a finite state machine, providing a dynamic and challenging experience.

### Monster's Animator
The monster's animations are handled by the Unity Animator. Transitions between animations are triggered based on the monster's state changes, and a jumpscare animation is integrated for added suspense.

### Multiple Monsters and Wandering Path
To enhance gameplay, three monsters were included, each with a designated path. The labyrinthine structure of the cave and the monsters' wandering paths were designed to balance challenge and engagement.

### Monster's Model and Animations
The monster's model was imported from Sketchfab, and animations were created and downloaded using Mixamo. A jumpscare animation was crafted with the Unity Animator tool.

### Sound Design
Various sounds were incorporated, including background music, footsteps for the player and monster, growling sounds, and a jumpscare sound. The goal is to create an immersive and suspenseful atmosphere.

### Scene Organization
The game consists of four scenes: MenuScene, TutorialScene, GameScene, and GameOverScene. The MenuScene provides options to start or quit the game. The TutorialScene guides players through the game's mechanics. The GameScene is where the main gameplay occurs, and the GameOverScene is displayed when the player is caught by the monster.

## Simulations and Results
Player feedback was positive overall, with some suggestions for adjustments, such as reducing footsteps' loudness and adjusting the candle duration. Players improved their skills with more gameplay.

## Conclusions and Future Work
The development was challenging but rewarding, with a focus on integrating storyline and gameplay elements. Future work involves refining mechanics based on player feedback, expanding the narrative, and potentially incorporating alternative storylines or endings.

### Full Story
[Full Story Section](#full-story)
