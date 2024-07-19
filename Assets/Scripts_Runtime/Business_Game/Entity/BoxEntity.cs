using System;
using UnityEngine;

public class BoxEntity : MonoBehaviour {
    public int id;

    public void Ctor() {
    }

    public void SetPos(Vector3 pos) {
        transform.position = pos;
    }

    public void Move(Vector2 dir) {
        Vector2 pos = transform.position;
        pos += dir;
        transform.position = pos;
    }

}