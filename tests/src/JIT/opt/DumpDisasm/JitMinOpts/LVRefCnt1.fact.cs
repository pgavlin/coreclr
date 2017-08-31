using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _DumpDisasm_JitMinOpts_LVRefCnt1_LVRefCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _DumpDisasm_JitMinOpts_LVRefCnt1_LVRefCnt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\DumpDisasm\\JitMinOpts\\LVRefCnt1\\LVRefCnt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
