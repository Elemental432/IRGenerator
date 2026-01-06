namespace IRGenerator
{
	public sealed class VoidValue : BaseValueRef
	{
		public readonly PrimitiveTypeRef Type;
		
		public VoidValue(PrimitiveTypeRef type)
		{
			Type = type;
		}
		
		public override string ToString()
			=> Type.ToString();
	}
}