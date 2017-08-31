using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Alloc_Alloc_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Alloc_Alloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Alloc\\Alloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
