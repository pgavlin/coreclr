using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _HeapExpansion_bestfit_bestfit_
    {
        [Fact]
        public void _HeapExpansion_bestfit_bestfit_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\bestfit\\bestfit.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
