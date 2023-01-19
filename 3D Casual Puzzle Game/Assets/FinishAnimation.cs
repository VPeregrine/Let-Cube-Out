using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishAnimation : MonoBehaviour
{
    public GameObject gm;
    public string NameAnimation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gm.GetComponent<Animation>().Play(NameAnimation);
        }
    }
}
