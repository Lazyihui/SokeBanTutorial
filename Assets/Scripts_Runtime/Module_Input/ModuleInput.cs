using System;
using UnityEngine;

public class ModuleInput {
    public Vector2 moveDir;


    public void ProcessMove() {
        Vector2 moveAxis = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            moveAxis = Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            moveAxis = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            moveAxis = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            moveAxis = Vector2.down;
        }
        moveAxis.Normalize();
        this.moveDir = moveAxis;
    }
}