using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall__il_dbgpointer__il_dbgpointer_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _tailcall__il_dbgpointer__il_dbgpointer_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgpointer\\_il_dbgpointer.cmd");
        }
    }
}
