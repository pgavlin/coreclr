using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_GitHub_9945_GitHub_9945_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_GitHub_9945_GitHub_9945_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\GitHub_9945\\GitHub_9945.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
