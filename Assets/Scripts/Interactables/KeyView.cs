using UnityEngine;

public class KeyView : MonoBehaviour, IInteractable
{
    [SerializeField] GameUIView gameUIView;
    public void Interact()
    {
         int currentkeys = GameService.Instance.GetPlayerController().KeysEquipped;
        GameService.Instance.GetInstructionView().HideInstruction();
        GameService.Instance.GetSoundView().PlaySoundEffects(SoundType.KeyPickUp);
        GameService.Instance.GetPlayerController().KeysEquipped++;
        gameUIView.UpdateKeyText();

        gameObject.SetActive(false);
    }
}
