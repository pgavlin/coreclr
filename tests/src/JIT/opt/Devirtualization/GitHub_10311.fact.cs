using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_GitHub_10311_GitHub_10311_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_GitHub_10311_GitHub_10311_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\GitHub_10311\\GitHub_10311.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
