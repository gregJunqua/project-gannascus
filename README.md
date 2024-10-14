# project-gannascus


## Ship Position Tracker
Ship Position Tracker is a simple GUI application written in C# designed to help you track your ship's location and share it with the community. The program monitors screenshots, extracts position data, and posts it to a customizable URL, helping users visualize their position on a map.

## Features
### Customizable Settings:

Callsign: A user-defined string to represent the ship's identifier.
Ship Name: A user-defined string to represent the name of the ship.
Screenshot Folder: Specify the folder where screenshots will be monitored.
Custom URL: The endpoint where data is posted, with the default being https://maerk.org/spais/p.
### Automated Screenshot Monitoring:

Once a screenshot is added to the specified folder, the program will automatically:
Read the new screenshot.
Perform OCR (Optical Character Recognition) to extract text from the screenshot.
Identify the current object container's position.
### Data Posting:

The extracted data (callsign, ship name, position coordinates, and object container name) will be sent to the specified URL for further processing or display on a community map.
