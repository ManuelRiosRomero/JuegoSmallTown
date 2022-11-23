using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectedHorseShoe : MonoBehaviour
{
    public CharacterController2D charController2d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        charController2d.horseShoe = true;
        Destroy(gameObject);
    }
}

