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
//     Build date: 01/02/2017 22:34:26
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the Sheets v4 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Reads and writes Google Sheets.
// API Documentation Link https://developers.google.com/sheets/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Sheets/v4/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Sheets.v4/ 
// Install Command: PM>  Install-Package Google.Apis.Sheets.v4
//
//------------------------------------------------------------------------------  
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;

namespace GoogleSamplecSharpSample.Sheetsv4.Methods
{
  
    public static class SheetsSample
    {


        /// <summary>
        /// Copies a single sheet from a spreadsheet to another spreadsheet.
Returns the properties of the newly created sheet. 
        /// Documentation https://developers.google.com/sheets/v4/reference/sheets/copyTo
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sheets service.</param>  
        /// <param name="spreadsheetId">The ID of the spreadsheet containing the sheet to copy.</param>
        /// <param name="sheetId">The ID of the sheet to copy.</param>
        /// <param name="body">A valid Sheets v4 body.</param>
        /// <returns>SheetPropertiesResponse</returns>
        public static SheetProperties CopyTo(SheetsService service, string spreadsheetId, int sheetId, CopySheetToAnotherSpreadsheetRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (spreadsheetId == null)
                    throw new ArgumentNullException(spreadsheetId);

                // Make the request.
                return service.Sheets.CopyTo(body, spreadsheetId, sheetId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Sheets.CopyTo failed.", ex);
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