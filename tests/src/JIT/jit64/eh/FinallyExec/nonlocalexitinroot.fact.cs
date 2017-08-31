using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_FinallyExec_nonlocalexitinroot_nonlocalexitinroot_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalexitinroot_nonlocalexitinroot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalexitinroot\\nonlocalexitinroot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
