using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_gcincatch_ro_gcincatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_interactions_gcincatch_ro_gcincatch_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\gcincatch_ro\\gcincatch_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
