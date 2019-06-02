using UnityEngine;
using UnityEngine.UI;

public class Desktop : MonoBehaviour
{
    public Icon icon; // link to icon
    public Text textField; // link to text field
    public GameObject inputField; // link to input field
    public FingerprintScanner fps; // link to fingerprint scanner
    public GameObject TextMessagePassword;

    private void OnMouseDown()
    {
        icon.ResetClickCounter(); // reset icon click counter
    }

    // event called by ending input in input field
    public void CheckPassword()
    {
        if (textField.text == "haslo")
        {
            Debug.Log("odcisk palca zmieniony");
            TextMessagePassword.SetActive(true); // wyświetla napis że odcisk palca został zmieniony
            fps.ChangeScanStatus();
        }
        else textField.text = "";
        inputField.gameObject.SetActive(false);
    }
}
