using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIcontroller : MonoBehaviour

{
    public Image heartImage;

    private void Start()
    {
        heartImage = GameObject.Find("HeartImage").GetComponent<Image>();
    }

    // Start is called before the first frame update
    public void UpdateHealth(float currentHeath, float maxHealth)
    {
        heartImage.fillAmount = currentHeath/maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
