using UnityEngine;
public class AutomaticDoor : MonoBehaviour
{
    //　Door Animator
    [SerializeField]
    [Tooltip("自動ドアのアニメーター")]
    private Animator automaticDoorAnimator;
    /// <summary>
    /// When an automatic door is in detected area
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerEnter(Collider other)
    {
        // Change the animation parameter into true (Open the door)
        automaticDoorAnimator.SetBool("Open", true);
    }
    /// <summary>
    /// When an automatic door is out of detected area
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerExit(Collider other)
    {
        // Change the animation parameter into false (Close the door)
        automaticDoorAnimator.SetBool("Open", false);
    }
}