namespace IRGenerator
{
	public sealed class PrimitiveTypeRef : BaseTypeRef
	{
		public readonly string Type;
		
		private PrimitiveTypeRef(string type)
		{
			Type = type;
		}
		
		public static readonly PrimitiveTypeRef Void = new("void");
		public static readonly PrimitiveTypeRef Int32 = new("i32");
		
		public override string ToString()
			=> Type;
	}
}