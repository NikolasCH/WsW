////////////////////////////////////////////////////////////////////////////////
//  
// @module IOS Native Plugin for Unity3D 
// @author Osipov Stanislav (Stan's Assets) 
// @support stans.assets@gmail.com 
//
////////////////////////////////////////////////////////////////////////////////

using System;
using UnityEngine;
using SA.iOS.StoreKit;
using SA.iOS.Examples;


    public class SX_InApp_iOS : MonoBehaviour 
    {

        private static SX_BillingClient_iOS s_paymentManager;


        private void Start()
        {

#if UNITY_ANDROID
            GetComponent<SX_InApp_iOS>().enabled = false;
#endif

        if (s_paymentManager == null)
            {
                s_paymentManager = new SX_BillingClient_iOS();
            }


            s_paymentManager.init();
        }


        public void Purchase(string ProductId)
        {
            if (ProductId == "wfw_p1")
                ProductId = "wfw_1000";
            if (ProductId == "wfw_p2")
                ProductId = "wfw_2200";
            if (ProductId == "wfw_p3")
                ProductId = "wfw_3600";
            if (ProductId == "wfw_p4")
                ProductId = "wfw_5200";
            if (ProductId == "wfw_p5")
                ProductId = "wfw_7000";

            if (ProductId == "page_1")
                ProductId = "wfw_page1";
            if (ProductId == "page_2")
                ProductId = "wfw_page2";
            if (ProductId == "page_3")
                ProductId = "wfw_page3";
            if (ProductId == "page_4")
                ProductId = "wfw_page4";
            if (ProductId == "page_5")
                ProductId = "wfw_page5";
            if (ProductId == "page_6")
                ProductId = "wfw_page6";
            if (ProductId == "page_7")
                ProductId = "wfw_page7";

        ISN_SKPaymentQueue.AddPayment(ProductId);
        }

    }
