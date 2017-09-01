using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _HeapExpansion_bestfit_1_bestfit_1_
    {
        [Fact]
        public void _HeapExpansion_bestfit_1_bestfit_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\bestfit_1\\bestfit_1.cmd");
        }
    }
}
