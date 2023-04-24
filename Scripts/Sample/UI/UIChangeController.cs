using UnityEngine;
using UnityEngine.UI;

namespace TettekeKobo.StateMachine.Sample
{
    /// <summary>
    /// UIの表示・非表示をおこなうクラス
    /// </summary>
    public class UIChangeController : MonoBehaviour
    {
        [SerializeField] private Image redImage;
        [SerializeField] private Image blueImage;

        public void SetEnableRedImage(bool canView)
        {
            redImage.gameObject.SetActive(canView);
        }

        public void SetEnableBlueImage(bool canView)
        {
            blueImage.gameObject.SetActive(canView);
        }
    }
}
