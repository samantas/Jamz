using UnityEngine;
using System.Collections;

public class AnimateDrums : Photon.MonoBehaviour {

	protected Animator MyAnimator;

	// Use this for initialization
	void Start () {
			
	}

	protected void Awake(){
		MyAnimator = GetComponent<Animator> ();
		if(!MyAnimator) Debug.LogError("Animator Component Not Found");
	}
	
	// Update is called once per frame
	protected void Update () {

	}

	public void hitMe(){

//		MyAnimator.SetTrigger ("playerHitMe");
//		Debug.Log ("playerHitMe triggered");
		photonView.RPC ("hitAll", PhotonTargets.All, null);

	}

	[PunRPC]
	public void hitAll(){
		MyAnimator.SetTrigger ("playerHitMe");
		Debug.Log ("playerHitMe triggered");
	}
	
}



// FOR REFERENCE ONLY
//public void PlaySound(AudioClip clip){
//	
//	stringclip = clip.ToString();
//	Debug.Log (stringclip);
//	
//	photonView.RPC("PlaySoundHandler",PhotonTargets.All, null);
//	
//	//explosions
//	photonView.RPC("DoExploder",PhotonTargets.All, new object[]{15});
//}


