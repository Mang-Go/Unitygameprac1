using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGen : MonoBehaviour
{
    public GameObject MWood;
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
            GameObject newWood = Instantiate(MWood);
            newWood.transform.position= new Vector3(Random.Range(1.4f,3.8f),-2.9f,0);
            timer = 0;
            Destroy(newWood,10.0f);
        }


    }
}
