using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Linq2GraphQL.Client;

namespace Linq2GraphQL.TestClient;

[JsonConverter(typeof(GraphInputConverter<OrderFilterInput>))]
public partial class OrderFilterInput : GraphInputBase
{
	[JsonPropertyName("and")]
	public List<OrderFilterInput> And 
	{
		get => GetValue<List<OrderFilterInput>>("and");
    	set => SetValue("and", value);
	}

	[JsonPropertyName("or")]
	public List<OrderFilterInput> Or 
	{
		get => GetValue<List<OrderFilterInput>>("or");
    	set => SetValue("or", value);
	}

	[JsonPropertyName("orderId")]
	public UuidOperationFilterInput OrderId 
	{
		get => GetValue<UuidOperationFilterInput>("orderId");
    	set => SetValue("orderId", value);
	}

	[JsonPropertyName("customer")]
	public CustomerFilterInput Customer 
	{
		get => GetValue<CustomerFilterInput>("customer");
    	set => SetValue("customer", value);
	}

	[JsonPropertyName("address")]
	public AddressFilterInput Address 
	{
		get => GetValue<AddressFilterInput>("address");
    	set => SetValue("address", value);
	}

	[JsonPropertyName("orderDate")]
	public DateTimeOperationFilterInput OrderDate 
	{
		get => GetValue<DateTimeOperationFilterInput>("orderDate");
    	set => SetValue("orderDate", value);
	}

	[JsonPropertyName("lines")]
	public ListFilterInputTypeOfOrderLineFilterInput Lines 
	{
		get => GetValue<ListFilterInputTypeOfOrderLineFilterInput>("lines");
    	set => SetValue("lines", value);
	}

}