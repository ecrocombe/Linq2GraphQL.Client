//---------------------------------------------------------------------
// This code was automatically generated by Linq2GraphQL
// Please don't edit this file
// Github:https://github.com/linq2graphql/linq2graphql.client
// Url: https://linq2graphql.com
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Linq2GraphQL.Client;

namespace Linq2GraphQL.TestClientNullable;

[JsonConverter(typeof(GraphInputConverter<OrderInput>))]
public partial class OrderInput : GraphInputBase
{
	[JsonPropertyName("orderId")]
	public required Guid OrderId 
	{
		get => GetValue<Guid>("orderId");
    	set => SetValue("orderId", value);
	}

	[JsonPropertyName("customer")]
	public required CustomerInput Customer 
	{
		get => GetValue<CustomerInput>("customer");
    	set => SetValue("customer", value);
	}

	[JsonPropertyName("address")]
	public AddressInput? Address 
	{
		get => GetValue<AddressInput?>("address");
    	set => SetValue("address", value);
	}

	[JsonPropertyName("orderDate")]
	public required DateTimeOffset OrderDate 
	{
		get => GetValue<DateTimeOffset>("orderDate");
    	set => SetValue("orderDate", value);
	}

	[JsonPropertyName("lines")]
	public required List<OrderLineInput> Lines 
	{
		get => GetValue<List<OrderLineInput>>("lines");
    	set => SetValue("lines", value);
	}

	[JsonPropertyName("entryTime")]
	public TimeSpan? EntryTime 
	{
		get => GetValue<TimeSpan?>("entryTime");
    	set => SetValue("entryTime", value);
	}

}