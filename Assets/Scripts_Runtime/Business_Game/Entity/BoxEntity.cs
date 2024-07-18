using System;
using UnityEngine;

public class BoxEntity : MonoBehaviour{
    public int id;

    public void Ctor(){
    }

    public void SetPos(Vector3 pos){
        transform.position = pos;
    }
    
}