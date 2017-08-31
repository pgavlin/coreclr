using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_localgotoinahandler_ro_localgotoinahandler_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_localgotoinahandler_ro_localgotoinahandler_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\localgotoinahandler_ro\\localgotoinahandler_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
