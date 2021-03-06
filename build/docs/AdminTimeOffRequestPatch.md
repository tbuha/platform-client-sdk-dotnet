---
title: AdminTimeOffRequestPatch
---
## ININ.PureCloudApi.Model.AdminTimeOffRequestPatch

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Status** | **string** | The status of this time off request | [optional] |
| **ActivityCodeId** | **string** | The ID of the activity code associated with this time off request. Activity code must be of the TimeOff category | [optional] |
| **Notes** | **string** | Notes about the time off request | [optional] |
| **FullDayManagementUnitDates** | **List&lt;string&gt;** | A set of dates in yyyy-MM-dd format.  Should be interpreted in the management unit&#39;s configured time zone. | [optional] |
| **PartialDayStartDateTimes** | **List&lt;DateTime?&gt;** | A set of start date-times in ISO-8601 format for partial day requests. | [optional] |
| **DailyDurationMinutes** | **int?** | The daily duration of this time off request in minutes | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for the time off request | |
{: class="table table-striped"}


