# CandidateFinder

Website created using ASP.NET MVC Core (2.2)

Contains 4 projects :
 - CandidateFinder.UI : MVC project. Contains UI layers (controllers, views...)
 - CandidateFinder.ApiClient : library wrapping access to JobAdder API. Return DTO's objects.
 - CandidateFinder.BusinessLayer : library containing business logic and services that retreive data from ApiClient, transform DTO to Models, compute candidate/job matching.
- CandidateFinder.Tests : Test project
 
 Assumptions:
 - display a list of possible candidates per job, ordered by relevance. (with a maximum number configurable)
 - a minimum of 2 matching skills for the candidate to be displayed in result list.
 - candidate skills are decreasing from strongest to weakest linearly
 - job skills are decreasing from most relevant to less relevant linearly
 
 To test the website, simple build and run with VisualStudio
