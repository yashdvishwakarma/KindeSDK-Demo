# KindeSDK-Demo

This repository demonstrates a minimal .NET SDK wrapper for Kinde's authentication API, focused on **improving exception handling and error transparency**.

It addresses two key areas that are often flagged in SDK reviews:
- Structured exception handling using a custom `KindeAuthenticationException` instead of generic `ApplicationException`.
- Meaningful error messages that can be logged and traced in production.
- Separation of concerns with dedicated classes for authentication logic and exception handling.

## Usage

1. Clone the repository.
2. Replace `"your-client-id"` and `"your-client-secret"` in `Program.cs` with your Kinde credentials.
3. Run the application to see the authentication process in action.
4. On failure, a `KindeAuthenticationException` will provide clear details about the issue.

## Why this matters

This demo shows how the SDK can be enhanced to:
- Improve troubleshooting without requiring a debugger.
- Support observability tools (e.g., Application Insights, DataDog, OpenTelemetry).
- Align with .NET best practices (avoiding `ApplicationException`).

## License

This project is licensed under the MIT License.


