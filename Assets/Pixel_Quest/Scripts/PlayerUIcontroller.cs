using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUIcontroller : MonoBehaviour

{
    public Image heartImage;
    private TextMeshProUGUI textMeshProUGUI;

    public void StartUI()
    {
        heartImage = GameObject.Find("HeartImage").GetComponent<Image>();
        textMeshProUGUI = GameObject.Find("CoinTextBackground").GetComponent <TextMeshProUGUI>();
    }
    public void UpdateText (string NewText) { textMeshProUGUI.text = NewText; }

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
