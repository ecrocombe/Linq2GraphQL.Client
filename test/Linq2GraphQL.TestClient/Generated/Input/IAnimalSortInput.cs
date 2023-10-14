using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Linq2GraphQL.Client;

namespace Linq2GraphQL.TestClient;

[JsonConverter(typeof(GraphInputConverter<IAnimalSortInput>))]
public partial class IAnimalSortInput : GraphInputBase
{
	[JsonPropertyName("name")]
	public SortEnumType? Name 
	{
		get => GetValue<SortEnumType?>("name");
    	set => SetValue("name", value);
	}

	[JsonPropertyName("numberOfLegs")]
	public SortEnumType? NumberOfLegs 
	{
		get => GetValue<SortEnumType?>("numberOfLegs");
    	set => SetValue("numberOfLegs", value);
	}

}