using System;
using System.Collections.Generic;
using Xunit;

namespace PirateSpeak.Tests
{
    public class TestOfPirateWords
    {
        [Fact]
        public void word_is_a_pirate_word()
        {
            //arrange
            var wordToTranslate = "argh";
            var expectedResult = true;
            var translator = new PirateTranslator();
            //act
            var actualResult = translator.ConfirmPirateSpeak(wordToTranslate);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void word_is_possibly_scrambled_pirate_word()
        {
            //arrange
            var wordToTranslate = "hgar";
            var expectedResult = true;
            var translator = new PirateTranslator();
            //act
            var actualResult = translator.ConfirmPirateSpeak(wordToTranslate);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void given_a_word_suggest_possible_pirate_words()
        {
            //arrange
            var wordToTranslate = "ortsp";
            var possibleWords = new List<string> { "sport", "ports", "parrot", "scurvy" };
            var expectedResult = new List<string> { "sport", "ports" };
            var translator = new PirateTranslator();
            //act
            var actualResult = translator.Translate(wordToTranslate, possibleWords);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }


        public static IEnumerable<object[]> Data() {
            yield return new object[] { "ortsp", new List<string> { "sport", "ports", "matey", "plank" }, new List<string> { "sport", "ports" } };
            yield return new object[] { "lankp", new List<string> { "plank", "parrot" }, new List<string> { "plank" } };
            yield return new object[] { "cusrvy", new List<string> { "scurvy", "rum", "argh" }, new List<string> { "scurvy" } };
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void given_a_word_suggest_possible_pirate_words_theory(string wordToTranslate, List<string> possibleWords, List<string> suggestedWords)
        {
            //arrange
            var translator = new PirateTranslator();
            //act
            var actualResult = translator.Translate(wordToTranslate, possibleWords);
            //assert
            Assert.Equal(suggestedWords, actualResult);
        }

    }
}
