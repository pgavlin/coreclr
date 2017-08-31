using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _DumpDisasm_JitMinOpts_BBCnt1_BBCnt1_
    {
        [OuterLoop]
        [Fact]
        public void _DumpDisasm_JitMinOpts_BBCnt1_BBCnt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\DumpDisasm\\JitMinOpts\\BBCnt1\\BBCnt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
