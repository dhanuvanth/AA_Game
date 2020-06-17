using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int pinCount;

    public Text score;

    // Update is called once per frame
    void Start()
    {
        pinCount = 0;
    }

    private void Update()
    {
        score.text = pinCount.ToString();
    }
}
