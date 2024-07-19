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
        // box.Ctor();
        box.SetPos(pos);

        box.id = ctx.gameEntity.boxRecordID;
        ctx.gameEntity.boxRecordID++;
        ctx.boxRepository.Add(box);

        return box;
    }


    public static bool CanMoveToDir(Vector2 dir, BoxEntity box) {
        RaycastHit2D hit = Physics2D.Raycast(box.transform.position + (Vector3)dir * 0.5f, dir, 0.5f);
        if (!hit) {
            // 要改
            box.transform.Translate(dir);
            return true;
        } else {
            return false;
        }
    }
}