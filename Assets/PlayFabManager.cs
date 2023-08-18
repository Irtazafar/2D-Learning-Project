using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;

public class PlayFabManager : MonoBehaviour
{

    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;

    public void LoginButton()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text
        };

        PlayFabClientAPI.LoginWithEmailAddress(request, onSucess, onError);
    }

    public void RegisterButton()
    {
        if(passwordInput.text.Length <6)
        {
            messageText.text = "Password too short";
            return; 
        }
        var request = new RegisterPlayFabUserRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, onError);
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        messageText.text = "Registered and logged in";
    }
    public void ResetPasswordButton()
    {
        var request = new SendAccountRecoveryEmailRequest
        {
            Email = emailInput.text,
            TitleId = "D1E70"
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, onPasswordReset, onError);
    }

    void onPasswordReset(SendAccountRecoveryEmailResult result)
    {
        messageText.text = "Password reset mail sent";
    }


    void Start()
    {
        //Login();
    }

    void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, onSucess, onError);


    }

    void onSucess(LoginResult result)
    {
        messageText.text = "Successfully Logged In";
        Debug.Log("Successfull Login");
    }

    void onError(PlayFabError error)
    {
        messageText.text = error.ErrorMessage;
        Debug.Log("Error while logging");
        Debug.Log(error.GenerateErrorReport());
    }

}
