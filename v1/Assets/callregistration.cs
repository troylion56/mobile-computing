using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class callregistration : MonoBehaviour
{
    public InputField emailInputField;
    public InputField usernameInputField;
    public InputField passwordInputField;
    public InputField confirmPasswordInputField;
    public Register register; 
    public void CallRegistrationMethod() {
        register.RegisterWithEmailAndPassword(emailInputField.text,usernameInputField.text,passwordInputField.text,confirmPasswordInputField.text);
    } 

}
