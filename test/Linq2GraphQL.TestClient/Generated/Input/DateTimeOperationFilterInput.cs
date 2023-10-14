using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Linq2GraphQL.Client;

namespace Linq2GraphQL.TestClient;

[JsonConverter(typeof(GraphInputConverter<DateTimeOperationFilterInput>))]
public partial class DateTimeOperationFilterInput : GraphInputBase
{
	[JsonPropertyName("eq")]
	public DateTimeOffset? Eq 
	{
		get => GetValue<DateTimeOffset?>("eq");
    	set => SetValue("eq", value);
	}

	[JsonPropertyName("neq")]
	public DateTimeOffset? Neq 
	{
		get => GetValue<DateTimeOffset?>("neq");
    	set => SetValue("neq", value);
	}

	[JsonPropertyName("in")]
	public List<DateTimeOffset?> In 
	{
		get => GetValue<List<DateTimeOffset?>>("in");
    	set => SetValue("in", value);
	}

	[JsonPropertyName("nin")]
	public List<DateTimeOffset?> Nin 
	{
		get => GetValue<List<DateTimeOffset?>>("nin");
    	set => SetValue("nin", value);
	}

	[JsonPropertyName("gt")]
	public DateTimeOffset? Gt 
	{
		get => GetValue<DateTimeOffset?>("gt");
    	set => SetValue("gt", value);
	}

	[JsonPropertyName("ngt")]
	public DateTimeOffset? Ngt 
	{
		get => GetValue<DateTimeOffset?>("ngt");
    	set => SetValue("ngt", value);
	}

	[JsonPropertyName("gte")]
	public DateTimeOffset? Gte 
	{
		get => GetValue<DateTimeOffset?>("gte");
    	set => SetValue("gte", value);
	}

	[JsonPropertyName("ngte")]
	public DateTimeOffset? Ngte 
	{
		get => GetValue<DateTimeOffset?>("ngte");
    	set => SetValue("ngte", value);
	}

	[JsonPropertyName("lt")]
	public DateTimeOffset? Lt 
	{
		get => GetValue<DateTimeOffset?>("lt");
    	set => SetValue("lt", value);
	}

	[JsonPropertyName("nlt")]
	public DateTimeOffset? Nlt 
	{
		get => GetValue<DateTimeOffset?>("nlt");
    	set => SetValue("nlt", value);
	}

	[JsonPropertyName("lte")]
	public DateTimeOffset? Lte 
	{
		get => GetValue<DateTimeOffset?>("lte");
    	set => SetValue("lte", value);
	}

	[JsonPropertyName("nlte")]
	public DateTimeOffset? Nlte 
	{
		get => GetValue<DateTimeOffset?>("nlte");
    	set => SetValue("nlte", value);
	}

}