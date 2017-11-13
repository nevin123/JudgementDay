using UnityEngine;
using DG.Tweening;

public class GodrayController : MonoBehaviour {

    [Range(0, 1)]
    public float MinOpacity = 0;
    [Range(0, 1)]
    public float MaxOpacity = 1;

    public float SmoothingTime = 1;

    [Range(0, 5)]
    public float GodrayOffset = 0;

    bool adding = true;

    float godrayAlpha = 0;
    Material godrayMat;

    void Start()
    {
        godrayMat = GetComponent<SpriteRenderer>().material;
        //Do movement
        transform.DOMoveX(transform.position.x + GodrayOffset, SmoothingTime).SetEase(Ease.InOutQuad).SetLoops(-1, LoopType.Yoyo);

        //Do alpha
        Color _godrayColorMin = godrayMat.GetColor("_TintColor");
        _godrayColorMin.a = MinOpacity;
        Color _godrayColorMax = godrayMat.GetColor("_TintColor");
        _godrayColorMax.a = MaxOpacity;

        godrayMat.SetColor("_TintColor", _godrayColorMin);
        godrayMat.DOColor(_godrayColorMax, "_TintColor", SmoothingTime/2f).SetEase(Ease.InOutQuad).SetLoops(-1, LoopType.Yoyo);
    }
}
