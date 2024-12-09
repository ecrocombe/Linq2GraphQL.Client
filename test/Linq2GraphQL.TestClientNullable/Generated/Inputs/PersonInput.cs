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

[JsonConverter(typeof(GraphInputConverter<PersonInput>))]
public partial class PersonInput : GraphInputBase
{
	[JsonPropertyName("name")]
	public required string Name 
	{
		get => GetValue<string>("name");
    	set => SetValue("name", value);
	}

	[JsonPropertyName("macAddress")]
	public MacAddress? MacAddress 
	{
		get => GetValue<MacAddress?>("macAddress");
    	set => SetValue("macAddress", value);
	}

	[JsonPropertyName("longitude")]
	public Longitude? Longitude 
	{
		get => GetValue<Longitude?>("longitude");
    	set => SetValue("longitude", value);
	}

}