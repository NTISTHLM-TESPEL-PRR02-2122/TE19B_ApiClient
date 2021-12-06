using System;
using System.Text.Json;
using RestSharp;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest pokeRequest = new RestRequest("pokemon/genesect");
IRestResponse pokeResponse = pokeClient.Get(pokeRequest);
// Console.WriteLine(pokeResponse.Content);

Pokemon p = JsonSerializer.Deserialize<Pokemon>(pokeResponse.Content);

Console.WriteLine(p.name);


// RestClient swClient = new RestClient("https://swapi.dev/api/");
// RestRequest swRequest = new RestRequest("people/50");
// IRestResponse swResponse = swClient.Get(swRequest);
// Console.WriteLine(swResponse.Content);

// Person p = JsonSerializer.Deserialize<Person>(swResponse.Content);

// Console.WriteLine(p.name);

Console.ReadLine();
