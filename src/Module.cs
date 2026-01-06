namespace IRGenerator
{
	public sealed class Module
	{
		public readonly List<Function> Functions = new();
		public readonly string ModuleName;
			
		public Module(string moduleName)
		{
			ModuleName = moduleName;
		}
		
		public void AddFunction(Function function)
			=> Functions.Add(function);
		
		public IEnumerable<string> Emit()
		{
			foreach (var f in Functions)
			{
				foreach (string line in f.Emit())
				{
					yield return line;
				}
			}
		}
	}
}