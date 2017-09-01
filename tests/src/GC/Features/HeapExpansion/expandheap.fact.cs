using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _HeapExpansion_expandheap_expandheap_
    {
        [Fact]
        public void _HeapExpansion_expandheap_expandheap_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\expandheap\\expandheap.cmd");
        }
    }
}
