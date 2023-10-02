using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    private MeshRenderer mr;

    void Start(){
        mr = GetComponent<MeshRenderer>();
    }
    
    public void toggleVisible(){
        mr.enabled ^= true;
    }
}
