using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_FinallyExec_nonlocalexitintry_nonlocalexitintry_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalexitintry_nonlocalexitintry_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalexitintry\\nonlocalexitintry.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
