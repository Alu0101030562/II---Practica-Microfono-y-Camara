using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public WebCamTexture webcamTexture;
    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        for (int i = 0; i < devices.Length; i++)
            Debug.Log(devices[i].name);

        webcamTexture = new WebCamTexture();
        webcamTexture.Play();

        Renderer renderer = GetComponent<Renderer>();

        if (webcamTexture.isPlaying)
            renderer.material.mainTexture = webcamTexture;
        
    }

    // Update is called once per frame
    void OnGUI()
    {
        if (webcamTexture.isPlaying)
            if (GUILayout.Button("Stop", GUILayout.Width(100), GUILayout.Height(50)))
            {
                webcamTexture.Stop();

                Debug.Log("apagada");
            }
        if (webcamTexture.isPlaying)
            if (GUILayout.Button("Play", GUILayout.Width(100), GUILayout.Height(50)))
            {
                webcamTexture.Play();
                Debug.Log("Encendida");
            }
        if (webcamTexture.isPlaying)
            if (GUILayout.Button("Pause", GUILayout.Width(100), GUILayout.Height(50)))
            {
                webcamTexture.Pause();
                Debug.Log("Pausa");
                
            }
        if (!webcamTexture.isPlaying)
            if (GUILayout.Button("Play", GUILayout.Width(100), GUILayout.Height(50)))
            {
                webcamTexture.Play();
                Debug.Log("Encendida");
            }

    }
}
