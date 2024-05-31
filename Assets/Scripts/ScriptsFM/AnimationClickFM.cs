using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationClickFM : MonoBehaviour
{
    public Animator animator;

    public void OnClick()
    {
        animator.Play("FundidoNegroAnimationFM");
    }
}
