using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;

public class contollerPlayfab : MonoBehaviour
{
    [SerializeField] GameObject accediTab , registaTab;
    public Text usernameReg, emailReg, passwordReg, eamilLog, passwordLog, erroreLog, erroeReg;

    public Animator trasErrAccedi, transErrReg, transOkAccedi, transOkReg;
    public void RegistaTab() {
        registaTab.SetActive(true);
        accediTab.SetActive(false);
        erroeReg.text="";
        erroreLog.text="";
    } 

    public void AccediTab() {
        accediTab.SetActive(true);
        registaTab.SetActive(false);    
        erroeReg.text="";
        erroreLog.text="";
    } 
    
    public void reggistrati() {
        var registerRequest = new RegisterPlayFabUserRequest{
            Username = usernameReg.text, 
            Email = emailReg.text, 
            Password= passwordReg.text
        };
        PlayFabClientAPI.RegisterPlayFabUser(registerRequest, RegisterSuccess, RegisterNonOk);
    }
  

    public void RegisterSuccess(RegisterPlayFabUserResult result) {
        Debug.Log("ok registrazione");
        erroeReg.text="";
        erroreLog.text="";
        transOkReg.SetTrigger("savedTrigger1");
    } 

    public void RegisterNonOk(PlayFabError error) {
        Debug.Log("errore registrazione");
        erroeReg.text = error.GenerateErrorReport();
        transOkReg.SetTrigger("errorTrigger1");
    }

    public void accedi() {
        var rec= new LoginWithEmailAddressRequest{ Email= eamilLog.text, Password=passwordLog.text};
        PlayFabClientAPI.LoginWithEmailAddress(rec, LoginOk, LoginNonOk );
    }

    public void LoginOk(LoginResult result){
        Debug.Log("ok accedi");
        erroeReg.text="";
        erroreLog.text="";
        transOkAccedi.SetTrigger("savedTrigger");
    }

    public void LoginNonOk(PlayFabError error) {
        Debug.Log("errore accedi");
        erroreLog.text = error.GenerateErrorReport();
        trasErrAccedi.SetTrigger("errorTrigger");
    } 

}
