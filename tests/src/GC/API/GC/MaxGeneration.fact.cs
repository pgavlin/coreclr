using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_MaxGeneration_MaxGeneration_
    {
        [Fact]
        public void _GC_MaxGeneration_MaxGeneration_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\MaxGeneration\\MaxGeneration.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
