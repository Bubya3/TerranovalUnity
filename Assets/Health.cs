using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    [SerializeField]
    private float TotalHealth;
    [SerializeField]
    private float CurrentHealth;
    [SerializeField]
    private float Healthpercentage;
    [SerializeField]
    private Image healtBarSprite;

    [SerializeField]
    private float NextXp;
    [SerializeField]
    private float NextStackXp;
    [SerializeField]
    private float CurrentXp;
    [SerializeField]
    private float TotalXp;
    [SerializeField]
    private float CurrentLevel;
    [SerializeField]
    private float XpPercentage;
    [SerializeField]
    private Image xpBarSprite;
    [SerializeField]
    private Text leveltxt;

    [SerializeField]
    private float lvlmodifier;

    [SerializeField]
    private Text txtCurHealth;
    [SerializeField]
    private Text txtCurXp;

    [SerializeField]
    private GameObject audicontrol;
    [SerializeField]
    private Text lvlUptext;




    // Use this for initialization
    void Start () {

        TotalHealth = 100.0f;
        CurrentHealth = TotalHealth;

        NextXp = 83.4f;
        CurrentXp = 0.0f;
        TotalXp = 0;
        CurrentLevel = 1;
        leveltxt.text = CurrentLevel.ToString();
        lvlmodifier = 1.05f;


        InvokeRepeating("healthcheck", 1.0f, 0.25f);
        InvokeRepeating("backgroundXp", 1.0f, 0.033f);

    }
	
	// Update is called once per frame
	void Update () {

        healthBar();
        XpBar();


    }

    public void healthBar()
    {
        Healthpercentage = CurrentHealth / TotalHealth;
        healtBarSprite.fillAmount = Healthpercentage;
        txtCurHealth.text = CurrentHealth.ToString("F1") + "/" + TotalHealth.ToString("F1");
    }
    public void healthcheck()
    {
        if (CurrentHealth < TotalHealth)
        {
            CurrentHealth = CurrentHealth + (0.0025f * TotalHealth);
        }
        
    }
    public void XpBar()
    {
        XpPercentage = CurrentXp / NextXp;
        xpBarSprite.fillAmount = XpPercentage;
        txtCurXp.text = CurrentXp.ToString("F1") + "/" + NextXp.ToString("F1");
    }
    public void backgroundXp()
    {
        if(CurrentXp < NextXp)
        {
            CurrentXp = CurrentXp + 0.011f;
            TotalXp = TotalXp + 0.011f;
        }
        else
        {
            audicontrol.GetComponent<levelup>().levelupsound();
            CurrentLevel++;
            CurrentXp = 0;
            NextXp = Mathf.Pow(NextXp, lvlmodifier);

            if(CurrentLevel < 20)
            {
                lvlmodifier = 1.05f;
            }
            if (CurrentLevel >= 20 && CurrentLevel < 50)
            {
                lvlmodifier = 1.17f;
            }
            if (CurrentLevel >= 50 && CurrentLevel < 86)
            {
                lvlmodifier = 1.33f;
            }
            if (CurrentLevel >= 86)
            {
                lvlmodifier = lvlmodifier * 1.06f;
            }

            leveltxt.text = CurrentLevel.ToString();
        }
    }

}
