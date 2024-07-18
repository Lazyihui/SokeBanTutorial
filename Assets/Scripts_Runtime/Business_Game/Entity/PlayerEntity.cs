using System;
using UnityEngine;

public class PlayerEntity : MonoBehaviour{
    public int id;

    public Vector2 moveDir;


    public void Ctor(){
    }

    public void SetPos(Vector3 pos){
        transform.position = pos;
    }
    

}