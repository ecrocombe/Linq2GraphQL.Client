
//---------------------------------------------------------------------
// This code was automatically generated by Linq2GraphQL.Generator
// Please don't edit this file
// Github: https://github.com/linq2graphql/linq2graphql.client
// Project:https://linq2graphql.com
// Generation Date: den 8 september 2024 16:27:56
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Linq2GraphQL.Client;
using Linq2GraphQL.Client.Common;

namespace Linq2GraphQL.TestClientNullable;

#pragma warning disable CS8618

public partial class OrderLine : GraphQLTypeBase
{
    [JsonPropertyName("lineNumber")]
	public int LineNumber { get; set; }  

    [JsonPropertyName("order")]
	public Order Order { get; set; }  

    [JsonPropertyName("item")]
	public Item? Item { get; set; }  

    [JsonPropertyName("price")]
	public decimal Price { get; set; }  

    [JsonPropertyName("quantity")]
	public double Quantity { get; set; }  

}
