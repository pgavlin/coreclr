using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_FinallyExec_nonlocalexitinfinally_nonlocalexitinfinally_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalexitinfinally_nonlocalexitinfinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalexitinfinally\\nonlocalexitinfinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
