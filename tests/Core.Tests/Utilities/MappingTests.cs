﻿using System;
using Epinova.ElasticSearch.Core.Enums;
using Epinova.ElasticSearch.Core.Utilities;
using TestData;
using Xunit;

namespace Core.Tests.Utilities
{
    public class MappingTests
    {
        public MappingTests()
        {
            Factory.SetupServiceLocator();
        }


        [Theory]
        [InlineData(typeof(string), MappingType.String)]
        [InlineData(typeof(bool), MappingType.Boolean)]
        [InlineData(typeof(bool?), MappingType.Boolean)]
        [InlineData(typeof(DateTime), MappingType.Date)]
        [InlineData(typeof(DateTime?), MappingType.Date)]
        [InlineData(typeof(double), MappingType.Double)]
        [InlineData(typeof(double?), MappingType.Double)]
        [InlineData(typeof(float), MappingType.Float)]
        [InlineData(typeof(float?), MappingType.Float)]
        [InlineData(typeof(decimal), MappingType.Float)]
        [InlineData(typeof(decimal?), MappingType.Float)]
        [InlineData(typeof(int), MappingType.Integer)]
        [InlineData(typeof(int?), MappingType.Integer)]
        [InlineData(typeof(byte), MappingType.Integer)]
        [InlineData(typeof(byte?), MappingType.Integer)]
        [InlineData(typeof(uint), MappingType.Integer)]
        [InlineData(typeof(uint?), MappingType.Integer)]
        [InlineData(typeof(short), MappingType.Integer)]
        [InlineData(typeof(short?), MappingType.Integer)]
        [InlineData(typeof(long), MappingType.Long)]
        [InlineData(typeof(long?), MappingType.Long)]
        [InlineData(typeof(string), MappingType.String)]
        [InlineData(typeof(Attribute), MappingType.String)]
        [InlineData(typeof(TestPage), MappingType.String)]
        public void GetMappingType_ReturnsCorrectType(Type type, MappingType expectedType)
        {
            MappingType result = Mapping.GetMappingType(type);

            Assert.Equal(expectedType, result);
        }
    }
}