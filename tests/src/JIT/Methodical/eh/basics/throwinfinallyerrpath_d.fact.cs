using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyerrpath_d_throwinfinallyerrpath_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyerrpath_d_throwinfinallyerrpath_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyerrpath_d\\throwinfinallyerrpath_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
