using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyerrpath_do_throwinfinallyerrpath_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyerrpath_do_throwinfinallyerrpath_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyerrpath_do\\throwinfinallyerrpath_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
