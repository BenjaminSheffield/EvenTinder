Synopsis

A mobile application which searches events in your local area and saves them to a database for you to refer back to. The app will alert the user before the day before the event will start. The user will swipe their way through the list of events.
C# backend using API
JavaScript/mobile frontend

Motivation

Every so often, people will complain that there is nothing to do or that their are no events on in their local area. This app aims to provide easy access to events with the ability to save events to the user's account. 

API Reference

The app will use the EventFinder API and extract the relevant information for each user. This API currently returns approximately 6000 events. The app will sort through the events based on the closest event date and the latitude longatude of the user.
