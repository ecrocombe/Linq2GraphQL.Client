
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

namespace Linq2GraphQL.TestClientNullable;

[JsonConverter(typeof(GraphInputConverter<CustomerInput>))]
public partial class CustomerInput : GraphInputBase
{
	[JsonPropertyName("customerId")]
	public required Guid CustomerId 
	{
		get => GetValue<Guid>("customerId");
    	set => SetValue("customerId", value);
	}

	[JsonPropertyName("customerName")]
	public required string CustomerName 
	{
		get => GetValue<string>("customerName");
    	set => SetValue("customerName", value);
	}

	[JsonPropertyName("status")]
	public required CustomerStatus Status 
	{
		get => GetValue<CustomerStatus>("status");
    	set => SetValue("status", value);
	}

	[JsonPropertyName("orders")]
	public required List<OrderInput> Orders 
	{
		get => GetValue<List<OrderInput>>("orders");
    	set => SetValue("orders", value);
	}

	[JsonPropertyName("address")]
	public AddressInput? Address 
	{
		get => GetValue<AddressInput?>("address");
    	set => SetValue("address", value);
	}

}