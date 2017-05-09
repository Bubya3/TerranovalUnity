using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class experiencetracking : MonoBehaviour
{

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

    public float xpFloor;

    public Text txtAccuracy;
    public Text txtArchery;
    public Text txtCrafting;
    public Text txtDamage;
    public Text txtDefence;
    public Text txtHealth;
    public Text txtHorticulture;
    public Text txtHusbandry;
    public Text txtImbuing;
    public Text txtMagic;
    public Text txtMetallurgy;
    public Text txtSpeech;
    public Text txtStamina;
    public Text txtSwordship;
    public Text txtTracking;

    public Text txtAccuracyLvl;
    public Text txtArcheryLvl;
    public Text txtCraftingLvl;
    public Text txtDamageLvl;
    public Text txtDefenceLvl;
    public Text txtHealthLvl;
    public Text txtHorticultureLvl;
    public Text txtHusbandryLvl;
    public Text txtImbuingLvl;
    public Text txtMagicLvl;
    public Text txtMetallurgyLvl;
    public Text txtSpeechLvl;
    public Text txtStaminaLvl;
    public Text txtSwordshipLvl;
    public Text txtTrackingLvl;

    // Use this for initialization
    void Start()
    {
        xpFloor = 83.4f;
        xpAccuracy = 0.0f;
        xpArchery = 0.0f;
        xpCrafting = 0.0f;
        xpDamage = 0.0f;
        xpDefence = 0.0f;
        xpHealth = 0.0f;
        xpHorticulture = 0.0f;
        xpHusbandry = 0.0f;
        xpImbuing = 0.0f;
        xpMagic = 0.0f;
        xpMetallurgy = 0.0f;
        xpSpeech = 0.0f;
        xpStamina = 0.0f;
        xpSwordship = 0.0f;
        xpTracking = 0.0f;

        lvlAccuracy = 1.0f;
        lvlArchery = 1.0f;
        lvlCrafting = 1.0f;
        lvlDamage = 1.0f;
        lvlDefence = 1.0f;
        lvlHealth = 1.0f;
        lvlHorticulture = 1.0f;
        lvlHusbandry = 1.0f;
        lvlImbuing = 1.0f;
        lvlMagic = 1.0f;
        lvlMetallurgy = 1.0f;
        lvlSpeech = 1.0f;
        lvlStamina = 1.0f;
        lvlSwordship = 1.0f;
        lvlTracking = 1.0f;

    }

    // Update is called once per frame
    void Update()
    {

        XpToString();
        MetallurgyLevel();
    }

    private void XpToString()
    {
        txtAccuracy.text = xpAccuracy.ToString("F0");
        txtArchery.text = xpArchery.ToString("F0");
        txtCrafting.text = xpCrafting.ToString("F0");
        txtDamage.text = xpDamage.ToString("F0");
        txtDefence.text = xpDefence.ToString("F0");
        txtHealth.text = xpHealth.ToString("F0");
        txtHorticulture.text = xpHorticulture.ToString("F0");
        txtHusbandry.text = xpHusbandry.ToString("F0");
        txtImbuing.text = xpImbuing.ToString("F0");
        txtMagic.text = xpMagic.ToString("F0");
        txtMetallurgy.text = xpMetallurgy.ToString("F0");
        txtSpeech.text = xpSpeech.ToString("F0");
        txtStamina.text = xpStamina.ToString("F0");
        txtSwordship.text = xpSwordship.ToString("F0");
        txtTracking.text = xpTracking.ToString("F0");

        txtAccuracyLvl.text = lvlAccuracy.ToString("F0");
        txtArcheryLvl.text = lvlArchery.ToString("F0");
        txtCraftingLvl.text = lvlCrafting.ToString("F0");
        txtDamageLvl.text = lvlDamage.ToString("F0");
        txtDefenceLvl.text = lvlDefence.ToString("F0");
        txtHealthLvl.text = lvlHealth.ToString("F0");
        txtHorticultureLvl.text = lvlHorticulture.ToString("F0");
        txtHusbandryLvl.text = lvlHusbandry.ToString("F0");
        txtImbuingLvl.text = lvlImbuing.ToString("F0");
        txtMagicLvl.text = lvlMagic.ToString("F0");
        txtMetallurgyLvl.text = lvlMetallurgy.ToString("F0");
        txtSpeechLvl.text = lvlSpeech.ToString("F0");
        txtStaminaLvl.text = lvlStamina.ToString("F0");
        txtSwordshipLvl.text = lvlSwordship.ToString("F0");
        txtTrackingLvl.text = lvlTracking.ToString("F0");
    }

    public void MetallurgyLevel()
    {
        float lvlmodifier = 1.05f;

        float NextXp = Mathf.Pow(xpFloor, lvlmodifier);

        if (xpMetallurgy > NextXp)
        {
            lvlMetallurgy = lvlMetallurgy + 1;
        }

        if (lvlMetallurgy < 20)
        {
            lvlmodifier = 1.05f;
        }
        if (lvlMetallurgy >= 20 && lvlMetallurgy < 50)
        {
            lvlmodifier = 1.17f;
        }
        if (lvlMetallurgy >= 50 && lvlMetallurgy < 86)
        {
            lvlmodifier = 1.33f;
        }
        if (lvlMetallurgy >= 86)
        {
            lvlmodifier = lvlmodifier * 1.06f;
        }

    }
}
        
