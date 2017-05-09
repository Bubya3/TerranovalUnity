using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelup : MonoBehaviour
{

    public AudioSource AudioLevelUp;
    public GameObject lvlText;
    public Animation lvlupfade;


    // Use this for initialization
    void Start()
    {
        lvlText.SetActive(false);
        lvlupfade = lvlText.GetComponent<Animation>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void levelupsound()
    {
        AudioLevelUp.Play(44100);
        lvlText.SetActive(true);
        lvlupfade.Play();







    }

}

