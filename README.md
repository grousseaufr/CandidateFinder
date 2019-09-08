# CandidateFinder

Website created using ASP.NET MVC Core.

Contains 3 project :
 - CandidateFinder.UI : MVC project. Contains UI layers (controllers, views...)
 - CandidateFinder.ApiClient : library wrapping access to JobAdder API. Return DTO's objects.
 - CandidateFind.BusinessLayer : contains business logic and services that retreive data from ApiClient, transform DTO to Models.
 
 Assumptions:
 - skills ans skillTags items cannot contain white space.
