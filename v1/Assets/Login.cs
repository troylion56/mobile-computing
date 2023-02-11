using Firebase.Auth;
using UnityEngine;

public class Login : MonoBehaviour
{
    FirebaseAuth auth;
    public Animator savedAnimation;
    public Animator notsavedAnimation; 

    void Start()
    {
        auth = FirebaseAuth.DefaultInstance;
    }

    public void LoginWithEmailAndPassword(string email, string password)
    {
        //test it does it work? 
        Debug.Log("LoginWithEmailAndPassword called");
        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task => {        //then call it
            if (task.IsCanceled)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                notsavedAnimation.SetTrigger("errorTrigger");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                notsavedAnimation.SetTrigger("errorTrigger");
                return;
            }

            FirebaseUser user = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})", user.DisplayName, user.UserId);
            savedAnimation.SetTrigger("savedTrigger");
        });
    }
}