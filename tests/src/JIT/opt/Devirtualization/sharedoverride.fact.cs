using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_sharedoverride_sharedoverride_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_sharedoverride_sharedoverride_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\sharedoverride\\sharedoverride.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
