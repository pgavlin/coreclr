using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_Leaves_nonlocalexitfromnestedcatch_nonlocalexitfromnestedcatch_
    {
        [OuterLoop]
        [Fact]
        public void _eh_Leaves_nonlocalexitfromnestedcatch_nonlocalexitfromnestedcatch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\Leaves\\nonlocalexitfromnestedcatch\\nonlocalexitfromnestedcatch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
