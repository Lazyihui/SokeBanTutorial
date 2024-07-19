using System;
using UnityEngine;

public class PlayerEntity : MonoBehaviour{
    public int id;

    public Vector2 moveDir;

    public LayerMask detectLayer;

    public bool boxPlayerCanMove;

    public bool isTouchBox;
    public void Ctor(){
        isTouchBox = false;
    }

    public void SetPos(Vector3 pos){
        transform.position = pos;
    }
    
    public void Move(Vector2 dir) {
        Vector2 pos = transform.position;
        pos = pos + dir;
        transform.position = pos;
    }

}