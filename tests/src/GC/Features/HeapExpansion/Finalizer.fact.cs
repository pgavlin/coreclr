using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _HeapExpansion_Finalizer_Finalizer_
    {
        [Fact]
        public void _HeapExpansion_Finalizer_Finalizer_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\Finalizer\\Finalizer.cmd");
        }
    }
}
