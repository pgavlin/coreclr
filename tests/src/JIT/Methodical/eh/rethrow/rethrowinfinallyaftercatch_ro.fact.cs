using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_rethrow_rethrowinfinallyaftercatch_ro_rethrowinfinallyaftercatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_rethrowinfinallyaftercatch_ro_rethrowinfinallyaftercatch_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\rethrowinfinallyaftercatch_ro\\rethrowinfinallyaftercatch_ro.cmd");
        }
    }
}
