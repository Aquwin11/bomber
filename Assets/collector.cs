using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collector : MonoBehaviour  
{
    public int i = 0;
    public Text score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "enemy")
        {
            target.gameObject.SetActive (false);
            i++;
            score.text = "SCORE:" + i;
        }
    }      
}
