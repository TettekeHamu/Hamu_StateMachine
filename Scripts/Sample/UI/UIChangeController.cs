using UnityEngine;
using UnityEngine.UI;

namespace TettekeKobo.StatePatternTest
{
    /// <summary>
    /// UIの表示・非表示をおこなうクラス
    /// </summary>
    public class UIChangeController : MonoBehaviour
    {
        [SerializeField] private Image redImage;
        [SerializeField] private Image blueImage;

        public void ChangeRedImage(bool canView)
        {
            redImage.gameObject.SetActive(canView);
        }

        public void ChangeBlueImage(bool canView)
        {
            blueImage.gameObject.SetActive(canView);
        }
    }
}
