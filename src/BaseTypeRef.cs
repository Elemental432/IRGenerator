namespace IRGenerator;

public abstract class BaseTypeRef {
	
}

public sealed class PrimitiveTypeRef : BaseTypeRef {
	public readonly string Type;
	
	private PrimitiveTypeRef(string type) {
		Type = type;
	}
	
	public static readonly PrimitiveTypeRef Void = new("void");
	public static readonly PrimitiveTypeRef Int32 = new("i32");
	
	public override string ToString() => Type;
}

public sealed class StructTypeRef : BaseTypeRef {
	public readonly BaseTypeRef[] Types;
	
	public StructTypeRef(BaseTypeRef[] types) {
		Types = types;
	}
	
	public override string ToString() => $"{{ {string.Join(", ", Types.Select(t => t.ToString()))} }}";
}