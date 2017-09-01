using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _HeapExpansion_pluggaps_pluggaps_
    {
        [Fact]
        public void _HeapExpansion_pluggaps_pluggaps_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\pluggaps\\pluggaps.cmd");
        }
    }
}
