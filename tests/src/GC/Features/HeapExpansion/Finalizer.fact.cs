using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _HeapExpansion_Finalizer_Finalizer_
    {
        [Fact]
        public void _HeapExpansion_Finalizer_Finalizer_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\Finalizer\\Finalizer.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
