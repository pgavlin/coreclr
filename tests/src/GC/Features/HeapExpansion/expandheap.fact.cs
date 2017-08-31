using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _HeapExpansion_expandheap_expandheap_
    {
        [Fact]
        public void _HeapExpansion_expandheap_expandheap_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\expandheap\\expandheap.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
