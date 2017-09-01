using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _xxobj_operand__il_rellocalloc__il_rellocalloc_
    {
        [ActiveIssue("2444")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _xxobj_operand__il_rellocalloc__il_rellocalloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\operand\\_il_rellocalloc\\_il_rellocalloc.cmd");
        }
    }
}
