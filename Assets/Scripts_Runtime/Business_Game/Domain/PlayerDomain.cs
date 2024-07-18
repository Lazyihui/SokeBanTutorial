using System;
using UnityEngine;

public static class PlayerDomain {

    public static PlayerEntity Spawn(GameContext ctx,Vector3 pos){

        bool has = ctx.assets.TryGetEntity("PlayerEntity", out GameObject prefab);
        if (!has) {
            Debug.LogError("Player_Entity not found");
            return null;
        }
        GameObject go = GameObject.Instantiate(prefab);
        PlayerEntity player = go.GetComponent<PlayerEntity>();
    
        player.Ctor();
        player.SetPos(pos);
        
        player.id=ctx.gameEntity.playerRecordID;
        ctx.gameEntity.playerRecordID++;
        ctx.playerRepository.Add(player);
        return player;


    }


    public static void SetMoveDir(GameContext ctx,PlayerEntity player,Vector2 dir){
        player.moveDir = dir;
    }
}