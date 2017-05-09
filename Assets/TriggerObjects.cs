using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TriggerObjects : MonoBehaviour {
    public GameObject soundcontroller;

    public Text ObjectText;
    public Text RequriementText;
    public int ObjectID;

    public float lvlAccuracy;
    public float xpAccuracy;

    public float lvlDamage;
    public float xpDamage;

    public float lvlDefence;
    public float xpDefence;

    public float lvlHealth;
    public float xpHealth;

    public float lvlSwordship;
    public float xpSwordship;

    public float lvlArchery;
    public float xpArchery;

    public float lvlMagic;
    public float xpMagic;

    public float lvlMetallurgy;
    public float xpMetallurgy;

    public float lvlCrafting;
    public float xpCrafting;

    public float lvlImbuing;
    public float xpImbuing;

    public float lvlStamina;
    public float xpStamina;

    public float lvlTracking;
    public float xpTracking;

    public float lvlSpeech;
    public float xpSpeech;

    public float lvlHusbandry;
    public float xpHusbandry;

    public float lvlHorticulture;
    public float xpHorticulture;

    // Use this for initialization
    void Start ()
    {


        ObjectText.text = "";
        RequriementText.text = "";
        ObjectID = -1;
    }
	
	// Update is called once per frame
	void Update ()
    {
        lvlAccuracy = GameObject.Find("Data").GetComponent<experiencetracking>().lvlAccuracy;
        lvlArchery = GameObject.Find("Data").GetComponent<experiencetracking>().lvlArchery;
        lvlCrafting = GameObject.Find("Data").GetComponent<experiencetracking>().lvlCrafting;
        lvlDamage = GameObject.Find("Data").GetComponent<experiencetracking>().lvlDamage;
        lvlDefence = GameObject.Find("Data").GetComponent<experiencetracking>().lvlDefence;
        lvlHealth = GameObject.Find("Data").GetComponent<experiencetracking>().lvlHealth;
        lvlHorticulture = GameObject.Find("Data").GetComponent<experiencetracking>().lvlHorticulture;
        lvlHusbandry = GameObject.Find("Data").GetComponent<experiencetracking>().lvlHusbandry;
        lvlImbuing = GameObject.Find("Data").GetComponent<experiencetracking>().lvlImbuing;
        lvlMagic = GameObject.Find("Data").GetComponent<experiencetracking>().lvlMagic;
        lvlMetallurgy = GameObject.Find("Data").GetComponent<experiencetracking>().lvlMetallurgy;
        lvlSpeech = GameObject.Find("Data").GetComponent<experiencetracking>().lvlSpeech;
        lvlStamina = GameObject.Find("Data").GetComponent<experiencetracking>().lvlStamina;
        lvlSwordship = GameObject.Find("Data").GetComponent<experiencetracking>().lvlSwordship;
        lvlTracking = GameObject.Find("Data").GetComponent<experiencetracking>().lvlTracking;

        //define xp
        xpAccuracy = GameObject.Find("Data").GetComponent<experiencetracking>().xpAccuracy;
        xpArchery = GameObject.Find("Data").GetComponent<experiencetracking>().xpArchery;
        xpCrafting = GameObject.Find("Data").GetComponent<experiencetracking>().xpCrafting;
        xpDamage = GameObject.Find("Data").GetComponent<experiencetracking>().xpDamage;
        xpDefence = GameObject.Find("Data").GetComponent<experiencetracking>().xpDefence;
        xpHealth = GameObject.Find("Data").GetComponent<experiencetracking>().xpHealth;
        xpHorticulture = GameObject.Find("Data").GetComponent<experiencetracking>().xpHorticulture;
        xpHusbandry = GameObject.Find("Data").GetComponent<experiencetracking>().xpHusbandry;
        xpImbuing = GameObject.Find("Data").GetComponent<experiencetracking>().xpImbuing;
        xpMagic = GameObject.Find("Data").GetComponent<experiencetracking>().xpMagic;
        xpMetallurgy = GameObject.Find("Data").GetComponent<experiencetracking>().xpMetallurgy;
        xpSpeech = GameObject.Find("Data").GetComponent<experiencetracking>().xpSpeech;
        xpStamina = GameObject.Find("Data").GetComponent<experiencetracking>().xpStamina;
        xpSwordship = GameObject.Find("Data").GetComponent<experiencetracking>().xpSwordship;
        xpTracking = GameObject.Find("Data").GetComponent<experiencetracking>().xpTracking;
        /*
        //define levels
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlAccuracy = lvlAccuracy;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlArchery = lvlArchery;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlCrafting = lvlCrafting;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlDamage = lvlDamage;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlDefence = lvlDefence;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlHealth = lvlHealth;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlHorticulture = lvlHorticulture;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlHusbandry = lvlHusbandry;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlImbuing = lvlImbuing;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlMagic = lvlMagic;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlMetallurgy = lvlMetallurgy;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlSpeech = lvlSpeech;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlSwordship = lvlSwordship;
        GameObject.Find("Data").GetComponent<experiencetracking>().lvlTracking = lvlTracking;

        GameObject.Find("Data").GetComponent<experiencetracking>().xpAccuracy = xpAccuracy;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpArchery = xpArchery;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpCrafting = xpCrafting;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpDamage = xpDamage;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpDefence = xpDefence;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpHealth = xpHealth;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpHorticulture = xpHorticulture;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpHusbandry = xpHusbandry;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpImbuing = xpImbuing;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpMagic = xpMagic;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpMetallurgy = xpMetallurgy;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpSpeech = xpSpeech;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpSwordship = xpSwordship;
        GameObject.Find("Data").GetComponent<experiencetracking>().xpTracking = xpTracking;

    */




        //METALLURGY ROCKS
        if (ObjectID == 0 && Input.GetKeyUp(KeyCode.E) && GameObject.Find("Data").GetComponent<experiencetracking>().lvlMetallurgy >= 1)
        {
            MineRock();
        }

    }
    public void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "iron_ore":
                ObjectText.text = "Iron Ore";
                RequriementText.text = "Metallurgy: 1 (Press E)";
                ObjectID = 0;
                break;
        }
    }
    public void OnTriggerExit(Collider col)
    {
        switch (col.tag)
        {
            case "iron_ore":
                ObjectText.text = "";
                RequriementText.text = "";
                ObjectID = -1;
                soundcontroller.GetComponent<AudioClipBackground>().PickStop();
                break;
        }
    }
    public void MineRock()
    {
        float floor;
        //IronOre
        if(ObjectID == 0)
        {
            floor = 7.5f;
            float attempt = Random.Range(1, 100);
            float result = floor + (attempt * (lvlMetallurgy/1.1f));
            soundcontroller.GetComponent<AudioClipBackground>().Picksound();
            if (result >= 88)
            {
                GameObject.Find("Data").GetComponent<experiencetracking>().xpMetallurgy = GameObject.Find("Data").GetComponent<experiencetracking>().xpMetallurgy + 5;
            }
        }   
    }
}
