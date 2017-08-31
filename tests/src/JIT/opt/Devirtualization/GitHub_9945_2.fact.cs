using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_GitHub_9945_2_GitHub_9945_2_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_GitHub_9945_2_GitHub_9945_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\GitHub_9945_2\\GitHub_9945_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
