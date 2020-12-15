﻿/*************************
* 每个玩家都有一个heart
* 当heart被敌方击中时即为失败
*************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Heart : MonoBehaviour {

    private SpriteRenderer sr;
    public GameObject explosionPrefab;
    public AudioClip dieAudio;

    public Sprite BrokenSprite;

	// Use this for initialization
	void Start () 
    {
        sr = GetComponent<SpriteRenderer>();
	}


    public void Die()
    {
        sr.sprite = BrokenSprite;
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        PlayerManager.Instance.isDefeat = true;
        AudioSource.PlayClipAtPoint(dieAudio, transform.position);
    }
}
