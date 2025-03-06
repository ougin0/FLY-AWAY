using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchtest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
              if(Input.touchCount>0){
        Touch T = Input.GetTouch(0);
        if (T.phase == TouchPhase.Began){
            Debug.Log("work");
        }
            
        }
    
        
    }
}
