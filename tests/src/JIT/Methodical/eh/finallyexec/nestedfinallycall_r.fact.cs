using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_nestedfinallycall_r_nestedfinallycall_r_
    {
        [Fact]
        public void _eh_finallyexec_nestedfinallycall_r_nestedfinallycall_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nestedfinallycall_r\\nestedfinallycall_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
