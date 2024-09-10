// <copyright file="Tests.cs" company="Transilvania University of Brasov">
// Copyright (c) Transilvania University of Brasov.
// Student name: Volontir Oleg.
// All rights reserved.
// </copyright>

namespace AuctionPlace.Test
{
    using Rhino.Mocks;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var mockRep = new MockRepository();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}