using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TestMovementHover : MonoBehaviour
{
    public AnimationCurve animationCurve;
    public MeshRenderer meshRenderer;
    public Gradient gradient;
    public Animator animator;
    /*Vector3 originalPosition;
    float time;*/
    // Start is called before the first frame update
    float blendTreeParameter = 0;

    void Start()
    {
        DOTween.To(() => blendTreeParameter, (x) => blendTreeParameter = x, .5f, .5f);

        meshRenderer = GetComponent<MeshRenderer>();
        transform.DOMoveY(3f, 2f)
            .SetRelative(true)
            .SetLoops(-1, LoopType.Restart)
            .SetEase(animationCurve);
        //meshRenderer.material.DOGradientColor(gradient, 5f).SetLoops(-1, LoopType.Yoyo);
        //transform.DORotate(new Vector3(0, 360, 0), 5f, RotateMode.LocalAxisAdd).SetLoops(-1);
        //originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       /* time += Time.deltaTime;
       
        transform.position = Vector3.LerpUnclamped(originalPosition, originalPosition + Vector3.up * 10, animationCurve.Evaluate(time));*/
    }
}
