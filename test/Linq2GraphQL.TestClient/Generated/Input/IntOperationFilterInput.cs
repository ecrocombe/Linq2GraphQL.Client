using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Linq2GraphQL.Client;

namespace Linq2GraphQL.TestClient;

[JsonConverter(typeof(GraphInputConverter<IntOperationFilterInput>))]
public partial class IntOperationFilterInput : GraphInputBase
{
	[JsonPropertyName("eq")]
	public int? Eq 
	{
		get => GetValue<int?>("eq");
    	set => SetValue("eq", value);
	}

	[JsonPropertyName("neq")]
	public int? Neq 
	{
		get => GetValue<int?>("neq");
    	set => SetValue("neq", value);
	}

	[JsonPropertyName("in")]
	public List<int?> In 
	{
		get => GetValue<List<int?>>("in");
    	set => SetValue("in", value);
	}

	[JsonPropertyName("nin")]
	public List<int?> Nin 
	{
		get => GetValue<List<int?>>("nin");
    	set => SetValue("nin", value);
	}

	[JsonPropertyName("gt")]
	public int? Gt 
	{
		get => GetValue<int?>("gt");
    	set => SetValue("gt", value);
	}

	[JsonPropertyName("ngt")]
	public int? Ngt 
	{
		get => GetValue<int?>("ngt");
    	set => SetValue("ngt", value);
	}

	[JsonPropertyName("gte")]
	public int? Gte 
	{
		get => GetValue<int?>("gte");
    	set => SetValue("gte", value);
	}

	[JsonPropertyName("ngte")]
	public int? Ngte 
	{
		get => GetValue<int?>("ngte");
    	set => SetValue("ngte", value);
	}

	[JsonPropertyName("lt")]
	public int? Lt 
	{
		get => GetValue<int?>("lt");
    	set => SetValue("lt", value);
	}

	[JsonPropertyName("nlt")]
	public int? Nlt 
	{
		get => GetValue<int?>("nlt");
    	set => SetValue("nlt", value);
	}

	[JsonPropertyName("lte")]
	public int? Lte 
	{
		get => GetValue<int?>("lte");
    	set => SetValue("lte", value);
	}

	[JsonPropertyName("nlte")]
	public int? Nlte 
	{
		get => GetValue<int?>("nlte");
    	set => SetValue("nlte", value);
	}

}