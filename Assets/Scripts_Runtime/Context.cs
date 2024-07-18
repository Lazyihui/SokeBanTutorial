using System;
using UnityEngine;

public class Context {
    public AssetsContext assets;

    public GameContext gameContext;
    public Context() {
        assets = new AssetsContext();
        gameContext = new GameContext();
    }


    public void Inject() {
        gameContext.Inject(assets);
    }


}