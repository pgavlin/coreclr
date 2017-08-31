using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _HeapExpansion_Handles_Handles_
    {
        [Fact]
        public void _HeapExpansion_Handles_Handles_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\Handles\\Handles.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
