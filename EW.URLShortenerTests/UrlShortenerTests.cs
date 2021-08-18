using System;
using EW.URLShortener.Utils;
using Xunit;

namespace EW.URLShortenerTests
{
    public class UrlShortenerTests
    {
        [Fact]
        public void TestEmptyResult()
        {
            var urlShortener = new UrlShortener();
            var result = urlShortener.ShortenUrl("https://github.com/entwicklerMe/tw-az-url-shortener-with-csharp");
            
            Assert.Equal("", result);
        }
    }
}