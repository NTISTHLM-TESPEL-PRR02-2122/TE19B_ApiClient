using System;
using RestSharp;


RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest pokeRequest = new RestRequest("pokemon/genesect");
IRestResponse pokeResponse = pokeClient.Get(pokeRequest);

Console.WriteLine(pokeResponse.Content);

Console.ReadLine();
<<<<<<< HEAD

// Blajj
// Blajj 2
// Blajj 3
=======
>>>>>>> parent of 1eaaf15 (Test 1)
