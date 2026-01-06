namespace IRGenerator;

public abstract class Instruction {
	public abstract Opcode Op { get; protected set; }
	
	public abstract IEnumerable<string> Emit();
}

public sealed class ReturnInstruction : Instruction {
	public override Opcode Op { get; protected set; } = Opcode.Ret;
	public readonly BaseValueRef ValueRef;
	
	public ReturnInstruction(BaseValueRef valueRef) {
		ValueRef = valueRef;
	}
	
	public override IEnumerable<string> Emit() {
		yield return $"{Op.ToString().ToLower()} {ValueRef}";
	}
}