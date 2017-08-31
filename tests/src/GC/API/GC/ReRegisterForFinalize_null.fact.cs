using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_ReRegisterForFinalize_null_ReRegisterForFinalize_null_
    {
        [Fact]
        public void _GC_ReRegisterForFinalize_null_ReRegisterForFinalize_null_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\ReRegisterForFinalize_null\\ReRegisterForFinalize_null.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
