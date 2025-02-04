## 24.1.1
* Fixed a bug where same, null, and empty keys were permitted in the Segmentation.
* Fixed an issue where some requests are not url encoded.

## 24.1.0
* New BackendMode features added and accesible through "Countly.Instance.BackendMode()" interface:
    * "ChangeDeviceIdWithMerge"
    * "RecordUserProperties"
    * "RecordException"
    * "RecordDirectRequest"
    * "EndSession"
    * "UpdateSession"
    * "BeginSession"
    * "StopView"
    * "StartView"

* Metric override is added and accessible through "CountlyConfig.SetMetricOverride()"
* "cpuId" and "multipleFields" device id generation methods are deprecated from Net Framework 3.5 and 4.5 versions

## 23.12.0
* Backend mode added and accesible through "Countly.Instance.BackendMode()" interface
* The following methods added to the "CountlyConfig":
    * "EnableBackendMode" function added to enable backend mode
    * "SetMaxRequestQueueSize" to change maximum request queue size, can be used only with backend mode for now
    * "SetMaxRequestQueueSize" to change maximum event queue size, can be used only with backend mode for now
    * "SetBackendModeAppEQSizeToSend" to change backend mode per app event cache maximum size
    * "SetBackendModeServerEQSizeToSend" to change backend mode global event cache maximum size

## 23.02.0
* !! Major breaking change !! Explicit support (and an SDK flavor) for "Portable Class Library Profile 259 (.NETFramework 4.5, Windows 8.0, WindowsPhone 8.0, WindowsPhoneApp 8.1)" has been removed.
* !! Major breaking change !! Explicit support (and an SDK flavor) for ".NET Framework 4.0 Client library" has been removed.
* !! Major breaking change !! Explicit support (and an SDK flavor) for "Universal Windows Platform" has been removed.
* !! Major breaking change !! The explicit "netcore" target has been removed from the nuspec configuration
* Added Explicit support and an SDK flavor for ".NET Framework 4.5"
* Default max segmentation value count changed from 30 to 100

## 22.06.1
* Fixed empty OS name issue when running the SDK '.NET Standard' flavor with .NET MAUI.
* Updating 'Newtonsoft.Json' version to '13.0.3'
* Fixed a bug where a "end session" request would be created incorrectly when removing "session" consent.

## 22.06.0
* Added ability to record location information or disable location tracking during SDK initialization.
* Fixed 'os name' in metrics, 'os name' on windows 11 was reporting wrong.
* Fixed a bug where added session requests were not sent immediately.

## 22.02.1
* Static method "AddBreadCrumb" is deprecated. A non static method called 'AddCrashBreadCrumb' was added as a replacement.
* For the UWP flavor of the SDK, changing the target version to "Windows 10, version 2004"

## 22.02.0
* ! Minor breaking change ! Device ID is now sticky during init. If a device ID value was acquired by the SDK before, it will now ignore the init-time provided custom device ID value.
* Added ability to get device id type.
* Added calls to record Timed Events.

## 21.11.2
* Fixed a bug where 'User properties' were not being recorded.

## 21.11.1
* Fixed wrong SDK version number and SDK name.
* Fixed potential issues where device ID was not encoded.
* Fixed bug where the correct consent state was not sent when consent was removed.

## 21.11.0
* !! Major breaking change !! Changing device ID without merging will now clear the current consent. Consent has to be given again after performing this action.
* ! Minor breaking change ! This release will introduce configurable maximum size limits for values and keys throughout the SDK. If they exceeded the limits, they would be truncated.
* When changing consent, the SDK will now send the full state of the consent and not just the delta.
* Added additional time and timezone related information to all requests.
* Added following new configuration fields to manipulate internal SDK value and key limits:
  1. `MaxKeyLength` Set the maximum size of all string keys. Default value is **128**.
  2. `MaxValueSize` Set the maximum size of all values in our key-value pairs. Default value is **256**.
  3. `MaxSegmentationValues` Set the maximum amount of custom (dev provided) segmentation in one event. Default value is **30**.
  4. `MaxStackTraceLinesPerThread` Set the limits how many stack trace lines would be recorded per thread. Default value is **30**.
  5. `MaxStackTraceLineLength` Set the limits how many characters are allowed per stack trace line. Default value is **200**.
  6. `MaxBreadcrumbCount` Set the maximum amount of breadcrumbs. Default value is **100**.
  
## 20.11.0
* Fixed bug that occurred while getting device and system information on restricted machines.
* Removed deprecated function "EndSession"
* Removed deprecated function "StartSession"
* [net35, net40] Removed deprecated function "SetCustomDataPath"
* PLC flavour (.NETPortable4.5-Profile259) is deprecated and will be removed on next major release

## 20.05.1
* Fixed bug that occured when no cpu_id was got returned from OS
* Fixed bug with API requests, which failed if the request data contained '&'

## 20.05
* Added sdk metadata to requests
* Improved handling of failed API requests
* Fixed null access bug in user details
* Fixed session duration bug in end session requests

## 19.08.1
* Fixed a consent bug regarding "view" consent.

## 19.08
* Added functionality to manually record views

## 19.02.1
* [Common, UWP] Reworked Storage for UWP so that it does not use PCLStorage

## 19.02
* Added support for uploading larger server requests
* Fixed metrics that might reveal more information about users then wanted

## 18.10.0
* Removing support for wp7 and wp8 platform targets
* SDK should now have xml documentation
* Refactored internals so that they are the same among all platform targets. Each target has it's own platform specific overrides.
* Assemblies are now strong name signed
* Transformed the 'Countly' from a static class into a singleton
* Added new init and session control calls
* [net35] Adding option for providing custom data path.
* DeviceId is now saved and loaded on each start
* Adding new ways for generating deviceId
* Added functionality to used developer supplied deviceId
* Added functionality to change deviceId with or without on server merge
* Added functionality to create events with duration
* Added functinality to send location
* Adding functionality for user feature consent
* Added locale to metrics
* Fixed deserialization bugs
* Fixed bug where crashes would not show up in dashboard
* Fixed a timestamp bug

## 18.1.0
* Fixing multithreading bug
* Adding multithreading protections
* Adding UWP as target platform
