/*
 * Author: Kaja Więckowska, Emanuel Misztal
 * 2019
 */

using UnityEngine;
using UnityEngine.UI;

public class Desktop : MonoBehaviour
{
    public Icon icon; // link to icon
    public Text textField; // link to text field
    public GameObject inputField; // link to input field
    public FingerprintScanner fps; // link to fingerprint scanner
    public GameObject TextMessagePassword; // link to text message indicating change of fingerprint

    private void OnMouseDown()
    {
        icon.ResetClickCounter(); // reset icon click counter
    }

    // event called by ending input in input field
    public void CheckPassword()
    {
        if (textField.text == "klopsik" || textField.text == "Klopsik") // ! wrong way to check if password is correct, password should be private field so it can be changed
        {
            TextMessagePassword.SetActive(true); // wyświetla napis że odcisk palca został zmieniony
            fps.ChangeScanStatus(); // change fingerprint status to cracked
        }
        else textField.text = ""; // empty password field
        inputField.gameObject.SetActive(false); // turn off password field
    }
}
