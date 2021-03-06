﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneTest : MonoBehaviour {
    private GameObject[,] regions = null;

    void Start(){
        LoadScene();
    }

    void LoadScene(){
        regions = new GameObject[42, 37];

        for (int i = 0; i < 42; i++) {
            for (int j = 0; j < 37; j++) {
                regions[i, j] = new GameObject();
                string url = "scene/scene_10002/" + i + "_" + j;
                Texture2D bg = Resources.Load(url) as Texture2D;
                Rect rt = new Rect(0, 0, bg.width, bg.height);
                Sprite st = Sprite.Create(bg, rt, new Vector2(0f, 0f));
                SpriteRenderer sr = regions[i, j].AddComponent<SpriteRenderer>();

                sr.sprite = st;
                sr.sortingOrder = 1;

                float x = 3.2f * i;
                float y = 1.8f * (36 - j);
                regions[i, j].transform.position = new Vector3(x, y, 0);
                regions[i, j].gameObject.name = url;
            }
        }
    }

    void DrawGrids() {
        for (int i = 0; i < 43; i++) {
            Vector3 from = new Vector3(0,0,0);
            Vector3 to   = new Vector3(0,0,0);
            Gizmos.color = new Color(0.3f, 0.7f, 0.5f, 0.5f);

            from.x = 3.2f * i;

            to.x = 3.2f * i;
            to.y = 1.8f * 37;
            Gizmos.DrawLine(from, to);
        }

        for (int i = 0; i < 38; i++)
        {
            Vector3 from = new Vector3(0, 0, 0);
            Vector3 to = new Vector3(0, 0, 0);
            Gizmos.color = new Color(0.3f, 0.7f, 0.5f, 0.5f);

            from.y = 1.8f * i;

            to.x = 3.2f * 42;
            to.y = 1.8f * i;
            Gizmos.DrawLine(from, to);
        }
    }

    void _DrawGrids()
    {
        Vector3 from = new Vector3(19.04f, 8.10f, 0);
        Vector3 to = new Vector3(22.308f, 9.74f, 0);
        Gizmos.color = new Color(1.0f, 0, 0, 0.5f);
        Gizmos.DrawLine(from, to);

        from = new Vector3(35.125f, 0.046f, 0);
        to = new Vector3(0.01f, 17.52f, 0);
        Gizmos.color = new Color(1.0f, 0, 0, 0.5f);
        Gizmos.DrawLine(from, to);

        from = new Vector3(19.436f, 7.876f, 0);
        to = new Vector3(22.64f, 9.46f, 0);
        Gizmos.color = new Color(1.0f, 0, 0, 0.5f);
        Gizmos.DrawLine(from, to);

        from = new Vector3(19.493f, 8.35f, 0);
        to = new Vector3(19.89f, 8.12f, 0);
        Gizmos.color = new Color(1.0f, 0, 0, 0.5f);
        Gizmos.DrawLine(from, to);
    }


    // Update is called once per frame
    void Update () {
    }

    void OnDrawGizmos()
    {
        DrawGrids();
        _DrawGrids();
    }
}
