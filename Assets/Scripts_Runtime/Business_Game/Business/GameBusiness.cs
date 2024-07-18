using System;
using UnityEngine;

public static class Game_Business {
    public static void New_Game(GameContext ctx) {
        // 生成箱子
         
        BoxDomain.Spawn(ctx, new Vector3(-3.5f, 1.5f, 0));
        BoxDomain.Spawn(ctx, new Vector3(0.5f, 1.5f, 0));
        BoxDomain.Spawn(ctx, new Vector3(-0.5f, 2.5f, 0));


    }

    public static void Load_Game(GameContext ctx) {

    }
    public static void UnLoad_Game(GameContext ctx) {

    }

    public static void Tick(GameContext ctx, float dt) {

        // float fixedDT = Time.fixedDeltaTime; // 0.02
        // restDT += dt; // 0.0083 (0.0000000001, 10)
        // if (restDT >= fixedDT) {
        //     while (restDT >= fixedDT) {
        //         restDT -= fixedDT;
        //         FixedTick(fixedDT);
        //     }
        // } else {
        //     FixedTick(restDT);
        //     restDT = 0;
        // }



    }

    static void PreTick(GameContext ctx, float dt) {

    }

    static void LogicTick(GameContext ctx, float dt) {

    }

    static void LateTick(GameContext ctx, float dt) {

    }

}