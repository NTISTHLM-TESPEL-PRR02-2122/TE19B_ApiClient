using System;
using RestSharp;


RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest pokeRequest = new RestRequest("pokemon/genesect");
IRestResponse pokeResponse = pokeClient.Get(pokeRequest);

Console.WriteLine(pokeResponse.Content);

Console.ReadLine();

// Blajj 1