﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour
{

    public GameObject ThePlayer;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        
    }
}
