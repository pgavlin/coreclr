using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _DumpDisasm_JitMinOpts_LVNumCnt1_LVNumCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _DumpDisasm_JitMinOpts_LVNumCnt1_LVNumCnt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\DumpDisasm\\JitMinOpts\\LVNumCnt1\\LVNumCnt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
