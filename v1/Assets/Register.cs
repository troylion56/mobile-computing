using Firebase.Auth;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    FirebaseAuth auth;
    void Start()
    {
        auth = FirebaseAuth.DefaultInstance;
    }

    public void RegisterWithEmailAndPassword(string email,string username, string password, string confirmPassword)
    {
        if (password == confirmPassword)
        {
            auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
                if (task.IsCanceled)
                {
                    Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                    return;
                }
                if (task.IsFaulted)
                {
                    Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                    return;
                }

                FirebaseUser user = task.Result;
                Debug.LogFormat("Firebase user created successfully: {0} ({1})", username, user.UserId);
            });
        }
        else
        {
            Debug.LogError("Password and confirm password do not match.");
        }
    }
}