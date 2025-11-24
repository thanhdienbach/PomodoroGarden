using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LogoFader : MonoBehaviour
{
    [SerializeField] private TMP_Text logoText;
    [SerializeField] private float fadeInDuration = 0.6f;
    [SerializeField] private float waitDuration = 0.8f;
    [SerializeField] private float fadeOutDuration = 0.6f;

    public void PlaySequence()
    {
        logoText.alpha = 0f;

        Sequence seq = DOTween.Sequence();

        seq.Append(logoText.DOFade(1.0f, fadeInDuration).SetEase(Ease.InOutSine))
           .AppendInterval(waitDuration)
           .Append(logoText.DOFade(0.0f, fadeOutDuration))
           .OnComplete(() =>
           {
               SceneManager.LoadScene(1);
           });
    }
}
