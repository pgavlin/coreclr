using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _HeapExpansion_bestfit_1_bestfit_1_
    {
        [Fact]
        public void _HeapExpansion_bestfit_1_bestfit_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\bestfit_1\\bestfit_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
