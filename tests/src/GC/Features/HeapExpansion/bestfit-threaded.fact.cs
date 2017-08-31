using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _HeapExpansion_bestfit_threaded_bestfit_threaded_
    {
        [Fact]
        public void _HeapExpansion_bestfit_threaded_bestfit_threaded_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\bestfit-threaded\\bestfit-threaded.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
