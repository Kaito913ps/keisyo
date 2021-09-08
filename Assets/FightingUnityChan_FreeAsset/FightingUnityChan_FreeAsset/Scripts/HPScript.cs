using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPScript : MonoBehaviour
{
    Slider hpSlider;
    Text hpText;

    float hp;
    void Start()
    {

    }

    void Update()
    {

    }

    public void SetSlider(float playerHP)
    {
        hp = playerHP;
        hpSlider = GetComponent<Slider>();
        hpSlider.maxValue = hp;
        hpSlider.value = hp;

        hpText = transform.Find("HPText").GetComponent<Text>();
        hpText.text = hpSlider.value.ToString() + "/" +
            hpSlider.maxValue.ToString();
    }

    public void Damage(bool key)
    {
        if (key == true)
        {
            //Input.GetKeyDown(KeyCode.Alpha2);
            hp -= 10f;
            hpSlider.value = hp;
            hpText.text = hpSlider.value.ToString() + "/" +
            hpSlider.maxValue.ToString();
        }
    }
}
