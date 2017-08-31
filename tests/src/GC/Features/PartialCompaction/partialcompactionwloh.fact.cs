using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _PartialCompaction_partialcompactionwloh_partialcompactionwloh_
    {
        [OuterLoop]
        [Fact]
        public void _PartialCompaction_partialcompactionwloh_partialcompactionwloh_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\PartialCompaction\\partialcompactionwloh\\partialcompactionwloh.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
