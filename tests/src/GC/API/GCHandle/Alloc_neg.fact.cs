using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCHandle_Alloc_neg_Alloc_neg_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Alloc_neg_Alloc_neg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Alloc_neg\\Alloc_neg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
