using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _HeapExpansion_bestfit_finalize_bestfit_finalize_
    {
        [Fact]
        public void _HeapExpansion_bestfit_finalize_bestfit_finalize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\bestfit-finalize\\bestfit-finalize.cmd");
        }
    }
}
