using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Healthbar : MonoBehaviour {

    private float fillAmount;

    [SerializeField]
    private float lerpSpeed;

    [SerializeField]
    private Image content;

    [SerializeField]
    private Text Valuetext; 

    public float MaxValue { get; set; }

    public float Value

    {
        set
        {

            string[] tmp = Valuetext.text.Split(':');
            Valuetext.text = tmp[0] + ":" + value; 
            fillAmount = Map(value, 0, MaxValue, 0, 1); 
        }
    }
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()

    {
        Handlebar(); 
    }

    private void Handlebar()
    {
        if (fillAmount != content.fillAmount)
        {
            
            content.fillAmount = Mathf.Lerp(content.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
             
        }
    } 

    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin; 
    }
}
