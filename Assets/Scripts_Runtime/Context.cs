using System;
using UnityEngine;

public class Context {
    public AssetsContext assets;

    public ModuleInput moduleInput;

    public GameContext gameContext;
    public Context() {
        assets = new AssetsContext();
        moduleInput = new ModuleInput();
        gameContext = new GameContext();
    }


    public void Inject() {
        gameContext.Inject(assets,moduleInput);
    }


}