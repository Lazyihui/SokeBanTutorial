using System;
using UnityEngine;

public class GameContext {

    public GameEntity gameEntity;
    //  inject 
    public AssetsContext assets;


    // repo

    public BoxRepository boxRepository;

    public GameContext() {
        boxRepository = new BoxRepository();
        gameEntity = new GameEntity();
    }


    public void Inject(AssetsContext assets) {
        this.assets = assets;
    }
}