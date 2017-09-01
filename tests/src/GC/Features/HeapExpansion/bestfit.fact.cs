using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _HeapExpansion_bestfit_bestfit_
    {
        [Fact]
        public void _HeapExpansion_bestfit_bestfit_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\bestfit\\bestfit.cmd");
        }
    }
}
