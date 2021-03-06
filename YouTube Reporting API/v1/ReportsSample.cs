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
//     Build date: 01/02/2017 22:33:32
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the YouTubeReporting v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Schedules reporting jobs containing your YouTube Analytics data and downloads the resulting bulk data reports in the form of CSV files.
// API Documentation Link https://developers.google.com/youtube/reporting/v1/reports/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/YouTubeReporting/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.YouTubeReporting.v1/ 
// Install Command: PM>  Install-Package Google.Apis.YouTubeReporting.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.YouTubeReporting.v1;
using Google.Apis.YouTubeReporting.v1.Data;
using System;

namespace GoogleSamplecSharpSample.YouTubeReportingv1.Methods
{
  
    public static class ReportsSample
    {

        public class ReportsListOptionalParms
        {
            /// The content owner's external ID on which behalf the user is acting on. If not set, the user is acting for himself (his own channel).
            public string OnBehalfOfContentOwner { get; set; }  
            /// Requested page size. Server may return fewer report types than requested. If unspecified, server will pick an appropriate default.
            public int PageSize { get; set; }  
            /// A token identifying a page of results the server should return. Typically, this is the value of ListReportsResponse.next_page_token returned in response to the previous call to the `ListReports` method.
            public string PageToken { get; set; }  
            /// If set, only reports created after the specified date/time are returned.
            public string CreatedAfter { get; set; }  
            /// If set, only reports whose start time is greater than or equal the specified date/time are returned.
            public string StartTimeAtOrAfter { get; set; }  
            /// If set, only reports whose start time is smaller than the specified date/time are returned.
            public string StartTimeBefore { get; set; }  
        
        }
 
        /// <summary>
        /// Lists reports created by a specific job. Returns NOT_FOUND if the job does not exist. 
        /// Documentation https://developers.google.com/youtubereporting/v1/reference/reports/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated YouTubeReporting service.</param>  
        /// <param name="jobId">The ID of the job.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListReportsResponseResponse</returns>
        public static ListReportsResponse List(YouTubeReportingService service, string jobId, ReportsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (jobId == null)
                    throw new ArgumentNullException(jobId);

                // Building the initial request.
                var request = service.Reports.List(jobId);

                // Applying optional parameters to the request.                
                request = (ReportsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Reports.List failed.", ex);
            }
        }

        public class ReportsGetOptionalParms
        {
            /// The content owner's external ID on which behalf the user is acting on. If not set, the user is acting for himself (his own channel).
            public string OnBehalfOfContentOwner { get; set; }  
        
        }
 
        /// <summary>
        /// Gets the metadata of a specific report. 
        /// Documentation https://developers.google.com/youtubereporting/v1/reference/reports/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated YouTubeReporting service.</param>  
        /// <param name="jobId">The ID of the job.</param>
        /// <param name="reportId">The ID of the report to retrieve.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ReportResponse</returns>
        public static Report Get(YouTubeReportingService service, string jobId, string reportId, ReportsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (jobId == null)
                    throw new ArgumentNullException(jobId);
                if (reportId == null)
                    throw new ArgumentNullException(reportId);

                // Building the initial request.
                var request = service.Reports.Get(jobId, reportId);

                // Applying optional parameters to the request.                
                request = (ReportsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Reports.Get failed.", ex);
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