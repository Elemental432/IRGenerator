namespace IRGenerator;

public sealed class BasicBlock {
	public readonly string Name;
	
	public readonly List<Instruction> Instructions = new();
	
	public BasicBlock(string blockName) {
		Name = blockName;
	}
	
	public void AppendInstruction(Instruction instruction) => Instructions.Add(instruction);
	
	public IEnumerable<string> Emit() {
		yield return $"{Name}:";
		
		foreach (var i in Instructions) {
			foreach (var r in i.Emit()) {
				yield return $"  {r}";
			}
		}
	}
}