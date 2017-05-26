using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMove : MonoBehaviour {
    public GameObject BridgeObject;
    public float speed;
    public GameObject target;

    public BridgeMove(GameObject obj, GameObject target)
    {
        this.BridgeObject = obj;
        speed = 1;
        this.target = target;

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //transform.Translate(0, 0, -18, BridgeObject.transform);
            BridgeObject.transform.position = Vector3.Lerp(BridgeObject.transform.position, this.target.transform.position, this.speed);
            Destroy(gameObject);
        }
    }
}
