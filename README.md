# MathematicsExtension Utility for Unity

## Introduction
The `MathematicsExtension` utility, part of the `com.Klazapp.Utility` namespace, provides a robust mathematical foundation and includes a variety of built-in mathematical functions and classes. Developers often leverage Unity's Mathf and Vector classes, as well as other mathematical functionalities, for tasks such as transformations, calculations, and simulations within Unity applications.

## Features
- Toggle switch for easy enable/disable of log messages.
- Color-coded methods for standard, error, and warning messages.
- Conditional compilation for inclusion in builds with logging enabled.

## Dependencies
To use `LogMessage`, certain dependencies are required. Ensure these are included in your Unity project.
- **Unity Version**: Minimum Unity 2020.3 LTS.
- **Repository**: [LogMessage Unity Logger](https://github.com/klazapp/Unity-Logger-Public.git)

## Compatibility
| Compatibility        | URP | BRP | HDRP |
|----------------------|-----|-----|------|
| Compatible           | ✔️  | ✔️  | ✔️   |

## Installation
1. Open the Unity Package Manager (`Window` > `Package Manager`).
2. Click `+`, select `Add package from git URL...`, and enter `https://github.com/klazapp/Unity-Logger-Public.git`.
3. Unity will download and make the package available in your project.

## Usage
```csharp
LogMessage.Debug("This is a debug message");
LogMessage.DebugError("This is an error message");
LogMessage.DebugWarning("This is a warning message");
```
Enable logging by defining `ENABLE_LOGS` in your project's compilation symbols.

## To-Do List (Future Features)
- **File Logging**: Option to save logs to a file for post-mortem analysis.
- **Log Level Settings**: Configurable settings to control the level of detail in the logs:
  - **Verbose**: Detailed information, typically useful only when diagnosing problems.
  - ~~**Debug**~~: Information useful for developers in the debugging phase.
  - **Info**: General information about application processes.
  - ~~**Warning**~~: Indications of possible issues or useful warnings for the user.
  - ~~**Error**~~: Critical problems that might cause system failure.
- **User-Defined Categories**: Custom categories for logs to organize and filter messages easily.
- **Context-Enhanced Logging**: Include class and script names in logs for precise source identification.

## License
This utility is released under the [MIT License](LICENSE).
