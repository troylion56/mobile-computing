using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterUI : MonoBehaviour
{
    public InputField emailInputField;
    public InputField usernameInputField;
    public InputField passwordInputField;
    public InputField confirmPasswordInputField;

    public Register register;  

    public void Register() {
        string email = emailInputField.text;
        string username = usernameInputField.text;
        string password = passwordInputField.text;
        string confirmPassword = confirmPasswordInputField.text;

        register.RegisterWithEmailAndPassword(email, username, password,confirmPassword);
    }
}
