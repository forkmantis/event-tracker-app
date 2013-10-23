Getting Started
===============

Clone the repo.

/src/EventTracker.NET/ - Intention is to be the src for all .NET related things.  Eventually side-by-side we'll add the android app etc.

Make sure you have IIS installed before opening the solution. http://technet.microsoft.com/en-us/library/cc725762.aspx

To build the solution, you need to make sure you have nuget package restore enabled. http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages

To start debugging, 'Start Debug', a page will load with an error (because we haven't created any pages yet), add /api/metadata/ to the localhost url and you should see some dummy services and their API.

Code!


event-tracker-app
=================

Android app for tracking times that user-defined events occurred.
