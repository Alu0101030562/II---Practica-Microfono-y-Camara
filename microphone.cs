using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microphone : MonoBehaviour
{

    public AudioClip _audioClip;
    public bool _useMicrophone;
    public string _selectedDevice;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
        AudioSource audioSource = GetComponent<AudioSource>();

        //Microphone input

        if (_useMicrophone)
        {
            if (Microphone.devices.Length > 0)
            {
                _selectedDevice = Microphone.devices[1].ToString();
                audioSource.clip = Microphone.Start(_selectedDevice, true, 10, 44100);
            }
            else
            {
                _useMicrophone = false;
            }
        }
        audioSource.Play();
    }

    // Update is called once per frame
    void OnGUI()
    {
            if (GUI.Button(new Rect(0, 200, 200, 50), "Finalizar Grabacion"))
            {
                Microphone.End(_selectedDevice);

                Debug.Log("final grabacion");
            }
    }
}
