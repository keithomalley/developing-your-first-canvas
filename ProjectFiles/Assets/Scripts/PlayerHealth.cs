using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public float health = 150;
    public float mana = 150;
    
    public Slider healthBar;
    public Slider manaBar;
    
	void Update () {
        if (Input.GetKeyDown(KeyCode.D)) {
            health -= 10;
        }
		if(healthBar != null)
            healthBar.value = health;
		if(manaBar != null)
			manaBar.value = mana;
	}
}
