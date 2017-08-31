using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_localgotoinahandler_do_localgotoinahandler_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_finallyexec_localgotoinahandler_do_localgotoinahandler_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\localgotoinahandler_do\\localgotoinahandler_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
