﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skip : MonoBehaviour {

	public void BtnOnSkip()
    {
        //main : 0
        SceneManager.LoadScene(1);
    }
}
