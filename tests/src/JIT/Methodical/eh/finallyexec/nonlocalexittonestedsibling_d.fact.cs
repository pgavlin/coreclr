using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_nonlocalexittonestedsibling_d_nonlocalexittonestedsibling_d_
    {
        [Fact]
        public void _eh_finallyexec_nonlocalexittonestedsibling_d_nonlocalexittonestedsibling_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\nonlocalexittonestedsibling_d\\nonlocalexittonestedsibling_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
