using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Finalize_Finalize_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Finalize_Finalize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Finalize\\Finalize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
