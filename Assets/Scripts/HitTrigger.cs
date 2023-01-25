using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrigger : MonoBehaviour
{
    [SerializeField] GameObject theBall;
    [SerializeField] GameObject theBlock;
    void OnHitDestroy(Collision col)
    {
        if(col.gameObject.name == "ball"||col.gameObject.name =="ball(clone)")
        {
            Destroy(theBlock);
            Debug.Log("Collision detected");
        }
    }
}
