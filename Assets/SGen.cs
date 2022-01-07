using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGen : MonoBehaviour
{
    public GameObject SWood;
    public float timeDiff;
    float timer =0;
    
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
            GameObject newWood = Instantiate(SWood);
            newWood.transform.position= new Vector3(Random.Range(0.5f,4.2f),-3.2f,0);
            timer = 0;
        }
    }
}
