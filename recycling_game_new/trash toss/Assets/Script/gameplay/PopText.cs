using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopText : MonoBehaviour {

    public Animator animator;
    private Text moneyText;

    void Awake()
    {
        AnimatorClipInfo[] clipInfo= animator.GetCurrentAnimatorClipInfo(0);
        Debug.Log(clipInfo.Length);
        Destroy(gameObject, clipInfo[0].clip.length);
        moneyText = animator.GetComponent<Text>();
    }

    public void setText(string text)
    {
        animator.GetComponent<Text>().text = text;
    }
}
