using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;

public class contollerPlayfab : MonoBehaviour
{
    [SerializeField] GameObject accediTab , registaTab, backupTab;
    public Text usernameReg, emailReg, passwordReg, eamilLog, passwordLog, erroreLog, erroeReg, emailBackup;

    public Animator trasErrAccedi, transErrReg, transOkAccedi, transOkReg, transOkBackup, transErrorBackup;
    public void RegistaTab() {
        registaTab.SetActive(true);
        accediTab.SetActive(false);
        backupTab.SetActive(false);
        erroeReg.text="";
        erroreLog.text="";
    } 

    public void AccediTab() {
        accediTab.SetActive(true);
        registaTab.SetActive(false);
        backupTab.SetActive(false);    
        erroeReg.text="";
        erroreLog.text="";
    }

    public void BackupTab() {
        accediTab.SetActive(false);
        registaTab.SetActive(false);
        backupTab.SetActive(true);

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
        transErrReg.SetTrigger("registrazioneNonRiuscita");
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

    public void RecoverPassword() {
            var request = new SendAccountRecoveryEmailRequest {
                Email = emailBackup.text,
                TitleId = "3E34E",
            };
            PlayFabClientAPI.SendAccountRecoveryEmail(request, ResultCallback, ErrorCallback);
        }
    private void ErrorCallback(PlayFabError error) {
        Debug.LogError(error.ErrorMessage);
        transErrorBackup.SetTrigger("erroreRecuperoTrigger");
    }

    private void ResultCallback(SendAccountRecoveryEmailResult result) {
        Debug.Log("Please check your email");
        transOkBackup.SetTrigger("okRecuperoTrigger");
    }
}
