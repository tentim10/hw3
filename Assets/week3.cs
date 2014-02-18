using UnityEngine;
using System.Collections;

public class week3 : MonoBehaviour {

	// Use this for initialization

	string currentRoom = "home";
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "TEXT ADVENTURE: you are in the " + currentRoom;

		if (currentRoom == "home"){
			textBuffer +="\nYou are in your home. isn't much to do here atm....";
			textBuffer +="\nPress [W] to outside";
			
			if(Input.GetKeyDown(KeyCode.W)){
				currentRoom = "homeFront";
				
			}//end if

		}//end if



		else if (currentRoom == "homeFront"){

			textBuffer += "\nYou are outside your home";
			textBuffer +="\nPress [S] to go back in";
			textBuffer +="\nPress [D] to go to the tidal seas";
			textBuffer +="\nPress [A] to go to seasonal seas";
			textBuffer +="\nPress [W] to go to the artic seas";


			if(Input.GetKeyDown(KeyCode.W)){
				currentRoom = "artic";
				
			}//end if

			else if(Input.GetKeyDown(KeyCode.S)){
				currentRoom = "home";
				
			}//end if

			else if(Input.GetKeyDown(KeyCode.A)){
				currentRoom = "seasonal";
				
			}//end if

			else if(Input.GetKeyDown(KeyCode.D)){
				currentRoom = "tidal";
				
			}//end if


		}//end if


		else if (currentRoom == "artic"){
			textBuffer += "\n These are the artic seas some of the most brutal seas on earth";
			textBuffer += "\n mamals stuggle to live here during the winter as they have to survive on their built up fat";
			textBuffer += "\n they must stay in 1 location breathing out of holes they sustain in the ice";
			textBuffer += "\n staying in 1 place makes them very vulnerable to land based predators like polar bears";
			textBuffer += "\n polar bears are very eager to jump in and grab a meal of a beluga whale";
			textBuffer += "\n (look it up this is real)";
			textBuffer += "\n press [S] to go back to your yard";

			
			if(Input.GetKeyDown(KeyCode.S)){
				currentRoom = "homeFront";
				
			}//end if



		}//end artic

		else if (currentRoom == "seasonal"){
			textBuffer += "\n these are the seasonal seas";
			textBuffer += "\n the seasonal seas have strong storms in the winter that create a brew of plankton";
			textBuffer += "\n the plankton rise to the top and make the sea green in the spring";
			textBuffer += "\n this is the food that sustains the sea until the next winter";
			textBuffer += "\n this beautiful ebb and flow is what the seasonal seas is all about";
			textBuffer += "\n press [S] to go back to your yard";
			
			
			if(Input.GetKeyDown(KeyCode.S)){
				currentRoom = "homeFront";
				
			}//end if

		}//end seasonal

			else if (currentRoom == "tidal"){
				textBuffer += "\n these are the tidal seas";
				textBuffer += "\n these seas have some of the most odd behaviors in the sea";
				textBuffer += "\n some fish mate on land resulting in their death";
				textBuffer += "\n sea turtles lay their eggs in the sand in mass numbers";
				textBuffer += "\n they coordinate their egg laying on certain island at certain times";
				textBuffer += "\n the eggs hatch all together and for days the sand on these shores can not be seen";
				textBuffer += "\n it is just a mass movement of baby turtles for days";
				textBuffer += "\n (this is real, look it up)";


				textBuffer += "\n press [S] to go back to your yard";
				
				
				if(Input.GetKeyDown(KeyCode.S)){
					currentRoom = "homeFront";
					
				}//end if

			}//end else if


		GetComponent<TextMesh>().text = textBuffer;
	
	


	}//end update
}
