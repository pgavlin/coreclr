using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwinfinallyerrpath_r_throwinfinallyerrpath_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwinfinallyerrpath_r_throwinfinallyerrpath_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwinfinallyerrpath_r\\throwinfinallyerrpath_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
