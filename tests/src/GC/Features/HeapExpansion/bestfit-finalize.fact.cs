using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _HeapExpansion_bestfit_finalize_bestfit_finalize_
    {
        [Fact]
        public void _HeapExpansion_bestfit_finalize_bestfit_finalize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\bestfit-finalize\\bestfit-finalize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
