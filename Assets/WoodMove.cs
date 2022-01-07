using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodMove : MonoBehaviour
{
    public GameObject MWood;
    public float timeDiff;
    float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>timeDiff)
        {
            GameObject newWood = Instantiate(MWood);
            newWood.transform.position = new Vector3();
            timer =0;
        }
    }
}
