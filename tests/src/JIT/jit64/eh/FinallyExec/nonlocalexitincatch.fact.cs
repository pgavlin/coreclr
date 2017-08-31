using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_FinallyExec_nonlocalexitincatch_nonlocalexitincatch_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalexitincatch_nonlocalexitincatch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalexitincatch\\nonlocalexitincatch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
