using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {
    public GameObject DoorObject;

    public OpenDoor(GameObject obj)
    {
        this.DoorObject = obj;
    }
    
    
    public void start()
    {

    }

    public void update()
    {

    }

    public void OnTriggerEnter (Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Animation test; 
            test = DoorObject.GetComponent<Animation>();
            test.Play();
            Destroy(gameObject);
        }
    }
}
