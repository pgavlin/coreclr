using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _DumpDisasm_JitMinOpts_CodeSize1_CodeSize1_
    {
        [OuterLoop]
        [Fact]
        public void _DumpDisasm_JitMinOpts_CodeSize1_CodeSize1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\DumpDisasm\\JitMinOpts\\CodeSize1\\CodeSize1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
