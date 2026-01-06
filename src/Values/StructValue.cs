using System.Collections.Immutable;

namespace IRGenerator
{
	public sealed class StructValue : BaseValueRef
	{
		public readonly ImmutableArray<BaseValueRef> Values;
		
		public StructValue(ImmutableArray<BaseValueRef> values)
		{
			Values = values;
		}
		
		public override string ToString()
			=> $"{{ {string.Join(", ", Values.Select(v => v.ToString()))} }}";
	}
}