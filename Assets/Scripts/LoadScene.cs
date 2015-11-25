using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public Text updateText;
	public Text connectedPlayers;
	public int numPlayers;

	public NetworkController network;
	public NetworkedPlayer player;

	private bool loading = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (loading == true) {
			updateText.text = "Loading...";
		}

		// maintain a count of players that are connected and currently playing
		if (player.imConnected == true) {
			numPlayers += 1;
			connectedPlayers.text = numPlayers + " connected players";
		} else {

		}
	}

	public void loadScene(){
		Application.LoadLevel (1);
		loading = true;

	}
}
