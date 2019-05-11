using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour {

		public InputField nameField;
		public InputField passwordField;

		public Button submitButton;

		public void CallRegister()
		{
        StartCoroutine(Register());
		}

		IEnumerator Register()
		{
			WWWForm form = new WWWForm();
			form.AddField("name", nameField.text);
			form.AddField("password", passwordField.text);
			WWW www = new WWW("http://192.168.0.244/sqlconnect/register.php", form);
			yield return www;
			if (www.text == "0")
			{
				Debug.Log("Usuario creado satisfactoriamente");
				UnityEngine.SceneManagement.SceneManager.LoadScene(0);
			}
			else
			{
				Debug.Log("Ocurrio un error al crear un usuario. Error #" + www.text);
			}
		}

		public void VerifyInputs()
		{
			submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
		}

}
