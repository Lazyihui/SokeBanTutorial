using System;
using UnityEngine;

public static class Game_Business {
    public static void New_Game(GameContext ctx) {
        // 生成箱子

        BoxDomain.Spawn(ctx, new Vector3(-3.5f, 1.5f, 0));
        BoxDomain.Spawn(ctx, new Vector3(0.5f, 1.5f, 0));
        BoxDomain.Spawn(ctx, new Vector3(-0.5f, 2.5f, 0));

        PlayerDomain.Spawn(ctx, new Vector3(-3.5f, -0.5f, 0));
    }

    public static void Load_Game(GameContext ctx) {

    }
    public static void UnLoad_Game(GameContext ctx) {

    }

    public static void Tick(GameContext ctx, float dt) {


        PreTick(ctx, dt);

        ref float restFixTime = ref ctx.gameEntity.restFixTime;

        restFixTime += dt;
        const float FIX_INTERVAL = 0.020f;

        if (restFixTime >= FIX_INTERVAL) {
            while (restFixTime >= FIX_INTERVAL) {
                restFixTime -= FIX_INTERVAL;
                LogicFix(ctx, FIX_INTERVAL);
            }
        } else {
            LogicFix(ctx, restFixTime);
            restFixTime = 0;
        }

        LateTick(ctx, dt);


    }

    static void PreTick(GameContext ctx, float dt) {
        ctx.moduleInput.ProcessMove();
    }

    static void LogicFix(GameContext ctx, float dt) {
        // player
        int playerlen = ctx.playerRepository.TakeAll(out PlayerEntity[] players);
        for (int i = 0; i < playerlen; i++) {
            PlayerEntity player = players[i];
            Debug.Log(player.moveDir);
            PlayerDomain.SetMoveDir(ctx, player, ctx.moduleInput.moveDir);
        }
        // box
        int boxlen = ctx.boxRepository.TakeAll(out BoxEntity[] boxs);
        for (int i = 0; i < boxlen; i++) {
            BoxEntity box = boxs[i];
        }
    }

    static void LateTick(GameContext ctx, float dt) {

    }

}