using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneTest : MonoBehaviour {
    private GameObject[,] regions = null;

    void Start(){
        LoadScene();
    }

    void LoadScene(){
        regions = new GameObject[14, 14];

        for (int i = 0; i < 14; i++) {
            for (int j = 0; j < 14; j++) {
                regions[i, j] = new GameObject();
                string url = "scene/scene_10322/" + i + "_" + j;
                Texture2D bg = Resources.Load(url) as Texture2D;
                Rect rt = new Rect(0, 0, bg.width, bg.height);
                Sprite st = Sprite.Create(bg, rt, new Vector2(0f, 0f));
                SpriteRenderer sr = regions[i, j].AddComponent<SpriteRenderer>();

                sr.sprite = st;
                sr.sortingOrder = 1;

                float x = 3.2f * i;
                float y = 1.8f * (13 - j);
                regions[i, j].transform.position = new Vector3(x, y, 0);
                regions[i, j].gameObject.name = url;
            }
        }
    }

    void DrawGrids() {
        for (int i = 0; i < 14; i++) {
            Vector3 from = new Vector3(0,0,0);
            Vector3 to   = new Vector3(0,0,0);
            Gizmos.color = new Color(0.3f, 0.7f, 0.5f, 0.5f);

            from.x = 3.2f * i;

            to.x = 3.2f * i;
            to.y = 1.8f * 14;
            Gizmos.DrawLine(from, to);
        }

        for (int i = 0; i < 14; i++)
        {
            Vector3 from = new Vector3(0, 0, 0);
            Vector3 to = new Vector3(0, 0, 0);
            Gizmos.color = new Color(0.3f, 0.7f, 0.5f, 0.5f);

            from.y = 1.8f * i;

            to.x = 3.2f * 14;
            to.y = 1.8f * i;
            Gizmos.DrawLine(from, to);
        }
    }

	
	// Update is called once per frame
	void Update () {
    }

    void OnDrawGizmos()
    {
        DrawGrids();
    }
}
