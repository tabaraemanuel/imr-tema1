using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class DistanceBehaviour : MonoBehaviour
{
    float distance;
    Animator miazaky;
    
    // Start is called before the first frame update
    void Start()
    {
        miazaky = GetComponent<Animator>();
        distance = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        float xpos = Camera.main.transform.position.x;
        float ypos = Camera.main.transform.position.y;
        float x = transform.position.x;
        float y = transform.position.y;
         distance = Mathf.Sqrt(Mathf.Pow((xpos - x),2) + Mathf.Pow((ypos - y),2));
         miazaky.SetFloat("Distance",distance);

    }
}
