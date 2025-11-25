using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    public int counter = 0;
    public int requiredtowin;
    public TextMeshProUGUI counter_txt;
    public UnityEvent GameEnd;


    private void Start() {

        counter_txt.text = counter.ToString() + " / " + requiredtowin.ToString();
    }

    public void Add() 
    {
        counter += 1;

        counter_txt.text = counter.ToString() + " / " + requiredtowin.ToString();

        if (counter >= requiredtowin) 
        {
            GameEnd.Invoke();
        }
    }

}
