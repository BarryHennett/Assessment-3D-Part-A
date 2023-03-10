using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reset : MonoBehaviour
{
    public float threshold = -20f;
    public float endTime;

    void Update()
    {
        if(transform.position.y < threshold)
        {
            scenes();
        }
    }

    private void scenes()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
