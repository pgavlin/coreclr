using CoreclrTestLib;
using Xunit;

namespace JIT_CheckProjects
{
    class _CheckProjects_CheckProjects_
    {
        [Fact]
        public void _CheckProjects_CheckProjects_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CheckProjects\\CheckProjects\\CheckProjects.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
