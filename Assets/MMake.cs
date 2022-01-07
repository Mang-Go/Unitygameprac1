using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMake : MonoBehaviour
{
    public GameObject MWood;
    public float timeDiff;
    float timer = 0;
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
            GameObject newpipe = Instantiate(MWood);
            newpipe.transform.position = new Vector2(Random.Range(2,-3),-2.9218f);
            timer =0;
        }
        
    }
}
