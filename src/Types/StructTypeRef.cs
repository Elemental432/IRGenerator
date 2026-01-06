using System.Collections.Immutable;

namespace IRGenerator
{
	public sealed class StructTypeRef : BaseTypeRef
	{
		public readonly ImmutableArray<BaseTypeRef> Types;
		
		public StructTypeRef(ImmutableArray<BaseTypeRef> types)
		{
			Types = types;
		}
		
		public override string ToString()
			=> $"{{ {string.Join(", ", Types.Select(t => t.ToString()))} }}";
	}
}