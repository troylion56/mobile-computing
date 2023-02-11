using Firebase;
using Firebase.Database;
using UnityEngine;

public class saveData: MonoBehaviour {
  void Start() {
    // Get the root reference location of the database.
    DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
  }
}
