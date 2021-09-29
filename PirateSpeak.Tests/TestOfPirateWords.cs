using System;
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
            var actualResult = translator.Translate(wordToTranslate);
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
            var actualResult = translator.Translate(wordToTranslate);
            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
