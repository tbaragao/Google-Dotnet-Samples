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
//     Build date: 01/02/2017 22:33:41
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the Logging v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Writes log entries and manages your Stackdriver Logging configuration.
// API Documentation Link https://cloud.google.com/logging/docs/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Logging/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Logging.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Logging.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Logging.v2;
using Google.Apis.Logging.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Loggingv2.Methods
{
  
    public static class MetricsSample
    {


        /// <summary>
        /// Creates or updates a logs-based metric. 
        /// Documentation https://developers.google.com/logging/v2/reference/metrics/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Logging service.</param>  
        /// <param name="metricName">The resource name of the metric to update:
"projects/[PROJECT_ID]/metrics/[METRIC_ID]"
The updated metric must be provided in the request and it's name field must be the same as [METRIC_ID] If the metric does not exist in [PROJECT_ID], then a new metric is created.</param>
        /// <param name="body">A valid Logging v2 body.</param>
        /// <returns>LogMetricResponse</returns>
        public static LogMetric Update(LoggingService service, string metricName, LogMetric body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (metricName == null)
                    throw new ArgumentNullException(metricName);

                // Make the request.
                return service.Metrics.Update(body, metricName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Metrics.Update failed.", ex);
            }
        }


        /// <summary>
        /// Gets a logs-based metric. 
        /// Documentation https://developers.google.com/logging/v2/reference/metrics/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Logging service.</param>  
        /// <param name="metricName">The resource name of the desired metric:
"projects/[PROJECT_ID]/metrics/[METRIC_ID]"
</param>
        /// <returns>LogMetricResponse</returns>
        public static LogMetric Get(LoggingService service, string metricName)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (metricName == null)
                    throw new ArgumentNullException(metricName);

                // Make the request.
                return service.Metrics.Get(metricName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Metrics.Get failed.", ex);
            }
        }


        /// <summary>
        /// Creates a logs-based metric. 
        /// Documentation https://developers.google.com/logging/v2/reference/metrics/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Logging service.</param>  
        /// <param name="parent">The resource name of the project in which to create the metric:
"projects/[PROJECT_ID]"
The new metric must be provided in the request.</param>
        /// <param name="body">A valid Logging v2 body.</param>
        /// <returns>LogMetricResponse</returns>
        public static LogMetric Create(LoggingService service, string parent, LogMetric body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (parent == null)
                    throw new ArgumentNullException(parent);

                // Make the request.
                return service.Metrics.Create(body, parent).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Metrics.Create failed.", ex);
            }
        }

        public class MetricsListOptionalParms
        {
            /// Optional. The maximum number of results to return from this request. Non-positive values are ignored. The presence of nextPageToken in the response indicates that more results might be available.
            public int PageSize { get; set; }  
            /// Optional. If present, then retrieve the next batch of results from the preceding call to this method. pageToken must be the value of nextPageToken from the previous response. The values of other method parameters should be identical to those in the previous call.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists logs-based metrics. 
        /// Documentation https://developers.google.com/logging/v2/reference/metrics/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Logging service.</param>  
        /// <param name="parent">Required. The name of the project containing the metrics:
"projects/[PROJECT_ID]"
</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>ListLogMetricsResponseResponse</returns>
        public static ListLogMetricsResponse List(LoggingService service, string parent, MetricsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (parent == null)
                    throw new ArgumentNullException(parent);

                // Building the initial request.
                var request = service.Metrics.List(parent);

                // Applying optional parameters to the request.                
                request = (MetricsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Metrics.List failed.", ex);
            }
        }


        /// <summary>
        /// Deletes a logs-based metric. 
        /// Documentation https://developers.google.com/logging/v2/reference/metrics/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Logging service.</param>  
        /// <param name="metricName">The resource name of the metric to delete:
"projects/[PROJECT_ID]/metrics/[METRIC_ID]"
</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(LoggingService service, string metricName)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (metricName == null)
                    throw new ArgumentNullException(metricName);

                // Make the request.
                return service.Metrics.Delete(metricName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Metrics.Delete failed.", ex);
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