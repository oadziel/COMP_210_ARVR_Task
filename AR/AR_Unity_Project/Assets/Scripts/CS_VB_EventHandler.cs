using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CS_VB_EventHandler : MonoBehaviour
{
    [SerializeField] private GameObject[] VLights;
    [SerializeField] private AudioSource aud;
    [SerializeField] private AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnLightPressed()
    {
        Debug.Log("VB Pressed");
        foreach(GameObject Vlight in VLights)
        {
            if (Vlight.activeSelf == true)
            {
                Vlight.SetActive(false);
            }
            else
            {
                Vlight.SetActive(true);
            }
        }
    }

    public void OnHornPressed()
    {
        aud.PlayOneShot(clip, 1);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
