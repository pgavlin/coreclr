using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_SuppressFinalize_Null_SuppressFinalize_Null_
    {
        [Fact]
        public void _GC_SuppressFinalize_Null_SuppressFinalize_Null_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\SuppressFinalize_Null\\SuppressFinalize_Null.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
