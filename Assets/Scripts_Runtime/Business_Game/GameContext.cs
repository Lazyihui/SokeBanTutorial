using System;
using UnityEngine;

public class GameContext {

    public GameEntity gameEntity;
    //  inject 
    public AssetsContext assets;

    public ModuleInput moduleInput;


    // repo

    public BoxRepository boxRepository;

    public PlayerRepository playerRepository;

    public GameContext() {
        boxRepository = new BoxRepository();
        playerRepository = new PlayerRepository();
        gameEntity = new GameEntity();
    }


    public void Inject(AssetsContext assets, ModuleInput moduleInput) {
        this.assets = assets;
        this.moduleInput = moduleInput;
    }
}