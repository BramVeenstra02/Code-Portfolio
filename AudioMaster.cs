using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMaster : MonoBehaviour
{

    [SerializeField] private AudioSource timerSound;
    [SerializeField] private AudioSource timerfinishSound;
    [SerializeField] private AudioSource buttonpressSound;
    [SerializeField] private AudioSource nextturnSound;
    [SerializeField] private AudioSource winSound;
    [SerializeField] private AudioSource loseSound;
    [SerializeField] private AudioSource taskstartSound;

    public void ButtonPressAudio()
    {
        buttonpressSound.Play(0);
    }

    public void TimerFinishAudio()
    {
        timerfinishSound.Play(0);
    }

    public void LoseAudio()
    {
        loseSound.Play(0);
    }

    public void WinAudio()
    {
        winSound.Play(0);
    }

    public void TimerAudio()
    {
        timerSound.Play(0);
    }

    public void NextTurnAudio()
    {
        nextturnSound.Play(0);
    }

    public void TaskStartAudio()
    {
        taskstartSound.Play(0);
    }
}
