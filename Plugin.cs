using System;
using System.IO;
using BManager;
using BManager.Attributes;
using BSupport;
using System.Security.Principal;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace ColoredUI
{
	
	[ModuleInfo("ColoredUI", "1.0", "Biscuit")]
	public class Plugin : VRModule
    {
        // Only: static Main() for Start()

     

        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("[HH:mm:ss] -> ");
               
                
                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> LogoContainer]");
                GameObject.Find("MenuContent/Screens/Title/LogoContainer/vrchatlogo2sided").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Screens/Title/Panel").gameObject.SetActive(false);
           
                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> Backdrop]");
                GameObject.Find("MenuContent/Backdrop").gameObject.SetActive(false);


               //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> AlertPopup]");
                GameObject.Find("MenuContent/Popups/AlertPopup/Darkness").GetComponent<Image>().color = Color.black;
                GameObject.Find("MenuContent/Popups/AlertPopup/Lighter").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/AlertPopup/Button").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/AlertPopup/Button/Text").GetComponent<Text>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/AlertPopup/BodyText").GetComponent<Text>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/AlertPopup/TitleText").GetComponent<Text>().color = Color.blue;
                
                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> LoadingBackground]");
                GameObject.Find("LoadingBackground_TealGradient_Music/SkyCube_Baked").gameObject.SetActive(false);
                GameObject.Find("LoadingBackground_TealGradient_Music/_FX_ParticleBubbles").gameObject.SetActive(false);
                
                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> LoadingPopup]");
                GameObject.Find("MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/SkyCube_Baked").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").transform.position = new Vector3(-0.0068f, 1.17f, 1.2724f);
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").transform.localPosition = new Vector3(0.25f, -124.3375f, 0.5001f);
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").transform.localScale = new Vector3(0.7f, 2.9f, 5f);
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Decoration_Left").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Decoration_Right").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/LOADING_BAR_BG").GetComponent<Image>().color = Color.gray;
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements").transform.localScale = new Vector3(0.9f, 0.9f, 0.1f);
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_LOADING_Size").GetComponent<Text>().color = Color.red;
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_LOADING_Size").transform.position = new Vector3(-0.06f, 1.25f, 1.272f);
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_LOADING_Size").transform.localPosition = new Vector3(-127.6389f, -13.5694f, 0f);
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_Percent").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/LOADING_BAR").GetComponent<Image>().color = Color.green;
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton/Text").GetComponent<Text>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/LoadingPopup/ButtonMiddle").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/LoadingPopup/ButtonMiddle/Text").GetComponent<Text>().color = Color.blue;
                
                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> StandardPopup]");
                GameObject.Find("MenuContent/Popups/StandardPopup/Rectangle").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/StandardPopup/ArrowRight").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/StandardPopup/ArrowLeft").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/StandardPopup/ProgressLine").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/StandardPopup/LowPercent").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/StandardPopup/HighPercent").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/StandardPopup/MidRing").GetComponent<Image>().color = Color.red;
                GameObject.Find("MenuContent/Popups/StandardPopup/InnerDashRing").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/StandardPopup/RingGlow").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Popups/StandardPopup/ButtonMiddle").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/StandardPopup/TitleText").GetComponent<Text>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/StandardPopup/BodyText").GetComponent<Text>().color = Color.blue;
                

                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> Authentication]");
                GameObject.Find("MenuContent/Screens/Authentication/StoreLoginPrompt/VRChat_LOGO (1)").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Screens/Authentication/StoreLoginPrompt/TextWelcome").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Screens/Authentication/StoreLoginPrompt/VRChatButtonLogin").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Screens/Authentication/StoreLoginPrompt/StoreButtonLogin (1)").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonCreate").GetComponent<Image>().color = Color.blue;
                
                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> LoginUserPass]");
                GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/VRChat_LOGO (1)").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/TextWelcome").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs").gameObject.SetActive(false);
                GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/ButtonBack (1)").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/ButtonDone (1)").GetComponent<Image>().color = Color.blue;

                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> InputPopup]");
                GameObject.Find("MenuContent/Popups/InputPopup/Darkness").GetComponent<Image>().color = Color.black;
                GameObject.Find("MenuContent/Popups/InputPopup/Rectangle").GetComponent<Image>().color = Color.black;
                GameObject.Find("MenuContent/Popups/InputPopup/Rectangle/Panel").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/InputPopup/ButtonRight").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/InputPopup/ButtonRight/Text").GetComponent<Text>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/InputPopup/ButtonLeft").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/InputPopup/ButtonLeft/Text").GetComponent<Text>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/InputPopup/PasswordVisibilityToggle").GetComponent<Image>().color = Color.blue;
                
                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> InputKeypadPopup]");
                GameObject.Find("MenuContent/Popups/InputKeypadPopup/Darkness").GetComponent<Image>().color = Color.black;
                GameObject.Find("MenuContent/Popups/InputKeypadPopup/Rectangle").GetComponent<Image>().color = Color.black;
                GameObject.Find("MenuContent/Popups/InputKeypadPopup/InputField").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/InputKeypadPopup/Rectangle/Panel").GetComponent<Image>().color = Color.black;
                GameObject.Find("MenuContent/Popups/InputKeypadPopup/TitleText").GetComponent<Text>().color = Color.blue;

                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> StandardPopupV2]");
                GameObject.Find("MenuContent/Popups/StandardPopupV2/Darkness").GetComponent<Image>().color = Color.black;
                GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/BorderImage").GetComponent<Image>().color = Color.black;
                GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/Panel").GetComponent<Image>().color = Color.black;
                GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/ExitButton").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/Buttons/LeftButton").GetComponent<Image>().color = Color.blue;
                GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/Buttons/RightButton").GetComponent<Image>().color = Color.blue;

                //------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> FlatLoadingOverlay -> you will be get a erorr if you are in vr]");
                Console.WriteLine(formattedDateTime + "[ColoredUI -> Patch -> Done]");
                GameObject.Find("TrackingVolume/VRLoadingOverlay/FlatLoadingOverlay(Clone)/Container/Canvas/Background").GetComponent<Image>().color = Color.black;
                GameObject.Find("TrackingVolume/VRLoadingOverlay/FlatLoadingOverlay(Clone)/Container/Canvas/Background/Layout/LoadIndicator").GetComponent<RawImage>().color = Color.red;
                GameObject.Find("TrackingVolume/VRLoadingOverlay/FlatLoadingOverlay(Clone)/Container/Canvas/Background/Layout/WorldThumbnailBackground").gameObject.SetActive(false);
                


        }
    }
  }

