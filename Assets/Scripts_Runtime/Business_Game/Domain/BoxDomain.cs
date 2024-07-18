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

        box.id=ctx.gameEntity.boxRecordID;
        ctx.gameEntity.boxRecordID++;
        ctx.boxRepository.Add(box);

        return box;
    }
}