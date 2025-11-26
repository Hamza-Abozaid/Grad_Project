using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class StartTimer : MonoBehaviour
{
    public AudioClip intro_clip;

    public UnityEvent OnClipEnded;

    public void DelayStarting()
    {
        StartCoroutine(StartDelay());
    }

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(intro_clip.length);
        OnClipEnded.Invoke();
    }
}
