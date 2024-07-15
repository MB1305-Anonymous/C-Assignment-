// 1. 1. Mood-based Music Recommender

namespace Assignment01;

using System;

public class MusicRecommender
{
    public static string GetMusicRecommendation(string mood)
    {
        switch (mood.ToLower())
        {
            case "happy":
                return " Yay!!!! Upbeat pop songs to keep you cheerful :D!";
            case "sad":
                return " Awwnn Melancholic songs to match your mood :( ";
            case "energetic":
                return " Alrighty! High-tempo, rock or electronic music to boost your energy !!!";
            case "relaxed":
                return " Ahhhh Smooth jazz or acoustic tunes for a calming effect.";
            default:
                return " A mix of genres to explore!";
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your mood:");
        string mood = Console.ReadLine();
        string recommendation = GetMusicRecommendation(mood);
        Console.WriteLine(recommendation);
    }
    
}


