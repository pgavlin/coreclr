using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_gcincatch_d_gcincatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_gcincatch_d_gcincatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\gcincatch_d\\gcincatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
