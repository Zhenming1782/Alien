using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void click()
    {
        SceneManager.LoadScene("Juego");
        Balloon.pausa = false;
        ScoreScript.scoreValue = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
