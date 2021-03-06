---
title: RecordingJob
---
## ININ.PureCloudApi.Model.RecordingJob

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **State** | **string** | The current state of the job. | |
| **RecordingJobsQuery** | [**RecordingJobsQuery**](RecordingJobsQuery.html) | Original query of the job. | [optional] |
| **DateCreated** | **DateTime?** | Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **TotalConversations** | **int?** | Total number of conversations affected. | [optional] |
| **TotalRecordings** | **int?** | Total number of recordings affected. | [optional] |
| **TotalProcessedRecordings** | **int?** | Total number of recordings have been processed. | [optional] |
| **PercentProgress** | **int?** | Progress in percentage based on the number of recordings | [optional] |
| **ErrorMessage** | **string** | Error occurred during the job execution | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
| **User** | [**AddressableEntityRef**](AddressableEntityRef.html) | Details of the user created the job | [optional] |
{: class="table table-striped"}


