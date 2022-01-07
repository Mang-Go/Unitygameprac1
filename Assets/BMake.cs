using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMake : MonoBehaviour
{
    public GameObject BWood;
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
            GameObject newpipe = Instantiate(BWood);
            newpipe.transform.position = new Vector2(Random.Range(6,-24),-2.5487f);
            timer =0;
        }
    }
}
