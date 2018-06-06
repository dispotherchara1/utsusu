﻿using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    public GameOver gameover;
    public GaugeController gaugeController;
    Vector2 teleportation = new Vector2(50.0f, 0.0f);
    //Vector2 jamp = new Vector2(0.0f,200.0f);

    void Button() // ボタンで移動距離が違う
    {
        Vector2 pos = transform.position;  // 現在位置をposに代入

        if (Input.GetKeyDown(KeyCode.B))
        {
            pos += teleportation * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            pos += teleportation * 2 * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            pos += teleportation * 3 * Time.deltaTime;
        }
        transform.position = pos; //現在の位置にteleportationの移動距離を加算
    }

    void GoGauge()
    {
        Vector2 pos = transform.position; //現在位置をposに代入

        if (!gaugeController.GetGauge())
        {
            //移動計算式
            pos += teleportation * gaugeController.GetTime() * Time.deltaTime;
            gaugeController.GetResetTime();
        }
        transform.position = pos; //現在の位置にteleportationの移動距離を加算
    }
    // Update is called once per frame
    void Update ()
    {
        if (gameover.GetGameOver() == false) { 
        Button();//ボタンで移動距離が変わるメソッド
        GoGauge();//ゲージ式
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "DeathZone")
        {
            gameover.SetGameOver();
        }
        else if (col.gameObject.tag == "ClearZone")
        {
            gameover.SetClear();
        }
    }
}