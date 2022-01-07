using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGen : MonoBehaviour
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
        if (timer>timeDiff)
        {
            GameObject newWood = Instantiate(BWood);
            newWood.transform.position= new Vector3(Random.Range(0,2.5f),-2.59f,0);
            timer = 0;
            Destroy(newWood,5.0f);
        }
    }
}
