using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_localgotoinahandler_r_localgotoinahandler_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_localgotoinahandler_r_localgotoinahandler_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\localgotoinahandler_r\\localgotoinahandler_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
