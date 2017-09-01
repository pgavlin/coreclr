using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _HeapExpansion_Handles_Handles_
    {
        [Fact]
        public void _HeapExpansion_Handles_Handles_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\Handles\\Handles.cmd");
        }
    }
}
