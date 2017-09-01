using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _xxobj_operand__il_dbglocalloc__il_dbglocalloc_
    {
        [ActiveIssue("2444")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_dbglocalloc__il_dbglocalloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_dbglocalloc\\_il_dbglocalloc.cmd");
        }
    }
}
