using UnityEngine;

public class LightsOffByGhostEvent : MonoBehaviour
{
    [SerializeField] private int kesRequiredToTrigger;
    [SerializeField] private SoundType sound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerView>()!=null && kesRequiredToTrigger == GameService.Instance.GetPlayerController().KeysEquipped)
        {
            EventService.Instance.OnLightsOffByGhostEvent.InvokeEvent();
            GameService.Instance.GetSoundView().PlaySoundEffects(sound);
            this.gameObject.SetActive(false);
        }
    }
}