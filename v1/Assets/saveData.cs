using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using UnityEngine;

public class FirebaseDatabaseExample : MonoBehaviour
{

    private void Start()
    {
        DatabaseReference = FirebaseDatabase.DefaultInstance.RootReference;
    }




}