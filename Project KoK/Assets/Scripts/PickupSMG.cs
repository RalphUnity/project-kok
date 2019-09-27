﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupSMG : MonoBehaviour
{
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TextDisplay;

    public GameObject FakeGun;
    public GameObject RealGun;
    public GameObject AmmoDisplay;
    public AudioSource PickUpAudio;

    public GameObject ObjectiveComplete;

    public GameObject Mechanics;

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Take SMG";
        }
        else
        {
            TextDisplay.GetComponent<Text>().text = "";
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                StartCoroutine(TakeNineMil());
                Mechanics.SetActive(true);
                ObjectiveComplete.SetActive(true);
            }
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator TakeNineMil()
    {
        PickUpAudio.Play();
        transform.position = new Vector3(0, -1000, 0);
        FakeGun.SetActive(false);
        RealGun.SetActive(true);
        AmmoDisplay.SetActive(true);
        yield return new WaitForSeconds(0.1f);
    }
}
