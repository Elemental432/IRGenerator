namespace IRGenerator;

using System.Numerics;

public abstract class ValueRef {
	
}

public sealed class VoidValue : ValueRef {
	public readonly PrimitiveTypeRef Type;
	
	public VoidValue(PrimitiveTypeRef type) {
		Type = type;
	}
	
	public override string ToString() => Type.ToString();
}

public sealed class ConstIntValue : ValueRef {
	public readonly PrimitiveTypeRef Type;
	public readonly BigInteger Value;
	
	public ConstIntValue(PrimitiveTypeRef type, BigInteger value) {
		Type = type;
		Value = value;
	}
	
	public override string ToString() => $"{Type} {Value}";
}

public sealed class StructValue : ValueRef {
	public readonly ValueRef[] Values;
	
	public StructValue(ValueRef[] values) {
		Values = values;
	}
	
	public override string ToString() => $"{{ {string.Join(", ", Values.Select(v => v.ToString()))} }}";
}