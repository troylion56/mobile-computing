using Firebase;
using Firebase.Database;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class saveData: MonoBehaviour {
  public DatabaseReference Bdreference;
  public InputField emailInput;

    private void Start()
    {
        // Get the root reference location of the database.
        Bdreference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void saveDaaa(){
      StartCoroutine(UpdateUsernameDatabase(emailInput.text));
    }
    private IEnumerator UpdateUsernameDatabase(string username)
    {
        // Set the currently logged in user username in the database
        var DBTask = Bdreference.Child("users").Child(username).Child("username").SetValueAsync(username);

        yield return new WaitUntil(() => DBTask.IsCompleted);

        if (DBTask.Exception != null)
        {
            Debug.LogWarning($"fallito {DBTask.Exception}");
        }
        else
        {
            // Database username is now updated
        }
    }
}
