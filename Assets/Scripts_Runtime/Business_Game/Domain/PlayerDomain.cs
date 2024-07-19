using System;
using UnityEngine;

public static class PlayerDomain {

    public static PlayerEntity Spawn(GameContext ctx, Vector3 pos) {

        bool has = ctx.assets.TryGetEntity("PlayerEntity", out GameObject prefab);
        if (!has) {
            Debug.LogError("Player_Entity not found");
            return null;
        }
        GameObject go = GameObject.Instantiate(prefab);
        PlayerEntity player = go.GetComponent<PlayerEntity>();

        player.Ctor();
        player.SetPos(pos);

        player.id = ctx.gameEntity.playerRecordID;
        ctx.gameEntity.playerRecordID++;
        ctx.playerRepository.Add(player);
        return player;


    }


    public static void SetMoveDir(GameContext ctx, PlayerEntity player, Vector2 dir) {
        player.moveDir = dir;
        Debug.Log(player.moveDir);
        if (player.moveDir != Vector2.zero) {
            if (CanMoveToDir(player.moveDir, player)) {
                Move(player.moveDir, player);
            }
        }
    }
    static bool CanMoveToDir(Vector2 dir, PlayerEntity player) {
        RaycastHit2D hit = Physics2D.Raycast(player.transform.position, dir, 1, player.detectLayer);
        if (!hit) {
            return true;
        } else {

            if (hit.collider.GetComponent<BoxEntity>()) {
                BoxEntity box = hit.collider.GetComponent<BoxEntity>();
                if (BoxDomain.CanMoveToDir(dir, box)) {
                    return true;
                } else {
                    return false;
                }

            } else {
                return false;
            }

        }
    }
    static void Move(Vector2 dir, PlayerEntity player) {
        player.Move(dir);
    }
}