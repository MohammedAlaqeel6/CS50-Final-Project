#CS50 Final Project
### Introduction
#### Ezinvaders Game Video Demo: 
<https://www.youtube.com/watch?v=-LRMiLPCKok>

#### Ezinvaders Game Description:
In this project I chose to develop a fighting game as a person interested in video games in order to improve my technical skills. 

This game consists of two parties, the first party are the invaders who storming the player's land and the second party is the cannon (Shooter) that the player uses to protect his land from invaders, and it’s has been developed by using Visual basic language by identifying a public class and private subs with if statement through Microsoft Visual studio to programming the game.

### Game Desgin 
This game is simple in its way and comfortable in designing it in terms of colors and elements so that the game consists of only elements, namely: the cannon, the shots and the invaders, all of them in blue that is indicates the strength and confidence, which is what the parties to the game enjoy (the cannon and the invaders) Also this color represents the inspiration and knowledge that it has gained From this great cycle as well as being my favorite color.

#### Ezinvaders Elements:
###### Cannon (Shooter)

![image](https://user-images.githubusercontent.com/91496800/139961512-3b02f66c-2e58-40aa-b945-d28995c34c33.png)

###### Shot

![image](https://user-images.githubusercontent.com/91496800/139961714-9e145feb-97df-4649-a9b6-bdd944d1986b.png)

###### Invaders

![image](https://user-images.githubusercontent.com/91496800/139961743-71930e5e-6ffb-43b6-b337-3e5b33117c15.png)

### Ezinvaders Scenario
###### The main scenario (Win the game):
1. The user will click the game.
2. The app will start the game.
3. The user clicks right and left buttons to direct the cannon to the invaders.
4. The app will redirect the cannon based on the user directions.
5. The user clicks the keyboard space button to shoot the invaders.
6. The cannon will fire bullets at the invaders.
7. If all the invaders are killed, the app will display a notification “the land is saved”.
8. The user will click “OK”.
9. The app will display a notification “Do you want to play again?”.
10. If the user clicks “Yes” the app will start the game again, if the user click “No” the app will close the game window.

###### The alternative scenario (Losing the game):
1. The user will click the game.
2. The app will start the game.
3. The user clicks right and left buttons to direct the cannon to the invaders.
4. The app will redirect the cannon based on the user directions.
5. The user clicks the keyboard space button to shoot the invaders.
6. The cannon will fire bullets at the invaders.
7. If not all the invaders killed, the app will display a notification “Game Over”.
8. The user will click “OK”.
9. The app will display a notification “Do you want to play again?”.
10. If the user clicks “Yes” the app will start the game again, if the user click “No” the app will close the game window.

### Technical Details
#### Source Code Description:
This is the detailed description for the backend code. first of all I added 2 pictureboxes to the game form which are the shooter and I named it “PNGShooter” in the properties, the shot and I named it “Shot”. For the invader's Picture I have been adding it to Project Resources to be animated dynamically.
###### Shooter Backend Code Description
The following steps clarify the shooter backend code to animate the shooter to the right and the left based on the keyboard keys and inputs:

1. Adding a Timermain_Tick Event in a private sub. 

![image](https://user-images.githubusercontent.com/91496800/139963601-a1b2e31b-f1b4-4fc4-85b4-9f791e973d80.png)

2. Defining variables (SRight and SLeft) as Boolean type using Dim statement.

![image](https://user-images.githubusercontent.com/91496800/139963656-a8ce13bc-4ae7-4172-a6d6-95b8056f3490.png)

3. Adding a KeyDown event in a private sub which allows to detect when a key on the ‎keyboard was held down by using If statement and giving the variables in Step 2 ‎value “True”. Which will occur when the user presses a key.

![image](https://user-images.githubusercontent.com/91496800/139963796-59a30461-0f3a-4c91-92b0-cea3195692ea.png)


4. Adding a private sub named “MoveShooter” and call it in the private sub in Step 1.

![image](https://user-images.githubusercontent.com/91496800/139963860-a576d77e-fe07-420d-86c3-110f5dd2fec7.png)

5. Adding a variable (ShooterSpeed) as Integer type using Dim statement to clarify its properties in the private sub “MoveShooter” in Step 4 to specify the shooter’s speed when the user clicks right or left buttons.

![image](https://user-images.githubusercontent.com/91496800/139963972-522fbf1b-1beb-4397-8cac-11836522aa73.png)

6. Adding KeyUp event in a private sub which will occur when the user releases a key by using If statement and giving the variables in Step 2 value “False”.

![image](https://user-images.githubusercontent.com/91496800/139964050-d56795d5-20a1-4ead-9717-67432374a4e8.png)


7. Defining the Client rectangle that represent the client area of the control. In the private sub “MoveShooter” to Stops the cannon (Shooter) from moving when it touches the border of the game window.

![image](https://user-images.githubusercontent.com/91496800/139964130-018e4515-d154-4e21-9eb6-85c89a47412e.png)

###### Shot Backend Code Description
The following steps clarify the shot backend code to So that the shot is fired from the Shooter to targets the invaders based on the keyboard keys and inputs:
1. Adding “ShotSpeed” variable in Dim Statement as Integer type.

![image](https://user-images.githubusercontent.com/91496800/139964639-1b42d665-3341-4852-890f-ea7f358cb3fa.png)

2. Adding a “loadSetting” Private sub to defining the form load setting as a shooter and shot speed and the ‎visibility of the shot when loading the game.

![image](https://user-images.githubusercontent.com/91496800/139964689-d4d54893-3699-411a-9310-c27cbd0ee112.png)

3. Adding Form load event in a private sub and call the private sub “loadSetting” in Step 2. 

![image](https://user-images.githubusercontent.com/91496800/139964739-85362af7-4ece-4469-ae2f-a35316e7828e.png)

4. Clarifying the shot animation in KeyDown Event that already added before in Shooter step 3. So, the shots will move to the Top and will move to the left and the right depending on the shooter animation.

![image](https://user-images.githubusercontent.com/91496800/139964794-40a077d0-b43e-4094-9ce2-5b2e27ca3da3.png)

5. Adding “FireShot” Private Sub to clarify how to take-out shots from the shooter, where the shooter can't take out a new shot if the previous shot didn't shoot or disappear outside the game window.

![image](https://user-images.githubusercontent.com/91496800/139964847-a28c84de-86f8-4ee4-86bc-771e5941e2b0.png)

6. Calling the “FireShot” private sub in Form load event that already added.

![image](https://user-images.githubusercontent.com/91496800/139964889-4db28aae-ec57-4915-b106-05cdbb36d0fa.png)

###### Invaders Backend Code Description
1. Adding the following variables:
- “InvaderSpeed” variable in Dim Statement as Integer type to determine how fast the invader moving.
- “InvaderDrop” variable in Dim Statement as Integer type.
- “IRight” variable in Dim Statement as Boolean Type to determine the invaders moving direction to the Right or the left.
- “NumOfInvaders” variable in Const statement with integer type to define the number of the invaders will be loaded when start the game
- “Invaders” variable in Dim statement as PictureBox type.
- “X” variable in Dim statement as integer.
- “ShotDown” variable in Dim statement as integer which show the number of invaders that shotted down.
- “Paused” in Dim Statement as Boolean Type as Boolean.

![image](https://user-images.githubusercontent.com/91496800/139965023-08a95941-c161-4812-8ccf-26ca52877ba3.png)

2. Adding “LoadInvaders” Private sub that contains For Next Loop to load the invader image from the app ‎resources with the same number that determined in “NumOfInvaders” variable.

![image](https://user-images.githubusercontent.com/91496800/139965067-a4e89089-1c64-4f66-b958-543576d9b00d.png)

3. Adding “MoveInvader” private sub to clarify the invaders Animation. So, that when the form loaded, the invaders move to the right and when the invaders reach the right border of the window, it will move down to the left.

![image](https://user-images.githubusercontent.com/91496800/139965104-250a5318-b825-4376-b256-4ab5cfb892d6.png)

4. Calling “MoveInvader” Private sub in Timermain_Tick Event.

![image](https://user-images.githubusercontent.com/91496800/139965144-26913790-e078-4ab9-bea5-b626cf78de2d.png)

5. Adding the Variables (InvaderSpeed, InvaderDrop) to “LoadSetting” private sub and defining (IRight and X) in (For next loop).

![image](https://user-images.githubusercontent.com/91496800/139965206-04ebc1af-8e70-4195-8d78-758eb4fd1eb3.png)

6. Adding “CheckGameOver” Private Sub, so if all the invaders are not shot, the "Game Over" notification will be displayed.

![image](https://user-images.githubusercontent.com/91496800/139965239-df9176ed-fe71-4ecb-8aa5-ed50d263bc4b.png)

7. Adding “CheckHit” Private Sub which clarifies how to shoot the invaders so that if the shot passes through the invader, the invader will disappear and if all the invaders are killed the "Earth is Saved" Notification will be displayed.

![image](https://user-images.githubusercontent.com/91496800/139965271-42261444-4ead-415a-9689-2ae81dab8423.png)

8. Calling “CheckGameOver” Private sub and “CheckHit” Private sub in Timermain_Tick Event. 

![image](https://user-images.githubusercontent.com/91496800/139965315-d78a81ba-d58d-40f4-ad19-960134a06cbd.png)

9. Adding “Playagain” Private sub to display the message “Play Again”.

![image](https://user-images.githubusercontent.com/91496800/139965366-0f7f7e5d-cedf-4fa6-89a6-b8580a2d5522.png)

10. Adding KeyPress Event to pause the game when the user clicks P.

![image](https://user-images.githubusercontent.com/91496800/139965417-f8b6d5b1-8627-4e69-ae3f-c8e707a52ab2.png)

### CS50 Fianl Project Outcomes and Beanfits
1. Gain more technical skills.
2. improve my creativity and and problem solving skills.
3. help me to understand the technology more.
4. Promotes my logical thinking.
5. Develop my persistence and patiance and resilience
6. May improve my career prospects and give my more oppourtinties.
