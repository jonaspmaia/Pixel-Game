﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int totalScore;

    public static GameController instance;

    void Start()
    {
        instance = this;
    }
}
