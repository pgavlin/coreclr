using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _PartialCompaction_eco1_eco1_
    {
        [OuterLoop]
        [Fact]
        public void _PartialCompaction_eco1_eco1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\PartialCompaction\\eco1\\eco1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
