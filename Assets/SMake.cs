using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMake : MonoBehaviour
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
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(SWood);
            newpipe.transform.position = new Vector2(Random.Range(4,-6),-3.217f);
            timer =0;
        }
    }
}
