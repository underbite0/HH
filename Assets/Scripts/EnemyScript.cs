using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using BulletPro;

public class EnemyScript : MonoBehaviour
{
    [Header("Stats")]

	public float maxHealth = 100;

	[System.NonSerialized] public float curHealth;
    [System.NonSerialized] public bool isAlive;

    public bool isImmune;

    [Header("References")]
	public BulletEmitter[] bulletEmitters;
	public SpriteRenderer sprite;
	public BulletReceiver receiver;
	public RectTransform lifebar;
	[System.NonSerialized] public SpriteRenderer lifebarSprite;

    // Start is called before the first frame update
	
    public void ImmuneSwitch()
    { isImmune = !isImmune;
    }

	public void Hurt(Bullet bullet, Vector3 hitPoint)
	{
        if(!isImmune){
		    maxHealth -= bullet.moduleParameters.GetFloat("_PowerLevel");
        }
        else{}
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
