using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_SuppressFinalize_SuppressFinalize_
    {
        [OuterLoop]
        [Fact]
        public void _GC_SuppressFinalize_SuppressFinalize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\SuppressFinalize\\SuppressFinalize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
