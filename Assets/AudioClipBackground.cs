using UnityEngine;
using System.Collections;
using Devdog.General;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioClipBackground : MonoBehaviour
{

    public AudioSource Audio1;
    public AudioSource Audio2;
    public AudioSource Audio3;
    public AudioSource Audio4;
    public AudioSource Audio5;
    public AudioSource Audio6;
    public AudioSource Audio7;
    public AudioSource Audio8;
    public int RandSound;

    // Use this for initialization
    void Start()
    {

        



    }


    // Update is called once per frame
    void Update()
    {
        if (Audio1.isPlaying == false & (Audio2.isPlaying == false & (Audio3.isPlaying == false & (Audio4.isPlaying == false & (Audio5.isPlaying == false & (Audio6.isPlaying == false) & (Audio7.isPlaying == false))))))
        {

                Soundstart();

        }

    }

    public void Soundstart()
    {


        RandSound = Random.Range(1, 7);

        if (RandSound == 1)
        {
            Sound1();
        }
        if (RandSound == 2)
        {
            Sound2();
        }
        if (RandSound == 3)
        {
            Sound3();
        }
        if (RandSound == 4)
        {
            Sound4();
        }
        if (RandSound == 5)
        {
            Sound5();
        }
        if (RandSound == 6)
        {
            Sound6();
        }


    }

    public void StopAllAudio()
    {
        AudioSource[] audios = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource aud in audios)
            aud.Stop();
    }

    void Sound1()
    {

        Audio1.Play(44100);
    }

    void Sound2()
    {

        Audio2.Play(44100);
    }
    void Sound3()
    {

        Audio3.Play(44100);
    }
    void Sound4()
    {

        Audio4.Play(44100);
    }
    void Sound5()
    {

        Audio5.Play(44100);
    }
    void Sound6()
    {

        Audio6.Play(44100);
    }

    public void dungeon1()
    {
        StopAllAudio();
        Audio7.Play(44100);
    }
    public void Picksound()
    {
        if (Audio8.isPlaying)
        {
        }
        else
        {
            Audio8.Play(44100);
        }

    }
    public void PickStop()
    {
        Audio8.Stop();
    }
}
