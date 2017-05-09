using UnityEngine;
using System.Collections;

public class ironrock : MonoBehaviour {

    public AudioSource pickrocksound;

	// Use this for initialization
	void Start () {

        pickrocksound = this.GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void onTriggerStay(Collision player)
    {
        if (player.gameObject.tag == "Player")
        {
           picksound();
            //if(Input.GetKeyDown(KeyCode.E))
            {
               // picksound();
            }
        }
        else
        {

        }
    }

    public void picksound()
    {
        if(pickrocksound.isPlaying == false)
        {
            pickrocksound.Play(44100);
        }
        else
        {

        }

    }
    void onTriggerExit(Collision player)
    {
        pickrocksound.Stop();
    }



}
