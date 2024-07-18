using System;
using UnityEngine;

public class GameContext {

    public GameEntity gameEntity;
    //  inject 
    public AssetsContext assets;


    // repo

    public BoxRepository boxRepository;

    public PlayerRepository playerRepository;

    public GameContext() {
        boxRepository = new BoxRepository();
        playerRepository = new PlayerRepository();
        gameEntity = new GameEntity();
    }


    public void Inject(AssetsContext assets) {
        this.assets = assets;
    }
}