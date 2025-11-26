using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int counter = 0;
    public int requiredtowin;
    public TextMeshProUGUI counter_txt;

    public AudioSource machine_audio;
    public AudioSource conveyor_audio;
    public AudioSource warning_audio;

    public UnityEvent GameEnd;


    private void Start() {

        counter_txt.text = counter.ToString() + " / " + requiredtowin.ToString();
    }

    public void Add() 
    {
        counter ++;

        counter_txt.text = counter.ToString() + " / " + requiredtowin.ToString();

        if (counter >= requiredtowin) 
        {
            GameEnd.Invoke();
        }
    }

    public void Rsetart()
    {
        SceneManager.LoadScene(0);
    }

    public void InvokeConveyorAudio()
    {
        StartCoroutine(StartConveyorAudio());
    }

    IEnumerator StartConveyorAudio()
    {
        yield return new WaitForSeconds(machine_audio.clip.length - 0.5f);
        conveyor_audio.Play();
    }

}
