
//---------------------------------------------------------------------
// This code was automatically generated by Linq2GraphQL.Generator
// Please don't edit this file
// Github: https://github.com/linq2graphql/linq2graphql.client
// Project:https://linq2graphql.com
// Generation Date: den 8 september 2024 16:27:56
//---------------------------------------------------------------------


using Linq2GraphQL.Client;
using System.Text.Json.Serialization;

namespace Linq2GraphQL.TestClientNullable;

    /// <summary>
    /// The Longitude scalar type is a valid decimal degrees longitude number.
    /// </summary>
    [JsonConverter(typeof(CustomScalarConverter<Longitude>))]
    public partial class Longitude : CustomScalar {}