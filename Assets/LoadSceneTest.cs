using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneTest : MonoBehaviour {
	private GameObject obj1 = null;
	private GameObject obj2 = null;

	void Start () {
		obj1 = new GameObject();
		obj2 = new GameObject();

		Texture2D      bg1     = Resources.Load("scene/scene_10322/0_0") as Texture2D;
		Rect           rect1   = new Rect(0, 0, bg1.width, bg1.height);
		Sprite         sprite1 = Sprite.Create(bg1, rect1, new Vector2(0.5f, 0.5f));
		SpriteRenderer renderer1 = obj1.AddComponent<SpriteRenderer>();

		renderer1.sprite       = sprite1;
		renderer1.sortingOrder = 1;
		obj1.transform.position = new Vector3(0, 0, 0);

		Texture2D      bg2     = Resources.Load("scene/scene_10322/1_0") as Texture2D;
		Rect           rect2   = new Rect(0, 0, bg2.width, bg2.height);
		Sprite         sprite2 = Sprite.Create(bg2, rect2, new Vector2(0.5f, 0.5f));
		SpriteRenderer renderer2 = obj2.AddComponent<SpriteRenderer>();

		renderer2.sprite       = sprite2;
		renderer2.sortingOrder = 1;
		obj2.transform.position = new Vector3(3.2f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
