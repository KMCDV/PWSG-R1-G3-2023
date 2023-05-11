using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class LensDistortionTween : MonoBehaviour
{

    public VolumeProfile volume;
    // Start is called before the first frame update
    void Start()
    {
        DOVirtual.Float(-1, 1, 2f, UpdateLensDistortion).SetLoops(-1, LoopType.Yoyo);
        DOVirtual.Float(-180, 180, 2f, UpdateHue).SetLoops(-1, LoopType.Yoyo);
    }

    public void UpdateLensDistortion(float x)
    {
        if(volume.TryGet<LensDistortion>(out LensDistortion lens))
        {
            lens.intensity.Override(x);
        }
    }

    public void UpdateHue(float x)
    {
        if (volume.TryGet<ColorAdjustments>(out ColorAdjustments color))
        {
            color.hueShift.Override(x);
        }
    }

}
