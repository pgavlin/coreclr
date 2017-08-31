using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_GitHub_10858_GitHub_10858_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_GitHub_10858_GitHub_10858_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\GitHub_10858\\GitHub_10858.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
