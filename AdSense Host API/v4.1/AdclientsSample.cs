﻿// Copyright 2017 DAIMTO :  www.daimto.com
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:31:46
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the AdSenseHost v4.1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Generates performance reports, generates ad codes, and provides publisher management capabilities for AdSense Hosts.
// API Documentation Link https://developers.google.com/adsense/host/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/AdSenseHost/v4_1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.AdSenseHost.v4_1/ 
// Install Command: PM>  Install-Package Google.Apis.AdSenseHost.v4_1
//
//------------------------------------------------------------------------------  
using Google.Apis.AdSenseHost.v4_1;
using Google.Apis.AdSenseHost.v4_1.Data;
using System;

namespace GoogleSamplecSharpSample.AdSenseHostv4_1.Methods
{
  
    public static class AdclientsSample
    {


        /// <summary>
        /// Get information about one of the ad clients in the Host AdSense account. 
        /// Documentation https://developers.google.com/adsensehost/v4.1/reference/adclients/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdSenseHost service.</param>  
        /// <param name="adClientId">Ad client to get.</param>
        /// <returns>AdClientResponse</returns>
        public static AdClient Get(AdSenseHostService service, string adClientId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (adClientId == null)
                    throw new ArgumentNullException(adClientId);

                // Make the request.
                return service.Adclients.Get(adClientId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Adclients.Get failed.", ex);
            }
        }

        public class AdclientsListOptionalParms
        {
            /// The maximum number of ad clients to include in the response, used for paging.
            public int MaxResults { get; set; }  
            /// A continuation token, used to page through ad clients. To retrieve the next page, set this parameter to the value of "nextPageToken" from the previous response.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// List all host ad clients in this AdSense account. 
        /// Documentation https://developers.google.com/adsensehost/v4.1/reference/adclients/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated AdSenseHost service.</param>  
        /// <param name="optional">Optional paramaters.</param>        /// <returns>AdClientsResponse</returns>
        public static AdClients List(AdSenseHostService service, AdclientsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Adclients.List();

                // Applying optional parameters to the request.                
                request = (AdclientsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Adclients.List failed.", ex);
            }
        }

        
	}
		public static class SampleHelpers
    {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}