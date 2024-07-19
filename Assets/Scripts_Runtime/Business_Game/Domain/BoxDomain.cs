using System;
using UnityEngine;

public static class BoxDomain {
    public static BoxEntity Spawn(GameContext ctx, Vector3 pos) {

        bool has = ctx.assets.TryGetEntity("BoxEntity", out GameObject prefab);
        if (!has) {
            Debug.LogError("Box_Entity not found");
            return null;
        }
        GameObject go = GameObject.Instantiate(prefab);
        BoxEntity box = go.GetComponent<BoxEntity>();
        box.Ctor();
        box.SetPos(pos);

        box.id = ctx.gameEntity.boxRecordID;
        ctx.gameEntity.boxRecordID++;
        ctx.boxRepository.Add(box);

        return box;
    }


    public static bool CanMoveToDir(GameContext ctx, Vector2 dir, BoxEntity box) {

        PlayerEntity player = ctx.playerRepository.Find(x => x.id == ctx.gameEntity.playerRecordID - 1);

        RaycastHit2D hit = Physics2D.Raycast(box.transform.position + (Vector3)dir * 0.5f, dir, 1.5f);
        Debug.DrawLine(box.transform.position, box.transform.position + (Vector3)dir * 0.5f, Color.red, 1);

        if (!hit&&player.isTouchBox) {
            player.boxPlayerCanMove = true;
            Move(box, dir);
            return true;
        } else {
            player.boxPlayerCanMove = false;
            return false;
        }

    }

    // RaycastHit2D hit = Physics2D.Raycast(box.transform.position + (Vector3)dir * 0.5f, dir, 0.5f);
    // Debug.DrawLine(box.transform.position, box.transform.position + (Vector3)dir * 0.5f, Color.red, 1);
    // if (!hit) {
    //     // 要改
    //     Move(box, dir);
    //     return true;
    // } else {
    //     return false;
    // }
    static void Move(BoxEntity box, Vector2 dir) {
        Debug.Log("Move");
        box.Move(dir);
    }
}

// 