using System.Collections;
using UnityEngine;


public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Scores();
    }

    private void Scores()
    {
        GameObject.Find("Ball").SendMessage("finish");
    }
}
