using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_rethrow_rethrowinfinallyaftercatch_do_rethrowinfinallyaftercatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_rethrowinfinallyaftercatch_do_rethrowinfinallyaftercatch_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\rethrowinfinallyaftercatch_do\\rethrowinfinallyaftercatch_do.cmd");
        }
    }
}
