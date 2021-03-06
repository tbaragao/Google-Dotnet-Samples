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
//     Build date: 01/02/2017 22:34:49
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the ToolResults v1beta3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Reads and publishes results from Cloud Test Lab.
// API Documentation Link https://developers.google.com/cloud-test-lab/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/ToolResults/v1beta3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.ToolResults.v1beta3/ 
// Install Command: PM>  Install-Package Google.Apis.ToolResults.v1beta3
//
//------------------------------------------------------------------------------  
using Google.Apis.ToolResults.v1beta3;
using Google.Apis.ToolResults.v1beta3.Data;
using System;

namespace GoogleSamplecSharpSample.ToolResultsv1beta3.Methods
{
  
    public static class ThumbnailsSample
    {

        public class ThumbnailsListOptionalParms
        {
            /// The maximum number of thumbnails to fetch.

Default value: 50. The server will use this default if the field is not set or has a value of 0.

Optional.
            public int PageSize { get; set; }  
            /// A continuation token to resume the query at the next item.

Optional.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists thumbnails of images attached to a step.

May return any of the following canonical error codes: - PERMISSION_DENIED - if the user is not authorized to read from the project, or from any of the images - INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the step does not exist, or if any of the images do not exist 
        /// Documentation https://developers.google.com/toolresults/v1beta3/reference/thumbnails/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated ToolResults service.</param>  
        /// <param name="projectId">A Project id.

Required.</param>
        /// <param name="historyId">A History id.

Required.</param>
        /// <param name="executionId">An Execution id.

Required.</param>
        /// <param name="stepId">A Step id.

Required.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListStepThumbnailsResponseResponse</returns>
        public static ListStepThumbnailsResponse List(ToolResultsService service, string projectId, string historyId, string executionId, string stepId, ThumbnailsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (historyId == null)
                    throw new ArgumentNullException(historyId);
                if (executionId == null)
                    throw new ArgumentNullException(executionId);
                if (stepId == null)
                    throw new ArgumentNullException(stepId);

                // Building the initial request.
                var request = service.Thumbnails.List(projectId, historyId, executionId, stepId);

                // Applying optional parameters to the request.                
                request = (ThumbnailsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Thumbnails.List failed.", ex);
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