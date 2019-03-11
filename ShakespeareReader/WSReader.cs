using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ShakespeareReader
{
    public class WSReader
    {
        // Delays/Pauses used when outputting the text to the reader
        public static float DelayBetweenSentences = 1100;
        public static float DelayBetweenClauses = 740;
        public static float DelayBetweenWords = 270;
        public static float DelayBetweenCommas = 360;
        public static float TimeScale = 1;

        private static Action<string> ReaderOutputProcessorCallback = null;

        public static void SetReaderOutputAction(Action<string> callback)
        {
            ReaderOutputProcessorCallback = callback;
        }

        private static string[] GetProcessedSentences(string text)
        {
            return Regex.Split(text, @"(?<=[\.!\?])\s+");
        }

        private static string[] GetWordsFromSentence(string sentence)
        {
            return Regex.Split(sentence, @"\s+");
        }

        private static void ProcessLetter(char letter)
        {
            if (letter == ':' || letter == ';')
                Thread.Sleep((int)(DelayBetweenClauses / TimeScale));
            else if (letter == ',')
                Thread.Sleep((int)(DelayBetweenCommas / TimeScale));
        }
        private static void ReadShakespeareSingleSentence(string sentence)
        {
            string[] words = GetWordsFromSentence(sentence);
            foreach (string word in words)
            {
                if (word.Equals(word.ToUpper()) && !word.Equals("I"))
                {
                    // new character/person introduced in the script
                    ReaderOutputProcessorCallback("\r\n" + word + ":\r\n");
                    Thread.Sleep((int)(DelayBetweenWords / TimeScale));
                    continue;
                }

                Thread.Sleep((int)(DelayBetweenWords / TimeScale));
                ReaderOutputProcessorCallback(word + " ");

                foreach (char letter in word)
                    ProcessLetter(letter);
            }
        }

        private static void ReadShakespeareSentences(string[] sentences)
        {
            foreach (string sentence in sentences)
            {
                Thread.Sleep((int)(DelayBetweenSentences / TimeScale));
                ReadShakespeareSingleSentence(sentence);
            }
        }

        public static void ReadShakespeareText(string text)
        {
            string[] sentences = GetProcessedSentences(text);
            ReadShakespeareSentences(sentences);
        }
    }
}
