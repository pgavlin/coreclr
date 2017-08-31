using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_gcincatch_r_gcincatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_gcincatch_r_gcincatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\gcincatch_r\\gcincatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
