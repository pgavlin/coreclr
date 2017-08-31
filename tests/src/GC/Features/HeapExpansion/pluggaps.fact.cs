using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _HeapExpansion_pluggaps_pluggaps_
    {
        [Fact]
        public void _HeapExpansion_pluggaps_pluggaps_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\pluggaps\\pluggaps.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
