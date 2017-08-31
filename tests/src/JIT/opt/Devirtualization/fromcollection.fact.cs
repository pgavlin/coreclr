using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_fromcollection_fromcollection_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_fromcollection_fromcollection_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\fromcollection\\fromcollection.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
