using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _tailcall__il_dbgpointer_i__il_dbgpointer_i_
    {
        [ActiveIssue("2451")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _tailcall__il_dbgpointer_i__il_dbgpointer_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgpointer_i\\_il_dbgpointer_i.cmd");
        }
    }
}
