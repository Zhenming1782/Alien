using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public enum gColor
{
    Blue = 0,
    Green,
    Orange,
    Purple,
    Red,
    Yellow
}

public class Balloon : MonoBehaviour
{
    public GameObject balloon;
    public Boolean pausa = true;
    private Dictionary<gColor, Color> colores;

    private Coroutine _coroutine;
    // Start is called before the first frame update
    private void Awake()
    {
        colores = new Dictionary<gColor, Color>
        {
            {gColor.Blue, Color.blue},
            {gColor.Green, Color.green},
            {gColor.Orange, new Color(1,0.4f,0)},
            {gColor.Purple, new Color(0.6f,0,0.6f)},
            {gColor.Red, Color.red},
            {gColor.Yellow, Color.yellow}
        };
    }

    void Start()
    {
        Random.InitState((int)DateTime.Now.Ticks);
        _coroutine = StartCoroutine(coroutine());
    }

    private IEnumerator coroutine()
    {
        while(true) {
            yield return new WaitForSecondsRealtime(Random.Range(1f, 2f));
            if (!pausa)
            {
                GameObject temp = Instantiate(balloon, new Vector3(Random.Range(-7f, 4f), -10f), quaternion.identity);
                if (Random.Range(0, 100f) < 20f)
                {
                    temp.GetComponent<SpriteRenderer>().color = colores[0];
                    temp.GetComponent<Proyectil>().direccion = new Vector3(0, Random.Range(0.15f,0.2f));
                }
                else
                {
                    temp.GetComponent<SpriteRenderer>().color = colores[(gColor) Random.Range(1, 6)];
                    temp.GetComponent<Proyectil>().direccion = new Vector3(0, Random.Range(0.05f,0.1f));
                }
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void Pausa()
    {
        pausa = !pausa;
        Time.timeScale = pausa ? 0 : 1;
    }
}
