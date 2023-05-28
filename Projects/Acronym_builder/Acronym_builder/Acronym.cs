using System;
using System.Collections.Generic;

namespace Acronym_builder
{
    internal class Acronym
    {
      
        private string fullSentence;
        private string[] words;
        private Dictionary<char, string> acronymDictionary;

        // Constructor that initializes the fields with the input sentence
        public Acronym(string sentence)
        {
            fullSentence = sentence;
            words = fullSentence.Split(' '); // Split the sentence into individual words
            acronymDictionary = new Dictionary<char, string>(); // Initialize an empty dictionary to store the acronym
        }

        // Method that builds the acronym from the words in the sentence
        public void BuildAcronym()
        {
            foreach (string word in words)
            {
                char firstLetter = char.ToUpper(word[0]); // Get the first letter of the word and convert it to uppercase
                if (acronymDictionary.ContainsKey(firstLetter))
                {
                    // If the dictionary already contains a word starting with this letter, use lowercase instead
                    firstLetter = char.ToLower(word[0]);
                }
                acronymDictionary.Add(firstLetter, word); // Add the word to the dictionary with the first letter as the key
            }
        }

        // Method that displays the generated acronym
        public void DisplayAcronym()
        {
            string acronym = "";
            foreach (KeyValuePair<char, string> pair in acronymDictionary)
            {
                acronym += pair.Key; 
            }
            Console.WriteLine("The acronym for '{0}' is: {1}", fullSentence, acronym); // Display the generated acronym
        }
    }
}