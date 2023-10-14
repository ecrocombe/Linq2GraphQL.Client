using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Linq2GraphQL.Client;

namespace Linq2GraphQL.TestClient;

[JsonConverter(typeof(GraphInputConverter<AddressFilterInput>))]
public partial class AddressFilterInput : GraphInputBase
{
	[JsonPropertyName("and")]
	public List<AddressFilterInput> And 
	{
		get => GetValue<List<AddressFilterInput>>("and");
    	set => SetValue("and", value);
	}

	[JsonPropertyName("or")]
	public List<AddressFilterInput> Or 
	{
		get => GetValue<List<AddressFilterInput>>("or");
    	set => SetValue("or", value);
	}

	[JsonPropertyName("name")]
	public StringOperationFilterInput Name 
	{
		get => GetValue<StringOperationFilterInput>("name");
    	set => SetValue("name", value);
	}

	[JsonPropertyName("street")]
	public StringOperationFilterInput Street 
	{
		get => GetValue<StringOperationFilterInput>("street");
    	set => SetValue("street", value);
	}

	[JsonPropertyName("postalCode")]
	public StringOperationFilterInput PostalCode 
	{
		get => GetValue<StringOperationFilterInput>("postalCode");
    	set => SetValue("postalCode", value);
	}

}