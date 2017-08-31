using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _eh_FinallyExec_nonlocalexitinhandler_nonlocalexitinhandler_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalexitinhandler_nonlocalexitinhandler_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalexitinhandler\\nonlocalexitinhandler.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
