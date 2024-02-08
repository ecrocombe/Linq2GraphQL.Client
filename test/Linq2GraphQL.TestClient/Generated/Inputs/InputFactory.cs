using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Linq2GraphQL.Client;

namespace Linq2GraphQL.TestClient;

public static class IF 
{ 
	public static AddressFilterInput AddressFilter() 
	{
		return new AddressFilterInput();
	}
	public static AddressInput Address() 
	{
		return new AddressInput();
	}
	public static AddressSortInput AddressSort() 
	{
		return new AddressSortInput();
	}
	public static CustomerFilterInput CustomerFilter() 
	{
		return new CustomerFilterInput();
	}
	public static CustomerInput Customer() 
	{
		return new CustomerInput();
	}
	public static CustomerSortInput CustomerSort() 
	{
		return new CustomerSortInput();
	}
	public static CustomerStatusOperationFilterInput CustomerStatusOperationFilter() 
	{
		return new CustomerStatusOperationFilterInput();
	}
	public static DateTimeOperationFilterInput DateTimeOperationFilter() 
	{
		return new DateTimeOperationFilterInput();
	}
	public static DecimalOperationFilterInput DecimalOperationFilter() 
	{
		return new DecimalOperationFilterInput();
	}
	public static FloatOperationFilterInput FloatOperationFilter() 
	{
		return new FloatOperationFilterInput();
	}
	public static IAnimalFilterInput IAnimalFilter() 
	{
		return new IAnimalFilterInput();
	}
	public static IAnimalSortInput IAnimalSort() 
	{
		return new IAnimalSortInput();
	}
	public static IntOperationFilterInput IntOperationFilter() 
	{
		return new IntOperationFilterInput();
	}
	public static ItemFilterInput ItemFilter() 
	{
		return new ItemFilterInput();
	}
	public static ItemInput Item() 
	{
		return new ItemInput();
	}
	public static ListFilterInputTypeOfOrderFilterInput ListFilterInputTypeOfOrderFilter() 
	{
		return new ListFilterInputTypeOfOrderFilterInput();
	}
	public static ListFilterInputTypeOfOrderLineFilterInput ListFilterInputTypeOfOrderLineFilter() 
	{
		return new ListFilterInputTypeOfOrderLineFilterInput();
	}
	public static OrderFilterInput OrderFilter() 
	{
		return new OrderFilterInput();
	}
	public static OrderInput Order() 
	{
		return new OrderInput();
	}
	public static OrderLineFilterInput OrderLineFilter() 
	{
		return new OrderLineFilterInput();
	}
	public static OrderLineInput OrderLine() 
	{
		return new OrderLineInput();
	}
	public static OrderSortInput OrderSort() 
	{
		return new OrderSortInput();
	}
	public static StringOperationFilterInput StringOperationFilter() 
	{
		return new StringOperationFilterInput();
	}
	public static UuidOperationFilterInput UuidOperationFilter() 
	{
		return new UuidOperationFilterInput();
	}
}



public static class AddressFilterInputExtensions
{ 
	    public static AddressFilterInput And(this AddressFilterInput input, Action<List<AddressFilterInput>> mod)
    {
        var filter = new List<AddressFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.And = filter;
        return input;
    }

    public static AddressFilterInput Or(this AddressFilterInput input, Action<List<AddressFilterInput>> mod)
    {
        var filter = new List<AddressFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.Or = filter;
        return input;
    }

    public static AddressFilterInput Name(this AddressFilterInput input, Action<StringOperationFilterInput> mod)
    {
        var filter = new StringOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Name = filter;
        return input;
    }

    public static AddressFilterInput Street(this AddressFilterInput input, Action<StringOperationFilterInput> mod)
    {
        var filter = new StringOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Street = filter;
        return input;
    }

    public static AddressFilterInput PostalCode(this AddressFilterInput input, Action<StringOperationFilterInput> mod)
    {
        var filter = new StringOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.PostalCode = filter;
        return input;
    }

}

public static class AddressInputExtensions
{ 
	
    public static AddressInput Name(this AddressInput input, string val)
    {
         input.Name = val;
         return input;
    }


    public static AddressInput Street(this AddressInput input, string val)
    {
         input.Street = val;
         return input;
    }


    public static AddressInput PostalCode(this AddressInput input, string val)
    {
         input.PostalCode = val;
         return input;
    }

}

public static class AddressSortInputExtensions
{ 
	
    public static AddressSortInput Name(this AddressSortInput input, SortEnumType? val)
    {
         input.Name = val;
         return input;
    }


    public static AddressSortInput Street(this AddressSortInput input, SortEnumType? val)
    {
         input.Street = val;
         return input;
    }


    public static AddressSortInput PostalCode(this AddressSortInput input, SortEnumType? val)
    {
         input.PostalCode = val;
         return input;
    }

}

public static class CustomerFilterInputExtensions
{ 
	    public static CustomerFilterInput And(this CustomerFilterInput input, Action<List<CustomerFilterInput>> mod)
    {
        var filter = new List<CustomerFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.And = filter;
        return input;
    }

    public static CustomerFilterInput Or(this CustomerFilterInput input, Action<List<CustomerFilterInput>> mod)
    {
        var filter = new List<CustomerFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.Or = filter;
        return input;
    }

    public static CustomerFilterInput CustomerId(this CustomerFilterInput input, Action<UuidOperationFilterInput> mod)
    {
        var filter = new UuidOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.CustomerId = filter;
        return input;
    }

    public static CustomerFilterInput CustomerName(this CustomerFilterInput input, Action<StringOperationFilterInput> mod)
    {
        var filter = new StringOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.CustomerName = filter;
        return input;
    }

    public static CustomerFilterInput Status(this CustomerFilterInput input, Action<CustomerStatusOperationFilterInput> mod)
    {
        var filter = new CustomerStatusOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Status = filter;
        return input;
    }

    public static CustomerFilterInput Orders(this CustomerFilterInput input, Action<ListFilterInputTypeOfOrderFilterInput> mod)
    {
        var filter = new ListFilterInputTypeOfOrderFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Orders = filter;
        return input;
    }

    public static CustomerFilterInput Address(this CustomerFilterInput input, Action<AddressFilterInput> mod)
    {
        var filter = new AddressFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Address = filter;
        return input;
    }

}

public static class CustomerInputExtensions
{ 
	
    public static CustomerInput CustomerId(this CustomerInput input, Guid val)
    {
         input.CustomerId = val;
         return input;
    }


    public static CustomerInput CustomerName(this CustomerInput input, string val)
    {
         input.CustomerName = val;
         return input;
    }


    public static CustomerInput Status(this CustomerInput input, CustomerStatus val)
    {
         input.Status = val;
         return input;
    }

    public static CustomerInput Orders(this CustomerInput input, Action<List<OrderInput>> mod)
    {
        var filter = new List<OrderInput>();
        mod ??= _ => { };
        mod(filter); 
        input.Orders = filter;
        return input;
    }

    public static CustomerInput Address(this CustomerInput input, Action<AddressInput> mod)
    {
        var filter = new AddressInput();
        mod ??= _ => { };
        mod(filter); 
        input.Address = filter;
        return input;
    }

}

public static class CustomerSortInputExtensions
{ 
	
    public static CustomerSortInput CustomerId(this CustomerSortInput input, SortEnumType? val)
    {
         input.CustomerId = val;
         return input;
    }


    public static CustomerSortInput CustomerName(this CustomerSortInput input, SortEnumType? val)
    {
         input.CustomerName = val;
         return input;
    }


    public static CustomerSortInput Status(this CustomerSortInput input, SortEnumType? val)
    {
         input.Status = val;
         return input;
    }

    public static CustomerSortInput Address(this CustomerSortInput input, Action<AddressSortInput> mod)
    {
        var filter = new AddressSortInput();
        mod ??= _ => { };
        mod(filter); 
        input.Address = filter;
        return input;
    }

}

public static class CustomerStatusOperationFilterInputExtensions
{ 
	
    public static CustomerStatusOperationFilterInput Eq(this CustomerStatusOperationFilterInput input, CustomerStatus? val)
    {
         input.Eq = val;
         return input;
    }


    public static CustomerStatusOperationFilterInput Neq(this CustomerStatusOperationFilterInput input, CustomerStatus? val)
    {
         input.Neq = val;
         return input;
    }


    public static CustomerStatusOperationFilterInput In(this CustomerStatusOperationFilterInput input, List<CustomerStatus> val)
    {
         input.In = val;
         return input;
    }


    public static CustomerStatusOperationFilterInput Nin(this CustomerStatusOperationFilterInput input, List<CustomerStatus> val)
    {
         input.Nin = val;
         return input;
    }

}

public static class DateTimeOperationFilterInputExtensions
{ 
	
    public static DateTimeOperationFilterInput Eq(this DateTimeOperationFilterInput input, DateTimeOffset? val)
    {
         input.Eq = val;
         return input;
    }


    public static DateTimeOperationFilterInput Neq(this DateTimeOperationFilterInput input, DateTimeOffset? val)
    {
         input.Neq = val;
         return input;
    }


    public static DateTimeOperationFilterInput In(this DateTimeOperationFilterInput input, List<DateTimeOffset?> val)
    {
         input.In = val;
         return input;
    }


    public static DateTimeOperationFilterInput Nin(this DateTimeOperationFilterInput input, List<DateTimeOffset?> val)
    {
         input.Nin = val;
         return input;
    }


    public static DateTimeOperationFilterInput Gt(this DateTimeOperationFilterInput input, DateTimeOffset? val)
    {
         input.Gt = val;
         return input;
    }


    public static DateTimeOperationFilterInput Ngt(this DateTimeOperationFilterInput input, DateTimeOffset? val)
    {
         input.Ngt = val;
         return input;
    }


    public static DateTimeOperationFilterInput Gte(this DateTimeOperationFilterInput input, DateTimeOffset? val)
    {
         input.Gte = val;
         return input;
    }


    public static DateTimeOperationFilterInput Ngte(this DateTimeOperationFilterInput input, DateTimeOffset? val)
    {
         input.Ngte = val;
         return input;
    }


    public static DateTimeOperationFilterInput Lt(this DateTimeOperationFilterInput input, DateTimeOffset? val)
    {
         input.Lt = val;
         return input;
    }


    public static DateTimeOperationFilterInput Nlt(this DateTimeOperationFilterInput input, DateTimeOffset? val)
    {
         input.Nlt = val;
         return input;
    }


    public static DateTimeOperationFilterInput Lte(this DateTimeOperationFilterInput input, DateTimeOffset? val)
    {
         input.Lte = val;
         return input;
    }


    public static DateTimeOperationFilterInput Nlte(this DateTimeOperationFilterInput input, DateTimeOffset? val)
    {
         input.Nlte = val;
         return input;
    }

}

public static class DecimalOperationFilterInputExtensions
{ 
	
    public static DecimalOperationFilterInput Eq(this DecimalOperationFilterInput input, decimal? val)
    {
         input.Eq = val;
         return input;
    }


    public static DecimalOperationFilterInput Neq(this DecimalOperationFilterInput input, decimal? val)
    {
         input.Neq = val;
         return input;
    }


    public static DecimalOperationFilterInput In(this DecimalOperationFilterInput input, List<decimal?> val)
    {
         input.In = val;
         return input;
    }


    public static DecimalOperationFilterInput Nin(this DecimalOperationFilterInput input, List<decimal?> val)
    {
         input.Nin = val;
         return input;
    }


    public static DecimalOperationFilterInput Gt(this DecimalOperationFilterInput input, decimal? val)
    {
         input.Gt = val;
         return input;
    }


    public static DecimalOperationFilterInput Ngt(this DecimalOperationFilterInput input, decimal? val)
    {
         input.Ngt = val;
         return input;
    }


    public static DecimalOperationFilterInput Gte(this DecimalOperationFilterInput input, decimal? val)
    {
         input.Gte = val;
         return input;
    }


    public static DecimalOperationFilterInput Ngte(this DecimalOperationFilterInput input, decimal? val)
    {
         input.Ngte = val;
         return input;
    }


    public static DecimalOperationFilterInput Lt(this DecimalOperationFilterInput input, decimal? val)
    {
         input.Lt = val;
         return input;
    }


    public static DecimalOperationFilterInput Nlt(this DecimalOperationFilterInput input, decimal? val)
    {
         input.Nlt = val;
         return input;
    }


    public static DecimalOperationFilterInput Lte(this DecimalOperationFilterInput input, decimal? val)
    {
         input.Lte = val;
         return input;
    }


    public static DecimalOperationFilterInput Nlte(this DecimalOperationFilterInput input, decimal? val)
    {
         input.Nlte = val;
         return input;
    }

}

public static class FloatOperationFilterInputExtensions
{ 
	
    public static FloatOperationFilterInput Eq(this FloatOperationFilterInput input, float? val)
    {
         input.Eq = val;
         return input;
    }


    public static FloatOperationFilterInput Neq(this FloatOperationFilterInput input, float? val)
    {
         input.Neq = val;
         return input;
    }


    public static FloatOperationFilterInput In(this FloatOperationFilterInput input, List<float?> val)
    {
         input.In = val;
         return input;
    }


    public static FloatOperationFilterInput Nin(this FloatOperationFilterInput input, List<float?> val)
    {
         input.Nin = val;
         return input;
    }


    public static FloatOperationFilterInput Gt(this FloatOperationFilterInput input, float? val)
    {
         input.Gt = val;
         return input;
    }


    public static FloatOperationFilterInput Ngt(this FloatOperationFilterInput input, float? val)
    {
         input.Ngt = val;
         return input;
    }


    public static FloatOperationFilterInput Gte(this FloatOperationFilterInput input, float? val)
    {
         input.Gte = val;
         return input;
    }


    public static FloatOperationFilterInput Ngte(this FloatOperationFilterInput input, float? val)
    {
         input.Ngte = val;
         return input;
    }


    public static FloatOperationFilterInput Lt(this FloatOperationFilterInput input, float? val)
    {
         input.Lt = val;
         return input;
    }


    public static FloatOperationFilterInput Nlt(this FloatOperationFilterInput input, float? val)
    {
         input.Nlt = val;
         return input;
    }


    public static FloatOperationFilterInput Lte(this FloatOperationFilterInput input, float? val)
    {
         input.Lte = val;
         return input;
    }


    public static FloatOperationFilterInput Nlte(this FloatOperationFilterInput input, float? val)
    {
         input.Nlte = val;
         return input;
    }

}

public static class IAnimalFilterInputExtensions
{ 
	    public static IAnimalFilterInput And(this IAnimalFilterInput input, Action<List<IAnimalFilterInput>> mod)
    {
        var filter = new List<IAnimalFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.And = filter;
        return input;
    }

    public static IAnimalFilterInput Or(this IAnimalFilterInput input, Action<List<IAnimalFilterInput>> mod)
    {
        var filter = new List<IAnimalFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.Or = filter;
        return input;
    }

    public static IAnimalFilterInput Name(this IAnimalFilterInput input, Action<StringOperationFilterInput> mod)
    {
        var filter = new StringOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Name = filter;
        return input;
    }

    public static IAnimalFilterInput NumberOfLegs(this IAnimalFilterInput input, Action<IntOperationFilterInput> mod)
    {
        var filter = new IntOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.NumberOfLegs = filter;
        return input;
    }

}

public static class IAnimalSortInputExtensions
{ 
	
    public static IAnimalSortInput Name(this IAnimalSortInput input, SortEnumType? val)
    {
         input.Name = val;
         return input;
    }


    public static IAnimalSortInput NumberOfLegs(this IAnimalSortInput input, SortEnumType? val)
    {
         input.NumberOfLegs = val;
         return input;
    }

}

public static class IntOperationFilterInputExtensions
{ 
	
    public static IntOperationFilterInput Eq(this IntOperationFilterInput input, int? val)
    {
         input.Eq = val;
         return input;
    }


    public static IntOperationFilterInput Neq(this IntOperationFilterInput input, int? val)
    {
         input.Neq = val;
         return input;
    }


    public static IntOperationFilterInput In(this IntOperationFilterInput input, List<int?> val)
    {
         input.In = val;
         return input;
    }


    public static IntOperationFilterInput Nin(this IntOperationFilterInput input, List<int?> val)
    {
         input.Nin = val;
         return input;
    }


    public static IntOperationFilterInput Gt(this IntOperationFilterInput input, int? val)
    {
         input.Gt = val;
         return input;
    }


    public static IntOperationFilterInput Ngt(this IntOperationFilterInput input, int? val)
    {
         input.Ngt = val;
         return input;
    }


    public static IntOperationFilterInput Gte(this IntOperationFilterInput input, int? val)
    {
         input.Gte = val;
         return input;
    }


    public static IntOperationFilterInput Ngte(this IntOperationFilterInput input, int? val)
    {
         input.Ngte = val;
         return input;
    }


    public static IntOperationFilterInput Lt(this IntOperationFilterInput input, int? val)
    {
         input.Lt = val;
         return input;
    }


    public static IntOperationFilterInput Nlt(this IntOperationFilterInput input, int? val)
    {
         input.Nlt = val;
         return input;
    }


    public static IntOperationFilterInput Lte(this IntOperationFilterInput input, int? val)
    {
         input.Lte = val;
         return input;
    }


    public static IntOperationFilterInput Nlte(this IntOperationFilterInput input, int? val)
    {
         input.Nlte = val;
         return input;
    }

}

public static class ItemFilterInputExtensions
{ 
	    public static ItemFilterInput And(this ItemFilterInput input, Action<List<ItemFilterInput>> mod)
    {
        var filter = new List<ItemFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.And = filter;
        return input;
    }

    public static ItemFilterInput Or(this ItemFilterInput input, Action<List<ItemFilterInput>> mod)
    {
        var filter = new List<ItemFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.Or = filter;
        return input;
    }

    public static ItemFilterInput ItemId(this ItemFilterInput input, Action<StringOperationFilterInput> mod)
    {
        var filter = new StringOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.ItemId = filter;
        return input;
    }

    public static ItemFilterInput ItemName(this ItemFilterInput input, Action<StringOperationFilterInput> mod)
    {
        var filter = new StringOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.ItemName = filter;
        return input;
    }

}

public static class ItemInputExtensions
{ 
	
    public static ItemInput ItemId(this ItemInput input, string val)
    {
         input.ItemId = val;
         return input;
    }


    public static ItemInput ItemName(this ItemInput input, string val)
    {
         input.ItemName = val;
         return input;
    }

}

public static class ListFilterInputTypeOfOrderFilterInputExtensions
{ 
	    public static ListFilterInputTypeOfOrderFilterInput All(this ListFilterInputTypeOfOrderFilterInput input, Action<OrderFilterInput> mod)
    {
        var filter = new OrderFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.All = filter;
        return input;
    }

    public static ListFilterInputTypeOfOrderFilterInput None(this ListFilterInputTypeOfOrderFilterInput input, Action<OrderFilterInput> mod)
    {
        var filter = new OrderFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.None = filter;
        return input;
    }

    public static ListFilterInputTypeOfOrderFilterInput Some(this ListFilterInputTypeOfOrderFilterInput input, Action<OrderFilterInput> mod)
    {
        var filter = new OrderFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Some = filter;
        return input;
    }


    public static ListFilterInputTypeOfOrderFilterInput Any(this ListFilterInputTypeOfOrderFilterInput input, bool? val)
    {
         input.Any = val;
         return input;
    }

}

public static class ListFilterInputTypeOfOrderLineFilterInputExtensions
{ 
	    public static ListFilterInputTypeOfOrderLineFilterInput All(this ListFilterInputTypeOfOrderLineFilterInput input, Action<OrderLineFilterInput> mod)
    {
        var filter = new OrderLineFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.All = filter;
        return input;
    }

    public static ListFilterInputTypeOfOrderLineFilterInput None(this ListFilterInputTypeOfOrderLineFilterInput input, Action<OrderLineFilterInput> mod)
    {
        var filter = new OrderLineFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.None = filter;
        return input;
    }

    public static ListFilterInputTypeOfOrderLineFilterInput Some(this ListFilterInputTypeOfOrderLineFilterInput input, Action<OrderLineFilterInput> mod)
    {
        var filter = new OrderLineFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Some = filter;
        return input;
    }


    public static ListFilterInputTypeOfOrderLineFilterInput Any(this ListFilterInputTypeOfOrderLineFilterInput input, bool? val)
    {
         input.Any = val;
         return input;
    }

}

public static class OrderFilterInputExtensions
{ 
	    public static OrderFilterInput And(this OrderFilterInput input, Action<List<OrderFilterInput>> mod)
    {
        var filter = new List<OrderFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.And = filter;
        return input;
    }

    public static OrderFilterInput Or(this OrderFilterInput input, Action<List<OrderFilterInput>> mod)
    {
        var filter = new List<OrderFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.Or = filter;
        return input;
    }

    public static OrderFilterInput OrderId(this OrderFilterInput input, Action<UuidOperationFilterInput> mod)
    {
        var filter = new UuidOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.OrderId = filter;
        return input;
    }

    public static OrderFilterInput Customer(this OrderFilterInput input, Action<CustomerFilterInput> mod)
    {
        var filter = new CustomerFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Customer = filter;
        return input;
    }

    public static OrderFilterInput Address(this OrderFilterInput input, Action<AddressFilterInput> mod)
    {
        var filter = new AddressFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Address = filter;
        return input;
    }

    public static OrderFilterInput OrderDate(this OrderFilterInput input, Action<DateTimeOperationFilterInput> mod)
    {
        var filter = new DateTimeOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.OrderDate = filter;
        return input;
    }

    public static OrderFilterInput Lines(this OrderFilterInput input, Action<ListFilterInputTypeOfOrderLineFilterInput> mod)
    {
        var filter = new ListFilterInputTypeOfOrderLineFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Lines = filter;
        return input;
    }

}

public static class OrderInputExtensions
{ 
	
    public static OrderInput OrderId(this OrderInput input, Guid val)
    {
         input.OrderId = val;
         return input;
    }

    public static OrderInput Customer(this OrderInput input, Action<CustomerInput> mod)
    {
        var filter = new CustomerInput();
        mod ??= _ => { };
        mod(filter); 
        input.Customer = filter;
        return input;
    }

    public static OrderInput Address(this OrderInput input, Action<AddressInput> mod)
    {
        var filter = new AddressInput();
        mod ??= _ => { };
        mod(filter); 
        input.Address = filter;
        return input;
    }


    public static OrderInput OrderDate(this OrderInput input, DateTimeOffset val)
    {
         input.OrderDate = val;
         return input;
    }

    public static OrderInput Lines(this OrderInput input, Action<List<OrderLineInput>> mod)
    {
        var filter = new List<OrderLineInput>();
        mod ??= _ => { };
        mod(filter); 
        input.Lines = filter;
        return input;
    }

}

public static class OrderLineFilterInputExtensions
{ 
	    public static OrderLineFilterInput And(this OrderLineFilterInput input, Action<List<OrderLineFilterInput>> mod)
    {
        var filter = new List<OrderLineFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.And = filter;
        return input;
    }

    public static OrderLineFilterInput Or(this OrderLineFilterInput input, Action<List<OrderLineFilterInput>> mod)
    {
        var filter = new List<OrderLineFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.Or = filter;
        return input;
    }

    public static OrderLineFilterInput LineNumber(this OrderLineFilterInput input, Action<IntOperationFilterInput> mod)
    {
        var filter = new IntOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.LineNumber = filter;
        return input;
    }

    public static OrderLineFilterInput Order(this OrderLineFilterInput input, Action<OrderFilterInput> mod)
    {
        var filter = new OrderFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Order = filter;
        return input;
    }

    public static OrderLineFilterInput Item(this OrderLineFilterInput input, Action<ItemFilterInput> mod)
    {
        var filter = new ItemFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Item = filter;
        return input;
    }

    public static OrderLineFilterInput Price(this OrderLineFilterInput input, Action<DecimalOperationFilterInput> mod)
    {
        var filter = new DecimalOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Price = filter;
        return input;
    }

    public static OrderLineFilterInput Quantity(this OrderLineFilterInput input, Action<FloatOperationFilterInput> mod)
    {
        var filter = new FloatOperationFilterInput();
        mod ??= _ => { };
        mod(filter); 
        input.Quantity = filter;
        return input;
    }

}

public static class OrderLineInputExtensions
{ 
	
    public static OrderLineInput LineNumber(this OrderLineInput input, int val)
    {
         input.LineNumber = val;
         return input;
    }

    public static OrderLineInput Order(this OrderLineInput input, Action<OrderInput> mod)
    {
        var filter = new OrderInput();
        mod ??= _ => { };
        mod(filter); 
        input.Order = filter;
        return input;
    }

    public static OrderLineInput Item(this OrderLineInput input, Action<ItemInput> mod)
    {
        var filter = new ItemInput();
        mod ??= _ => { };
        mod(filter); 
        input.Item = filter;
        return input;
    }


    public static OrderLineInput Price(this OrderLineInput input, decimal val)
    {
         input.Price = val;
         return input;
    }


    public static OrderLineInput Quantity(this OrderLineInput input, float val)
    {
         input.Quantity = val;
         return input;
    }

}

public static class OrderSortInputExtensions
{ 
	
    public static OrderSortInput OrderId(this OrderSortInput input, SortEnumType? val)
    {
         input.OrderId = val;
         return input;
    }

    public static OrderSortInput Customer(this OrderSortInput input, Action<CustomerSortInput> mod)
    {
        var filter = new CustomerSortInput();
        mod ??= _ => { };
        mod(filter); 
        input.Customer = filter;
        return input;
    }

    public static OrderSortInput Address(this OrderSortInput input, Action<AddressSortInput> mod)
    {
        var filter = new AddressSortInput();
        mod ??= _ => { };
        mod(filter); 
        input.Address = filter;
        return input;
    }


    public static OrderSortInput OrderDate(this OrderSortInput input, SortEnumType? val)
    {
         input.OrderDate = val;
         return input;
    }

}

public static class StringOperationFilterInputExtensions
{ 
	    public static StringOperationFilterInput And(this StringOperationFilterInput input, Action<List<StringOperationFilterInput>> mod)
    {
        var filter = new List<StringOperationFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.And = filter;
        return input;
    }

    public static StringOperationFilterInput Or(this StringOperationFilterInput input, Action<List<StringOperationFilterInput>> mod)
    {
        var filter = new List<StringOperationFilterInput>();
        mod ??= _ => { };
        mod(filter); 
        input.Or = filter;
        return input;
    }


    public static StringOperationFilterInput Eq(this StringOperationFilterInput input, string val)
    {
         input.Eq = val;
         return input;
    }


    public static StringOperationFilterInput Neq(this StringOperationFilterInput input, string val)
    {
         input.Neq = val;
         return input;
    }


    public static StringOperationFilterInput Contains(this StringOperationFilterInput input, string val)
    {
         input.Contains = val;
         return input;
    }


    public static StringOperationFilterInput Ncontains(this StringOperationFilterInput input, string val)
    {
         input.Ncontains = val;
         return input;
    }


    public static StringOperationFilterInput In(this StringOperationFilterInput input, List<string> val)
    {
         input.In = val;
         return input;
    }


    public static StringOperationFilterInput Nin(this StringOperationFilterInput input, List<string> val)
    {
         input.Nin = val;
         return input;
    }


    public static StringOperationFilterInput StartsWith(this StringOperationFilterInput input, string val)
    {
         input.StartsWith = val;
         return input;
    }


    public static StringOperationFilterInput NstartsWith(this StringOperationFilterInput input, string val)
    {
         input.NstartsWith = val;
         return input;
    }


    public static StringOperationFilterInput EndsWith(this StringOperationFilterInput input, string val)
    {
         input.EndsWith = val;
         return input;
    }


    public static StringOperationFilterInput NendsWith(this StringOperationFilterInput input, string val)
    {
         input.NendsWith = val;
         return input;
    }

}

public static class UuidOperationFilterInputExtensions
{ 
	
    public static UuidOperationFilterInput Eq(this UuidOperationFilterInput input, Guid? val)
    {
         input.Eq = val;
         return input;
    }


    public static UuidOperationFilterInput Neq(this UuidOperationFilterInput input, Guid? val)
    {
         input.Neq = val;
         return input;
    }


    public static UuidOperationFilterInput In(this UuidOperationFilterInput input, List<Guid?> val)
    {
         input.In = val;
         return input;
    }


    public static UuidOperationFilterInput Nin(this UuidOperationFilterInput input, List<Guid?> val)
    {
         input.Nin = val;
         return input;
    }


    public static UuidOperationFilterInput Gt(this UuidOperationFilterInput input, Guid? val)
    {
         input.Gt = val;
         return input;
    }


    public static UuidOperationFilterInput Ngt(this UuidOperationFilterInput input, Guid? val)
    {
         input.Ngt = val;
         return input;
    }


    public static UuidOperationFilterInput Gte(this UuidOperationFilterInput input, Guid? val)
    {
         input.Gte = val;
         return input;
    }


    public static UuidOperationFilterInput Ngte(this UuidOperationFilterInput input, Guid? val)
    {
         input.Ngte = val;
         return input;
    }


    public static UuidOperationFilterInput Lt(this UuidOperationFilterInput input, Guid? val)
    {
         input.Lt = val;
         return input;
    }


    public static UuidOperationFilterInput Nlt(this UuidOperationFilterInput input, Guid? val)
    {
         input.Nlt = val;
         return input;
    }


    public static UuidOperationFilterInput Lte(this UuidOperationFilterInput input, Guid? val)
    {
         input.Lte = val;
         return input;
    }


    public static UuidOperationFilterInput Nlte(this UuidOperationFilterInput input, Guid? val)
    {
         input.Nlte = val;
         return input;
    }

}
