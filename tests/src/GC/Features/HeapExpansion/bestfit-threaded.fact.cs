using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _HeapExpansion_bestfit_threaded_bestfit_threaded_
    {
        [Fact]
        public void _HeapExpansion_bestfit_threaded_bestfit_threaded_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\bestfit-threaded\\bestfit-threaded.cmd");
        }
    }
}
