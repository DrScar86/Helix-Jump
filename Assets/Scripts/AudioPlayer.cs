using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip AudioClip;
    [Min(0)]
    public float Volume;
    [Min(0)]
    public float Delay;
    private AudioSource _audio;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        _audio.PlayDelayed(Delay);
    }
    private void OnDiseble()
    {
        _audio.Stop();
    }
}
