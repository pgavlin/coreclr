using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _DumpDisasm_JitMinOpts_InstrCnt1_InstrCnt1_
    {
        [Fact]
        public void _DumpDisasm_JitMinOpts_InstrCnt1_InstrCnt1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\DumpDisasm\\JitMinOpts\\InstrCnt1\\InstrCnt1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
