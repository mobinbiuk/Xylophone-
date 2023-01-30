using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xylophone : MonoBehaviour
{

    public AudioClip[] _audioClip;
    private AudioSource _audioSource;
    private void Start()
    {
        Notes.toneName += playsound;
        _audioSource = GetComponent<AudioSource>();

    }
    private void OnDestroy()
    {
        Notes.toneName -= playsound;
    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            for (int i = 0; i < notesT.Length; i++)
            {
                notesT[i].localScale = new Vector3(1, 1, 1);
            }
        }
    }
    public Transform[] notesT;
    public void playsound(string name)
    {
        switch (name)
        {
            case "A":
                _audioSource.PlayOneShot(_audioClip[0]);
                notesT[0].localScale = pos();
                break;
            case "B":
                _audioSource.PlayOneShot(_audioClip[1]);
                notesT[1].localScale = pos();
                break;
            case "C":
                _audioSource.PlayOneShot(_audioClip[2]);
                notesT[2].localScale = pos();
                break;
            case "D":
                _audioSource.PlayOneShot(_audioClip[3]);
                notesT[3].localScale = pos();
                break;
            case "E":
                _audioSource.PlayOneShot(_audioClip[4]);
                notesT[4].localScale = pos();
                break;
            case "F":
                _audioSource.PlayOneShot(_audioClip[5]);
                notesT[5].localScale = pos();
                break;
        }
    }
    private Vector3 pos()
    {
        return new Vector3(0.95f, 0.95f, 0.95f);
    }
}
