using UnityEngine;
using UnityEngine.UI;

public class call : MonoBehaviour
{
    public InputField emailInputField;
    public InputField passwordInputField;
    public Login login;
        //just to invoce the loginwithemail metod
    public void CallLoginMethod()
    {
        login.LoginWithEmailAndPassword(emailInputField.text, passwordInputField.text);
    }
}