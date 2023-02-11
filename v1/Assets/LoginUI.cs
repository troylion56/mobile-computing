using UnityEngine;
using UnityEngine.UI;

public class LoginUI : MonoBehaviour
{
    public InputField emailInput;
    public InputField passwordInput;
    public Login login;

    public void Login()
    {
        string email = emailInput.text;
        string password = passwordInput.text;
        login.LoginWithEmailAndPassword(email, password);
    }
}