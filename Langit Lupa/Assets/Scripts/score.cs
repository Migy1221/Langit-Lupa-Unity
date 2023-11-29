using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    void OnTriggerEnter(Collider other)
    {

        scoreText.GetComponent<Text>().text = "SCORE: " + theScore;

    }
}
