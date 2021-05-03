using Bunit;
using bUnitTest.Web.Pages;
using System;
using Xunit;

namespace bUnitTest.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CounterShouldIncrementWhenSelected()
        {
            // Arrange
            using var ctx = new TestContext();
            var counterComponent = ctx.RenderComponent<Counter>();
            var paraElm = counterComponent.Find("p");

            // Act
            counterComponent.Find("button").Click();
            var paraElmText = paraElm.TextContent;

            // Assert
            paraElmText.MarkupMatches("Current count: 1");
        }
    }
}
