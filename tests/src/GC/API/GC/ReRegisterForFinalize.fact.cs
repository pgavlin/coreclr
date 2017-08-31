using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_ReRegisterForFinalize_ReRegisterForFinalize_
    {
        [OuterLoop]
        [Fact]
        public void _GC_ReRegisterForFinalize_ReRegisterForFinalize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\ReRegisterForFinalize\\ReRegisterForFinalize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
