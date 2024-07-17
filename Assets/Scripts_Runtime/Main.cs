using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    Context ctx;
    bool isTearDown;

    void Awake()
    {
        isTearDown = false;

        // ==== Phase: Instantiate ====
        ctx = new Context();
        // ==== Phase: Inject ====
        // ==== Phase: Init Binging Load ====

        ModuleAssets.Load(ctx.assets);

        // ==== Phase: Enter Game ====

    }

    void Update()
    {

    }

    // 当 安卓/iOS 应用程序退出时调用
    void OnApplicationQuit()
    {
        TearDown();
    }

    void OnDestroy()
    {
        TearDown();
    }

    // 非官方生命周期
    void TearDown()
    {

        if (isTearDown)
        {
            return;
        }
        isTearDown = true;

        ModuleAssets.Unload(ctx.assets);
    }
}
