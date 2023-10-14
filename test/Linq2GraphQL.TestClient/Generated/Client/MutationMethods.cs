using System.Collections.Generic;
using System;
using Linq2GraphQL.Client;

namespace Linq2GraphQL.TestClient;

public class MutationMethods
{
    private readonly GraphClient client;

    public MutationMethods(GraphClient client)
    {
        this.client = client;
    }

    public GraphQuery<string> SetName(string name = null)
    {
	    var arguments = new List<ArgumentValue>
        {
    	    new("name","String", name),
        };

        return new GraphQuery<string>(client,  "setName", OperationType.Mutation, arguments); 
    }

    public GraphQuery<Customer> AddCustomer(CustomerInput customer = null)
    {
	    var arguments = new List<ArgumentValue>
        {
    	    new("customer","CustomerInput", customer),
        };

        return new GraphQuery<Customer>(client,  "addCustomer", OperationType.Mutation, arguments); 
    }

    }
