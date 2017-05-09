using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Divination : MonoBehaviour {

    [SerializeField]
    private int DivinationLevel;
    [SerializeField]
    private float DivinationCurrentExperience;
    [SerializeField]
    private float DivinationNextExperience;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        InvokeRepeating("DelayTimers", 0.1f, 1.0f);
    }

                

}

 




