using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class team : MonoBehaviour {
    internal bool isteam = false;

    internal void setteam(int team)
    {
        if (team == 1)
        GetComponent<Renderer>().material.color = Color.red;
        else
            GetComponent<Renderer>().material.color = Color.blue;
        isteam = true;
    }
}
