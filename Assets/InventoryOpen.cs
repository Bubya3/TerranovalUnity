using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryOpen : MonoBehaviour {

    [SerializeField]
    private GameObject hotbar;
    [SerializeField]
    private GameObject invent;
    [SerializeField]
    private GameObject armor;
    [SerializeField]
    private Text hotbarText;
    [SerializeField]
    private Text inventText;
    [SerializeField]
    private Text armorText;



    // Use this for initialization
    void Start () {

        hotbar.SetActive(true);
        invent.SetActive(false);
        armor.SetActive(false);
        //hotbarText.enabled = true;
        //inventText.enabled = false;

    }
	
	// Update is called once per frame
	void Update () {

        ToggleInv();
	}
    public void ToggleInv()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            if (hotbar.activeInHierarchy)
            {
                hotbar.SetActive(false);
                invent.SetActive(true);
                armor.SetActive(true);
               // hotbarText.enabled = false;
             //   inventText.enabled = true;


                GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;


            }
            else
            {
                hotbar.SetActive(true);
                invent.SetActive(false);
                armor.SetActive(false);
                //hotbarText.enabled = true;
                //inventText.enabled = false;

                GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = true;
                Cursor.visible = false;

            }
        }
    }
}
