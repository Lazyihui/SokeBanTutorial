using System;
using UnityEngine;

public class ModuleInput {
    public Vector2 moveDir;


    public void ProcessMove() {
        Vector2 moveAxis = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow)) {
            moveAxis = Vector2.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            moveAxis = Vector2.left;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            moveAxis = Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            moveAxis = Vector2.down;
        }
        this.moveDir = moveAxis;
    }
}