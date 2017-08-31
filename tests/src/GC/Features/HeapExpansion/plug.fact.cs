using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _HeapExpansion_plug_plug_
    {
        [Fact]
        public void _HeapExpansion_plug_plug_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\plug\\plug.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
