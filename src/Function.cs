namespace IRGenerator;

public sealed class Function {
	public readonly string Name;
	public readonly BaseTypeRef ReturnType;
	public readonly IRParameter[] Parameters;
	
	public readonly List<BasicBlock> Blocks = new();
	
	private int RC = 0;
	
	public Function(string name, BaseTypeRef returnType, IRParameter[] parameters) {
		Name = name;
		ReturnType = returnType;
		Parameters = parameters;
		
		foreach (var p in Parameters) {
			if (string.IsNullOrEmpty(p.Name))
				p.Name = $"%{RC++}";
			else
				p.Name = $"%{p.Name}";
		}
	}
	
	public void AppendBasicBlock(BasicBlock block) => Blocks.Add(block);
	
	public IEnumerable<string> Emit() {
		yield return $"define {ReturnType} @{Name}({string.Join(", ", Parameters.Select(p => p.ToString()))}) {{";
		
		foreach (var b in Blocks) {
			foreach (var r in b.Emit()) {
				yield return $"  {r}";
			}
		}
		
		yield return "}";
	}
}

public sealed class IRParameter {
	public readonly BaseTypeRef Type;
	public string Name { get; internal set; }
	
	public IRParameter(BaseTypeRef type, string name = "") {
		Type = type;
		Name = name;
	}
	
	public override string ToString() => $"{Type} {Name}";
}