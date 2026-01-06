using System.Numerics;

namespace IRGenerator
{
	public sealed class ConstIntValue : BaseValueRef
	{
		public readonly PrimitiveTypeRef Type;
		public readonly BigInteger Value;
		
		public ConstIntValue(PrimitiveTypeRef type, BigInteger value)
		{
			Type = type;
			Value = value;
		}
		
		public override string ToString()
			=> $"{Type} {Value}";
	}
}