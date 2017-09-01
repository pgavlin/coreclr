using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_rethrow_rethrowinfinallyinsidecatch_r_rethrowinfinallyinsidecatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_rethrow_rethrowinfinallyinsidecatch_r_rethrowinfinallyinsidecatch_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\rethrow\\rethrowinfinallyinsidecatch_r\\rethrowinfinallyinsidecatch_r.cmd");
        }
    }
}
