using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Alloc_neg2_Alloc_neg2_
    {
        [Fact]
        public void _GCHandle_Alloc_neg2_Alloc_neg2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Alloc_neg2\\Alloc_neg2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
