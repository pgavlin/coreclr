using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_nestedfinallycall_d_nestedfinallycall_d_
    {
        [Fact]
        public void _eh_finallyexec_nestedfinallycall_d_nestedfinallycall_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nestedfinallycall_d\\nestedfinallycall_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
