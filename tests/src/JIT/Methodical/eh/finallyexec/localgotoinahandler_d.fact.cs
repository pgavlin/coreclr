using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_localgotoinahandler_d_localgotoinahandler_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_localgotoinahandler_d_localgotoinahandler_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\localgotoinahandler_d\\localgotoinahandler_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
