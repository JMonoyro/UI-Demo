using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UltaController : MonoBehaviour
{
    public Image UltaImg;

    float fill = 0;
    public void Start()
    {
        fill = 0;
        UltaImg.fillAmount = fill;
    }

    // Update is called once per frame
    public void UpdateClickButton()
    {
        fill += 0.08f;
        UltaImg.fillAmount = fill;
    }
}
