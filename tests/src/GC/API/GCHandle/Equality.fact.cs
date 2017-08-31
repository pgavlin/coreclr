using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Equality_Equality_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Equality_Equality_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Equality\\Equality.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
